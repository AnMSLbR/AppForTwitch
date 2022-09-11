using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Diagnostics;
using System.Xml.Serialization;

namespace AppForTwitch
{
    public partial class MainForm : Form
    {

        private Bot bot;
        private SoundPlayer sound;
        private BindingList<Command> commandList;
        private bool isListChange = false;
        public MainForm()
        {
            InitializeComponent();
            UpdateStatusLabel();
            UpdateInitializationData();
            SetSoundButtonStatus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Stream str = Properties.Resources.mention_notification;
            sound = new SoundPlayer(str);
            commandList = new BindingList<Command>();
            LoadCommandList();
            lb_CommandList.DataSource = commandList;
            lb_CommandList.DisplayMember = "KeyWord";
            commandList.ListChanged += new ListChangedEventHandler(commandList_ListChanged);      
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSoundButtonStatus();
            if (isListChange)
                SaveCommandList();
        }

        private void btn_InsertToken_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                tb_Token.Text = Clipboard.GetText();
            }
        }

        private void btn_InsertBotName_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                tb_BotChannelName.Text = Clipboard.GetText();
            }
        }

        private void btn_InsertStreamerName_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                tb_StreamChannelName.Text = Clipboard.GetText();
            }
        }

        private void btn_Start_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Token.Text) || String.IsNullOrWhiteSpace(tb_BotChannelName.Text) || String.IsNullOrWhiteSpace(tb_StreamChannelName.Text))
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                if (cb_Remember.Checked)
                    RememberInitializationData();
                else
                    ClearInitializationData();
                StartBot();
            }
            UpdateStatusLabel();
        }

        private void StartBot()
        {
            if (bot != null)
                bot.Stop();
            bot = new Bot(tb_Token.Text, tb_BotChannelName.Text, tb_StreamChannelName.Text);
            bot.OnChatBotMessageReceived += Bot_OnChatBotMessageReceived;
            bot.OnChatBotMessageSended += Bot_OnChatBotMessageSended;
            bot.OnChatMentionMessageReceived += Bot_OnChatMentionMessageReceived;
            bot.OnRoleChecked += Bot_OnRoleChecked;
            bot.CommandList = commandList;
            bot.Start();
        }

        private void RememberInitializationData()
        {
            Properties.Settings.Default.Token = tb_Token.Text;
            Properties.Settings.Default.BotChannelName = tb_BotChannelName.Text;
            Properties.Settings.Default.StreamChannelName = tb_StreamChannelName.Text;
            Properties.Settings.Default.RememberCheckBoxFlag = cb_Remember.Checked;
            Properties.Settings.Default.Save();
        }

        private void ClearInitializationData()
        {
            Properties.Settings.Default.Token = "";
            Properties.Settings.Default.BotChannelName = "";
            Properties.Settings.Default.StreamChannelName = "";
            Properties.Settings.Default.RememberCheckBoxFlag = cb_Remember.Checked;
            Properties.Settings.Default.Save();
        }

        private void UpdateStatusLabel()
        {
            if (bot != null && bot.IsConnected())
            {
                lbl_Status.Text = "Connected";
            }
            else
            {
                lbl_Status.Text = "Unconnected";
            }
        }

        private void UpdateInitializationData()
        {
            if (Properties.Settings.Default.Token != string.Empty)
            {
                tb_Token.Text = Properties.Settings.Default.Token;
                tb_BotChannelName.Text = Properties.Settings.Default.BotChannelName;
                tb_StreamChannelName.Text = Properties.Settings.Default.StreamChannelName;
                cb_Remember.Checked = Properties.Settings.Default.RememberCheckBoxFlag;
            }
        }

        private void SaveCommandList()
        {
            try
            {
                if (commandList.Count != 0)
                {
                    SerializeCommandListToXml(commandList);
                }
                else
                {
                    File.Delete("Commands.xml");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void LoadCommandList()
        {
            try
            {
                if (File.Exists("Commands.xml"))
                {
                    commandList = DeserializeXmlToCommandList();
                }
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("Invalid Commands.xml file", "Error");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void SerializeCommandListToXml(BindingList<Command> list)
        {
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<Command>));

            using (FileStream fs = new FileStream("Commands.xml", FileMode.Create))
            {
                xml.Serialize(fs, list);
            }
        }

        private BindingList<Command> DeserializeXmlToCommandList()
        {
            XmlSerializer xml = new XmlSerializer(typeof(BindingList<Command>));

            using (FileStream fs = new FileStream("Commands.xml", FileMode.OpenOrCreate))
            {
                return (BindingList<Command>)xml.Deserialize(fs);
            }
        }

        private void lLbl_Token_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ProcessStartInfo sInfo = new ProcessStartInfo("https://www.twitchapps.com/tmi/")
            {
                UseShellExecute = true,
                Verb = "open"
            };
            Process.Start(sInfo);
        }
        private void commandList_ListChanged(object sender, ListChangedEventArgs e)
        {
            isListChange = true;
        }

        #region Chat Tab
        private void Bot_OnRoleChecked(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => UpdateAntispamTabControls()));
        }

        private void Bot_OnChatBotMessageReceived(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                tb_MyChat.Text += DateTime.Now.ToString("HH:mm:ss") + $" {bot.MessageSender}: {bot.SendedMessage}\r\n";
            }));
        }

        private void Bot_OnChatMentionMessageReceived(object sender, EventArgs e)
        {
            if (bot.MessageSender.ToLower() != bot.BotChannel)
            {
                this.Invoke(new Action(() =>
                {
                    tb_MyChat.Text += DateTime.Now.ToString("HH:mm:ss") + $" {bot.MessageSender}: {bot.SendedMessage}\r\n";
                    if (toggleB_Sound.Checked)
                        sound.Play();
                }));
            }
        }

        private void Bot_OnChatBotMessageSended(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => tb_MyChat.Text += DateTime.Now.ToString("HH:mm:ss") + $" {bot.MessageSender}: {bot.SendedMessage}\r\n"));
        }

        private void SetSoundButtonStatus()
        {
            toggleB_Sound.Checked = Properties.Settings.Default.SoundButtonStatus;
        }

        private void SaveSoundButtonStatus()
        {
            Properties.Settings.Default.SoundButtonStatus = toggleB_Sound.Checked;
            Properties.Settings.Default.Save();
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            if (bot != null && bot.IsConnected())
            {
                for (int i = 0; i < Convert.ToInt32(roundedTB_Repeats.Texts); i++)
                {
                    bot.Send(tb_Message.Text);
                }
                tb_Message.Clear();
            }
        }

        private void tb_Message_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
            }
        }

        private void roundedTB_Repeats_Leave(object sender, EventArgs e)
        {
            int repeats;
            if (Int32.TryParse(roundedTB_Repeats.Texts, out repeats))
            {
                if (repeats < 1)
                    roundedTB_Repeats.Texts = "1";
                else if (repeats > 999)
                    roundedTB_Repeats.Texts = "999";
            }
            else
            {
                roundedTB_Repeats.Texts = "1";
            }
        }

        private void roundedTB_Repeats_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8)
            {
                e.Handled = true;
            }
        }

        private void tb_MyChat_TextChanged(object sender, EventArgs e)
        {
            tb_MyChat.SelectionStart = tb_MyChat.Text.Length;
            tb_MyChat.ScrollToCaret();
        }
        #endregion

        #region Antispam Tab
        private void tb_Timeout_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8)
            {
                e.Handled = true;
            }
        }

        private void tb_Timeout_Leave(object sender, EventArgs e)
        {
            int sec;
            if (Int32.TryParse(tb_Timeout.Text, out sec))
            {
                if (sec < 1)
                    tb_Timeout.Text = "600";
            }
            else
            {
                tb_Timeout.Text = "600";
            }
        }

        private void UpdateAntispamTabControls()
        {
            if (bot.IsModerator())
            {
                lbl_Mod.Text = "Moderator";
                lbl_Mod.ForeColor = Color.Orchid;
                btn_Block.Enabled = true;
                btn_Unblock.Enabled = true;
            }
            else
            {
                lbl_Mod.Text = "Not a moderator";
                lbl_Mod.ForeColor = Color.Plum;
                btn_Block.Enabled = false;
                btn_Unblock.Enabled = false;
            }
        }
        private void btn_Block_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tb_ForbiddenText.Text))
            {
                MessageBox.Show("Input a forbidden text");
            }
            else
            {
                if (rb_Delete.Checked)
                {
                    bot.ForbidText(tb_ForbiddenText.Text, false);
                    lbl_SelectedPunishment.Text = "Delete";
                }
                else if (rb_Timeout.Checked)
                {
                    bot.ForbidText(tb_ForbiddenText.Text, Convert.ToInt32(tb_Timeout.Text));
                    lbl_SelectedPunishment.Text = $"Timeout on {tb_Timeout.Text} sec";
                }
                else if (rb_Ban.Checked)
                {
                    bot.ForbidText(tb_ForbiddenText.Text, true);
                    lbl_SelectedPunishment.Text = "Ban";
                }
            }

        }

        private void btn_Unblock_Click(object sender, EventArgs e)
        {
            bot.CancelTextForbiddance();
            lbl_SelectedPunishment.Text = "Not forbidden";
        }

        #endregion

        #region Commands Tab
        private void btn_New_Click(object sender, EventArgs e)
        {
            SetControlsEnabledToEditCommand();
            SetDefaultTextBoxes();
            lb_CommandList.ClearSelected();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            SetControlsEnabledToDefault();
            SetDefaultTextBoxes();
            lb_CommandList.ClearSelected();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tb_Command.Text) || String.IsNullOrWhiteSpace(tb_CommandText.Text))
            {
                MessageBox.Show("Fill in all the fields");
            }
            else
            {
                SetControlsEnabledToDefault();
                if (lb_CommandList.SelectedIndex != -1)
                {
                    SaveCommandToList(lb_CommandList.SelectedIndex);
                    btn_Delete.Enabled = true;
                    btn_Edit.Enabled = true;
                }
                else
                {
                    commandList.Add(new Command());
                    SaveCommandToList(commandList.Count - 1);
                    lb_CommandList.ClearSelected();
                    lb_CommandList.SelectedIndex = lb_CommandList.Items.Count - 1;
                }
                commandList.ResetBindings();
            }
        }

        private void btn_Requestor_Click(object sender, EventArgs e)
        {
            AddRequestor();
        }

        private void btn_Random_Click(object sender, EventArgs e)
        {
            AddRandomNumber();
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (lb_CommandList.SelectedIndex != -1)
            {
                DisplaySelectedCommand(lb_CommandList.SelectedIndex);
                SetControlsEnabledToEditCommand();
            }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (lb_CommandList.SelectedIndex != -1)
            {
                commandList.RemoveAt(lb_CommandList.SelectedIndex);
                SetControlsEnabledToDefault();
                SetDefaultTextBoxes();
                lb_CommandList.ClearSelected();
            }
        }

        private void SaveCommandToList(int index)
        {
            commandList[index].KeyWord = tb_Command.Text.StartsWith("!") ? tb_Command.Text : tb_Command.Text.Insert(0, "!");
            commandList[index].Text = tb_CommandText.Text;
            if (tb_CommandText.Text.Contains("{requestor}"))
                commandList[index].Requestor = true;
            if (tb_CommandText.Text.Contains("{randomizer}"))
            {
                commandList[index].RandomNumber = true;
                int min = Convert.ToInt32(tb_MinNumber.Text);
                int max = Convert.ToInt32(tb_MaxNumber.Text);
                if (min <= max)
                {
                    commandList[index].MinNumber = min;
                    commandList[index].MaxNumber = max;
                }
                else
                {
                    commandList[index].MinNumber = max;
                    commandList[index].MaxNumber = min;
                }

            }           
        }

        private void SetControlsEnabledToEditCommand()
        {
            tb_Command.Enabled = true;
            btn_Requestor.Enabled = true;
            btn_Random.Enabled = true;
            tb_MinNumber.Enabled = true;
            tb_MaxNumber.Enabled = true;
            tb_CommandText.Enabled = true;
            btn_Save.Enabled = true;
            btn_Cancel.Enabled = true;
            btn_New.Enabled = false;
            lb_CommandList.Enabled = false;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
        }

        private void SetControlsEnabledToDefault()
        {
            tb_Command.Enabled = false;
            btn_Requestor.Enabled = false;
            btn_Random.Enabled = false;
            tb_MinNumber.Enabled = false;
            tb_MaxNumber.Enabled = false;
            tb_CommandText.Enabled = false;
            btn_Save.Enabled = false;
            btn_Cancel.Enabled = false;
            btn_New.Enabled = true;
            lb_CommandList.Enabled = true;
            btn_Delete.Enabled = false;
            btn_Edit.Enabled = false;
        }

        private void SetDefaultTextBoxes()
        {
            tb_Command.Clear();
            tb_CommandText.Clear();
            tb_MinNumber.Text = "1";
            tb_MaxNumber.Text = "12";
        }

        private void AddRequestor()
        {
            tb_CommandText.Text += "{requestor}";
        }

        private void AddRandomNumber()
        {
            tb_CommandText.Text += "{randomizer}";
        }

        private void lb_CommandList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lb_CommandList.SelectedIndex != -1)
            {
                btn_Delete.Enabled = true;
                btn_Edit.Enabled = true;
                DisplaySelectedCommand(lb_CommandList.SelectedIndex);
            }
        }

        private void DisplaySelectedCommand(int index)
        {
            tb_Command.Text = commandList[index].KeyWord;
            tb_CommandText.Text = commandList[index].Text;
            if (commandList[index].RandomNumber)
            {
                tb_MinNumber.Text = commandList[index].MinNumber.ToString();
                tb_MaxNumber.Text = commandList[index].MaxNumber.ToString();
            }
            else
            {
                tb_MinNumber.Text = "";
                tb_MaxNumber.Text = "";
            }
        }

        private void tb_MinNumber_Leave(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(tb_MinNumber.Text, out number))
            {
                if (number < 0)
                    tb_MinNumber.Text = "1";
                else if (number > 999)
                    tb_MinNumber.Text = "999";
            }
            else
            {
                tb_MinNumber.Text = "1";
            }
        }

        private void tb_MinNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8)
            {
                e.Handled = true;
            }
        }

        private void tb_MaxNumber_Leave(object sender, EventArgs e)
        {
            int number;
            if (Int32.TryParse(tb_MaxNumber.Text, out number))
            {
                if (number < 0)
                    tb_MaxNumber.Text = "1";
                else if (number > 999)
                    tb_MaxNumber.Text = "999";
            }
            else
            {
                tb_MaxNumber.Text = "1";
            }
        }

        private void tb_MaxNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            char key = e.KeyChar;
            if (!Char.IsDigit(key) && key != 8)
            {
                e.Handled = true;
            }
        }
        #endregion
    }
}
