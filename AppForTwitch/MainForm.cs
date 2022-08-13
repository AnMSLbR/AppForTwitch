using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppForTwitch
{
    public partial class MainForm : Form
    {

        private Bot bot;
        public MainForm()
        {
            InitializeComponent();
            UpdateStatusLabel();
            UpdateInitializationData();
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
                bot = new Bot(tb_Token.Text, tb_BotChannelName.Text, tb_StreamChannelName.Text);
            else
                bot.Stop();
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

        private void button1_Click(object sender, EventArgs e)
        {
            bot.Send();
        }
    }
}
