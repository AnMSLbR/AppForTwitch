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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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
            if (tb_Token.Text.Length*tb_BotChannelName.Text.Length*tb_StreamChannelName.Text.Length != 0)
            {
                StartBot();
            }
            else
            {
                MessageBox.Show("Fill in all the fields");
            }
        }

        private void StartBot()
        {
            Bot bot = new Bot(tb_Token.Text, tb_BotChannelName.Text, tb_StreamChannelName.Text);
            bot.Start();
        }

    }
}
