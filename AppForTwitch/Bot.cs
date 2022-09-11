using System;
using System.Linq;
using System.Windows.Forms;
using TwitchLib.Client;
using TwitchLib.Client.Events;
using TwitchLib.Client.Extensions;
using TwitchLib.Client.Models;
using System.Threading;
using System.ComponentModel;

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
        private string forbiddenText = null;
        private int timeoutDuration = 0;
        private bool isBan = false;

        private string sendedMessage = null;
        public string SendedMessage  { get => sendedMessage; }

        private string messageSender = null;
        public string MessageSender { get => messageSender; }

        private BindingList<Command> commandList;
        public BindingList<Command> CommandList { set => commandList = value; }

        public event EventHandler OnChatMentionMessageReceived;
        public event EventHandler OnChatBotMessageSended;
        public event EventHandler OnChatBotMessageReceived;
        public event EventHandler OnRoleChecked;
        public Bot(string token, string bot, string streamer)
        {
            this.token = token.ToLower();
            this.botChannel = bot.ToLower();
            this.streamChannel = streamer.ToLower();
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
            if (!String.IsNullOrEmpty(forbiddenText) && e.ChatMessage.Message.ToLower().Contains(forbiddenText.ToLower())) 
            {
                if (!e.ChatMessage.IsBroadcaster && !e.ChatMessage.IsModerator)
                {
                    if (isBan)
                        BanUser(e.ChatMessage.Channel, e.ChatMessage.Username);
                    else if (timeoutDuration > 0)
                        TimeoutUser(e.ChatMessage.Channel, e.ChatMessage.Username, TimeSpan.FromSeconds(timeoutDuration));
                    else
                        DeleteMessage(e.ChatMessage.Channel, e.ChatMessage.Id);
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

        public void ForbidText(string text, bool ban)
        {
            forbiddenText = text;
            isBan = ban;
            timeoutDuration = 0;
        }

        public void ForbidText(string text, int timeout)
        {
            forbiddenText = text;
            isBan = false;
            timeoutDuration = timeout;
        }
        
        public void CancelTextForbiddance()
        {
            forbiddenText = null;
            isBan = false;
            timeoutDuration = 0;
        }

        public void DeleteMessage(string channel, string messageId)
        {
            client.DeleteMessage(channel, messageId);
        }

        public void TimeoutUser(string channel, string user, TimeSpan time)
        {
            client.TimeoutUser(channel, user, time);
        }

        public void BanUser(string channel, string user)
        {
            client.BanUser(channel, user);
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
            string receivedCommand = "!" + e.Command.CommandText.ToLower();
            int index = commandList.IndexOf(commandList.SingleOrDefault(command => command.KeyWord.ToLower() == receivedCommand));
            if (index != -1)
            {
                string answer = commandList[index].Text;
                if (commandList[index].Requestor)
                    answer = answer.Replace("{requestor}", e.Command.ChatMessage.DisplayName);
                if (commandList[index].RandomNumber)
                {
                    Random rnd = new Random();
                    var result = rnd.Next(commandList[index].MinNumber, commandList[index].MaxNumber);
                    answer = answer.Replace("{randomizer}", result.ToString());
                }
                client.SendMessage(streamChannel, answer);
            }
        }

        public void Send(string message)
        {
            client.SendMessage(client.GetJoinedChannel(streamChannel), message);
        }

        private void Client_OnJoinedChannel(object sender, TwitchLib.Client.Events.OnJoinedChannelArgs e)
        {
            client.GetChannelModerators(streamChannel);
            client.SendMessage(e.Channel, "VoHiYo");
        }
    }
}
