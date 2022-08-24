using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwitchLib.Api;
using TwitchLib.PubSub;
using TwitchLib.PubSub.Events;
using TwitchLib.Communication;
using TwitchLib.Communication.Clients;
using TwitchLib.Communication.Models;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Enums;
using TwitchLib.Client.Extensions;
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
        private bool isModerator = false;

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
        public event EventHandler OnRoleChecked;
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
                client.OnJoinedChannel += Client_OnJoinedChannel;
                client.OnChatCommandReceived += Client_OnChatCommandReceived;
                client.OnMessageSent += Client_OnBotMessageSent;
                client.OnMessageReceived += Client_OnBotMessageReceived;
                client.OnMessageReceived += Client_OnMentionMessageReceived;

                client.OnModeratorsReceived += Client_OnModeratorsReceived;

                client.OnMessageReceived += Client_OnSpamReceived;

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
                try
                {
                    client.Disconnect();
                    client = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
            }
        }

        private void Client_OnSpamReceived(object sender, OnMessageReceivedArgs e)
        {
            string str = "";
            if(!e.ChatMessage.IsBroadcaster && !e.ChatMessage.IsModerator)
            {
                if (e.ChatMessage.Message.Contains(str))
                {
                    client.BanUser(e.ChatMessage.Channel, e.ChatMessage.Username);
                }
            }
        }

        private void Client_OnModeratorsReceived(object sender, OnModeratorsReceivedArgs e)
        {
            if (e.Moderators.Contains(botChannel))
                isModerator = true;
            else
                isModerator = false;
            OnRoleChecked.Invoke(this, new EventArgs());
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

        public bool IsConnected()
        {
            return client.IsConnected;
        }

        public bool IsModerator()
        {
            if (botChannel == streamChannel)
                return true;
            else
                return isModerator;
        }

        private void Client_OnChatCommandReceived(object sender, TwitchLib.Client.Events.OnChatCommandReceivedArgs e)
        {
            //mentionText = null;
            //mentionText = e.Command.ChatMessage.Message;
            //mentioner = null;
            //mentioner = e.Command.ChatMessage.DisplayName;
            //OnChatMentionReceived.Invoke(this, new EventArgs());
            //Thread.Sleep(100);
            string answer;
            switch (e.Command.CommandText.ToLower())
            {
                case "roll":
                    Random rnd = new Random();
                    var result = rnd.Next(1, 12);
                    answer = $"@{e.Command.ChatMessage.DisplayName} выбросил {result}";
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
            client.GetChannelModerators(streamChannel);
            //client.SendMessage(e.Channel, "VoHiYo");
        }

    }
}
