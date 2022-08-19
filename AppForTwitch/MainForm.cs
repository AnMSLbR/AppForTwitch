using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Reflection;
using System.IO;
using System.Diagnostics;

namespace AppForTwitch
{
    public partial class MainForm : Form
    {

        private Bot bot;
        private SoundPlayer sound;
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
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSoundButtonStatus();
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
            if (tb_Token.Text.Length * tb_BotChannelName.Text.Length * tb_StreamChannelName.Text.Length != 0)
            {
                if (cb_Remember.Checked)
                    RememberInitializationData();
                else
                    ClearInitializationData();
                StartBot();
            }
            else
            {
                MessageBox.Show("Fill in all the fields");
            }
            UpdateStatusLabel();
        }

        private void StartBot()
        {
            if (bot == null)
            {
                bot = new Bot(tb_Token.Text.ToLower(), tb_BotChannelName.Text.ToLower(), tb_StreamChannelName.Text.ToLower());
                bot.OnChatBotMessageReceived += Bot_OnChatBotMessageReceived;
                bot.OnChatBotMessageSended += Bot_OnChatBotMessageSended;
                bot.OnChatMentionMessageReceived += Bot_OnChatMentionMessageReceived;
            }
            else
                bot.Stop();
            bot.Start();
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

        private void SetSoundButtonStatus()
        {
            toggleB_Sound.Checked = Properties.Settings.Default.SoundButtonStatus;
        }

        private void SaveSoundButtonStatus()
        {
            Properties.Settings.Default.SoundButtonStatus = toggleB_Sound.Checked;
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

        private void SendMessage()
        {
            if (bot != null && bot.IsConnected())
            {
                bot.Send(tb_Message.Text);
                tb_Message.Clear();
            }
        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void tb_Message_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                SendMessage();
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
    }
}
