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

        public string BotChannel { get => botChannel; }

        private TwitchClient client = null;

        private string sendedMessage = null;
        public string SendedMessage 
        {
            get { return sendedMessage; }
        }
        private string messageSender = null;
        public string MessageSender { get => messageSender; }

        public event EventHandler OnChatMentionMessageReceived;
        public event EventHandler OnChatBotMessageSended;
        public event EventHandler OnChatBotMessageReceived;
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
                client.OnMessageSent += Client_OnBotMessageSent;
                client.OnMessageReceived += Client_OnBotMessageReceived;
                client.OnMessageReceived += Client_OnMentionMessageReceived;
                client.OnJoinedChannel += Client_OnJoinedChannel;
                client.Connect();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Client_OnBotMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            if(e.ChatMessage.DisplayName.ToLower() == botChannel)
            {
                sendedMessage = e.ChatMessage.Message;
                messageSender = e.ChatMessage.DisplayName;
                OnChatBotMessageReceived(this, new EventArgs());
                Thread.Sleep(100);
            }
        }

        private void Client_OnBotMessageSent(object sender, TwitchLib.Client.Events.OnMessageSentArgs e)
        {
            if (e.SentMessage.DisplayName.ToLower() == botChannel)
            {
                sendedMessage = e.SentMessage.Message;
                messageSender = e.SentMessage.DisplayName;
                OnChatBotMessageSended.Invoke(this, new EventArgs());
                Thread.Sleep(100);
            }
        }

        private void Client_OnMentionMessageReceived(object sender, TwitchLib.Client.Events.OnMessageReceivedArgs e)
        {
            if (e.ChatMessage.Message.ToLower().Contains(botChannel) || e.ChatMessage.Message.ToLower().Contains("@" + botChannel))
            {
                sendedMessage = e.ChatMessage.Message;
                messageSender = e.ChatMessage.DisplayName;
                OnChatMentionMessageReceived.Invoke(this, new EventArgs());
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
