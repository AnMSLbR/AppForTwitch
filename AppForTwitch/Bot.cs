using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Models;
using System.Threading;

namespace AppForTwitch
{
    class Bot
    {
        private string token = null;
        private string botChannel = null;
        private string streamChannel = null;

        private TwitchClient client = null;

        private string mentionText = null;
        public string MentionText
        {
            get { return mentionText; }
        }

        private string mentioner = null;
        public string Mentioner
        {
            get { return mentioner; }
        }

        public event EventHandler OnChatMentionReceived;
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
                client.OnMessageReceived += Client_OnMessageReceived;
                client.OnJoinedChannel += Client_OnJoinedChannel;
                client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Client_OnMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            if(e.ChatMessage.Message.ToLower().Contains(botChannel) || e.ChatMessage.Message.ToLower().Contains("@" + botChannel))
            {
                mentionText = null;
                mentionText = e.ChatMessage.Message;
                mentioner = null;
                mentioner = e.ChatMessage.DisplayName;
                OnChatMentionReceived.Invoke(this, new EventArgs());
                Thread.Sleep(100);
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
            //mentionText = null;
            //mentionText = e.Command.ChatMessage.Message;
            //mentioner = null;
            //mentioner = e.Command.ChatMessage.DisplayName;
            //OnChatMentionReceived.Invoke(this, new EventArgs());
            //Thread.Sleep(100);
            switch (e.Command.CommandText.ToLower())
            {
                case "roll":
                    Random rnd = new Random();
                    var result = rnd.Next(1, 12);
                    var answer = $"@{e.Command.ChatMessage.DisplayName} выбросил {result}";
                    client.SendMessage(e.Command.ChatMessage.Channel, answer);
                        break;
            }
        }

        public void Send(string message)
        {
                client.SendMessage(client.GetJoinedChannel(streamChannel), message);
        }

        private void Client_OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            client.SendMessage(e.Channel, "VoHiYo");
        }

    }
}
