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

        private TwitchClient client = null;
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

        public void Stop()
        {
            if (client != null)
            {
                client.Disconnect();
                client = null;
            }
        }

        public bool IsConnected()
        {
            return client.IsConnected;
        }

        private void Client_OnChatCommandReceived(object sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
        {
            switch (e.Command.CommandText.ToLower())
            {
                case "число":
                    Random rnd = new Random();
                    var result = rnd.Next(1, 10);
                    var answer = $"@{e.Command.ChatMessage.Username}, число {result}";
                    client.SendMessage(e.Command.ChatMessage.Channel, answer);
                        break;
            }
        }

        public void Send()
        {
            var message = new List<string>() { "1", "2", "3" };
            foreach(string mes in message)
            {
                client.SendMessage(client.GetJoinedChannel(streamChannel), mes);

            }
        }

        private void Client_OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            client.SendMessage(e.Channel, "VoHiYo");
        }

    }
}
