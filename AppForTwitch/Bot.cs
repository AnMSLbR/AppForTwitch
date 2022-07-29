using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Models;

namespace AppForTwitch
{
    class Bot
    {
        private string token = null;
        private string botChannel = null;
        private string streamChannel = null;

        private TwitchClient client;
        public Bot(string token, string bot, string streamer)
        {
            this.token = token;
            this.botChannel = bot;
            this.streamChannel = streamer;
        }


        public void Start()
        {
            client = new TwitchClient();
            ConnectionCredentials credentials = new ConnectionCredentials(botChannel, token);
            try
            {
                client.Initialize(credentials, streamChannel);
                client.OnChatCommandReceived += Client_OnChatCommandReceived;
                client.OnJoinedChannel += Client_OnJoinedChannel;
                client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }

        }

        private void Client_OnChatCommandReceived(object sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
        {
            switch (e.Command.CommandText.ToLower())
            {
                case "pc":
                    var answer = $"@{e.Command.ChatMessage.Username}, TestPC";
                    client.SendMessage(e.Command.ChatMessage.Channel, answer);
                        break;
            }
        }

        private void Client_OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            client.SendMessage(e.Channel, "TestJoin");
        }

    }
}
