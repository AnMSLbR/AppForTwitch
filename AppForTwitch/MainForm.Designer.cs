
namespace AppForTwitch
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tb_Token = new System.Windows.Forms.TextBox();
            this.lbl_BotChannelName = new System.Windows.Forms.Label();
            this.tb_BotChannelName = new System.Windows.Forms.TextBox();
            this.lbl_StreamChannelName = new System.Windows.Forms.Label();
            this.tb_StreamChannelName = new System.Windows.Forms.TextBox();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.lLbl_Token = new System.Windows.Forms.LinkLabel();
            this.cb_Remember = new System.Windows.Forms.CheckBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_StatusHeader = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_InsertToken = new System.Windows.Forms.Button();
            this.btn_InsertBotName = new System.Windows.Forms.Button();
            this.btn_InsertStreamerName = new System.Windows.Forms.Button();
            this.tabCommands = new System.Windows.Forms.TabPage();
            this.tabChat = new System.Windows.Forms.TabPage();
            this.lbl_Repeats = new System.Windows.Forms.Label();
            this.roundedTB_Repeats = new AppForTwitch.User_Controls.Rounded_Textbox();
            this.lbl_Sound = new System.Windows.Forms.Label();
            this.toggleB_Sound = new AppForTwitch.Toggle_Button();
            this.tb_MyChat = new System.Windows.Forms.TextBox();
            this.tb_Message = new System.Windows.Forms.TextBox();
            this.btn_Send = new System.Windows.Forms.Button();
            this.tabAntispam = new System.Windows.Forms.TabPage();
            this.lbl_ForbiddenText = new System.Windows.Forms.Label();
            this.tb_ForbiddenText = new System.Windows.Forms.TextBox();
            this.gb_Punishment = new System.Windows.Forms.GroupBox();
            this.btn_Block = new System.Windows.Forms.Button();
            this.rb_Delete = new System.Windows.Forms.RadioButton();
            this.rb_Timeout = new System.Windows.Forms.RadioButton();
            this.rb_Ban = new System.Windows.Forms.RadioButton();
            this.lbl_Role = new System.Windows.Forms.Label();
            this.lbl_Mod = new System.Windows.Forms.Label();
            this.btn_Unblock = new System.Windows.Forms.Button();
            this.lbl_Sec = new System.Windows.Forms.Label();
            this.tb_Timeout = new System.Windows.Forms.TextBox();
            this.tc_Main.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabChat.SuspendLayout();
            this.tabAntispam.SuspendLayout();
            this.gb_Punishment.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_Token
            // 
            this.tb_Token.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_Token.Location = new System.Drawing.Point(177, 9);
            this.tb_Token.Name = "tb_Token";
            this.tb_Token.Size = new System.Drawing.Size(362, 27);
            this.tb_Token.TabIndex = 1;
            this.tb_Token.TabStop = false;
            // 
            // lbl_BotChannelName
            // 
            this.lbl_BotChannelName.AutoSize = true;
            this.lbl_BotChannelName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_BotChannelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_BotChannelName.Location = new System.Drawing.Point(12, 47);
            this.lbl_BotChannelName.Name = "lbl_BotChannelName";
            this.lbl_BotChannelName.Size = new System.Drawing.Size(142, 20);
            this.lbl_BotChannelName.TabIndex = 2;
            this.lbl_BotChannelName.Text = "Bot Channel Name:";
            // 
            // tb_BotChannelName
            // 
            this.tb_BotChannelName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_BotChannelName.Location = new System.Drawing.Point(177, 44);
            this.tb_BotChannelName.Name = "tb_BotChannelName";
            this.tb_BotChannelName.Size = new System.Drawing.Size(362, 27);
            this.tb_BotChannelName.TabIndex = 3;
            this.tb_BotChannelName.TabStop = false;
            // 
            // lbl_StreamChannelName
            // 
            this.lbl_StreamChannelName.AutoSize = true;
            this.lbl_StreamChannelName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_StreamChannelName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_StreamChannelName.Location = new System.Drawing.Point(12, 82);
            this.lbl_StreamChannelName.Name = "lbl_StreamChannelName";
            this.lbl_StreamChannelName.Size = new System.Drawing.Size(166, 20);
            this.lbl_StreamChannelName.TabIndex = 4;
            this.lbl_StreamChannelName.Text = "Stream Channel Name:";
            // 
            // tb_StreamChannelName
            // 
            this.tb_StreamChannelName.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb_StreamChannelName.Location = new System.Drawing.Point(177, 79);
            this.tb_StreamChannelName.Name = "tb_StreamChannelName";
            this.tb_StreamChannelName.Size = new System.Drawing.Size(362, 27);
            this.tb_StreamChannelName.TabIndex = 5;
            this.tb_StreamChannelName.TabStop = false;
            // 
            // tc_Main
            // 
            this.tc_Main.Controls.Add(this.tabSettings);
            this.tc_Main.Controls.Add(this.tabCommands);
            this.tc_Main.Controls.Add(this.tabChat);
            this.tc_Main.Controls.Add(this.tabAntispam);
            this.tc_Main.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tc_Main.Location = new System.Drawing.Point(-4, -3);
            this.tc_Main.Name = "tc_Main";
            this.tc_Main.SelectedIndex = 0;
            this.tc_Main.Size = new System.Drawing.Size(592, 368);
            this.tc_Main.TabIndex = 6;
            this.tc_Main.TabStop = false;
            // 
            // tabSettings
            // 
            this.tabSettings.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabSettings.Controls.Add(this.lLbl_Token);
            this.tabSettings.Controls.Add(this.cb_Remember);
            this.tabSettings.Controls.Add(this.lbl_Status);
            this.tabSettings.Controls.Add(this.lbl_StatusHeader);
            this.tabSettings.Controls.Add(this.btn_Start);
            this.tabSettings.Controls.Add(this.btn_InsertToken);
            this.tabSettings.Controls.Add(this.btn_InsertBotName);
            this.tabSettings.Controls.Add(this.btn_InsertStreamerName);
            this.tabSettings.Controls.Add(this.tb_Token);
            this.tabSettings.Controls.Add(this.tb_StreamChannelName);
            this.tabSettings.Controls.Add(this.lbl_StreamChannelName);
            this.tabSettings.Controls.Add(this.lbl_BotChannelName);
            this.tabSettings.Controls.Add(this.tb_BotChannelName);
            this.tabSettings.ImageIndex = 0;
            this.tabSettings.Location = new System.Drawing.Point(4, 29);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabSettings.Size = new System.Drawing.Size(584, 335);
            this.tabSettings.TabIndex = 0;
            this.tabSettings.Text = "Settings";
            // 
            // lLbl_Token
            // 
            this.lLbl_Token.AutoSize = true;
            this.lLbl_Token.LinkColor = System.Drawing.Color.Violet;
            this.lLbl_Token.Location = new System.Drawing.Point(12, 12);
            this.lLbl_Token.Name = "lLbl_Token";
            this.lLbl_Token.Size = new System.Drawing.Size(104, 20);
            this.lLbl_Token.TabIndex = 13;
            this.lLbl_Token.TabStop = true;
            this.lLbl_Token.Text = "OAuth Token:";
            this.lLbl_Token.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLbl_Token_LinkClicked);
            // 
            // cb_Remember
            // 
            this.cb_Remember.AutoSize = true;
            this.cb_Remember.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cb_Remember.Location = new System.Drawing.Point(177, 121);
            this.cb_Remember.Name = "cb_Remember";
            this.cb_Remember.Size = new System.Drawing.Size(101, 24);
            this.cb_Remember.TabIndex = 12;
            this.cb_Remember.Text = "Remember";
            this.cb_Remember.UseVisualStyleBackColor = true;
            // 
            // lbl_Status
            // 
            this.lbl_Status.AutoSize = true;
            this.lbl_Status.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Status.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Status.Location = new System.Drawing.Point(63, 306);
            this.lbl_Status.Name = "lbl_Status";
            this.lbl_Status.Size = new System.Drawing.Size(73, 20);
            this.lbl_Status.TabIndex = 11;
            this.lbl_Status.Text = "unknown";
            // 
            // lbl_StatusHeader
            // 
            this.lbl_StatusHeader.AutoSize = true;
            this.lbl_StatusHeader.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_StatusHeader.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_StatusHeader.Location = new System.Drawing.Point(12, 306);
            this.lbl_StatusHeader.Name = "lbl_StatusHeader";
            this.lbl_StatusHeader.Size = new System.Drawing.Size(53, 20);
            this.lbl_StatusHeader.TabIndex = 10;
            this.lbl_StatusHeader.Text = "Status:";
            // 
            // btn_Start
            // 
            this.btn_Start.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Start.Location = new System.Drawing.Point(358, 114);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(181, 37);
            this.btn_Start.TabIndex = 9;
            this.btn_Start.TabStop = false;
            this.btn_Start.Text = "Start";
            this.btn_Start.UseVisualStyleBackColor = false;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // btn_InsertToken
            // 
            this.btn_InsertToken.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_InsertToken.BackgroundImage = global::AppForTwitch.Properties.Resources.kk;
            this.btn_InsertToken.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InsertToken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertToken.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_InsertToken.Location = new System.Drawing.Point(546, 9);
            this.btn_InsertToken.Name = "btn_InsertToken";
            this.btn_InsertToken.Size = new System.Drawing.Size(27, 27);
            this.btn_InsertToken.TabIndex = 8;
            this.btn_InsertToken.TabStop = false;
            this.btn_InsertToken.UseVisualStyleBackColor = false;
            this.btn_InsertToken.Click += new System.EventHandler(this.btn_InsertToken_Click);
            // 
            // btn_InsertBotName
            // 
            this.btn_InsertBotName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_InsertBotName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InsertBotName.BackgroundImage")));
            this.btn_InsertBotName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InsertBotName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertBotName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_InsertBotName.Location = new System.Drawing.Point(546, 44);
            this.btn_InsertBotName.Name = "btn_InsertBotName";
            this.btn_InsertBotName.Size = new System.Drawing.Size(27, 27);
            this.btn_InsertBotName.TabIndex = 7;
            this.btn_InsertBotName.TabStop = false;
            this.btn_InsertBotName.UseVisualStyleBackColor = false;
            this.btn_InsertBotName.Click += new System.EventHandler(this.btn_InsertBotName_Click);
            // 
            // btn_InsertStreamerName
            // 
            this.btn_InsertStreamerName.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_InsertStreamerName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InsertStreamerName.BackgroundImage")));
            this.btn_InsertStreamerName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_InsertStreamerName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InsertStreamerName.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.btn_InsertStreamerName.Location = new System.Drawing.Point(546, 79);
            this.btn_InsertStreamerName.Name = "btn_InsertStreamerName";
            this.btn_InsertStreamerName.Size = new System.Drawing.Size(27, 27);
            this.btn_InsertStreamerName.TabIndex = 6;
            this.btn_InsertStreamerName.TabStop = false;
            this.btn_InsertStreamerName.UseVisualStyleBackColor = false;
            this.btn_InsertStreamerName.Click += new System.EventHandler(this.btn_InsertStreamerName_Click);
            // 
            // tabCommands
            // 
            this.tabCommands.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabCommands.Location = new System.Drawing.Point(4, 29);
            this.tabCommands.Name = "tabCommands";
            this.tabCommands.Padding = new System.Windows.Forms.Padding(3);
            this.tabCommands.Size = new System.Drawing.Size(584, 335);
            this.tabCommands.TabIndex = 1;
            this.tabCommands.Text = "Commands";
            // 
            // tabChat
            // 
            this.tabChat.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabChat.Controls.Add(this.lbl_Repeats);
            this.tabChat.Controls.Add(this.roundedTB_Repeats);
            this.tabChat.Controls.Add(this.lbl_Sound);
            this.tabChat.Controls.Add(this.toggleB_Sound);
            this.tabChat.Controls.Add(this.tb_MyChat);
            this.tabChat.Controls.Add(this.tb_Message);
            this.tabChat.Controls.Add(this.btn_Send);
            this.tabChat.Location = new System.Drawing.Point(4, 29);
            this.tabChat.Name = "tabChat";
            this.tabChat.Size = new System.Drawing.Size(584, 335);
            this.tabChat.TabIndex = 2;
            this.tabChat.Text = "Chat";
            // 
            // lbl_Repeats
            // 
            this.lbl_Repeats.AutoSize = true;
            this.lbl_Repeats.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Repeats.Location = new System.Drawing.Point(339, 294);
            this.lbl_Repeats.Name = "lbl_Repeats";
            this.lbl_Repeats.Size = new System.Drawing.Size(62, 20);
            this.lbl_Repeats.TabIndex = 6;
            this.lbl_Repeats.Text = "Repeats";
            // 
            // roundedTB_Repeats
            // 
            this.roundedTB_Repeats.BackColor = System.Drawing.SystemColors.Window;
            this.roundedTB_Repeats.BorderColor = System.Drawing.SystemColors.ScrollBar;
            this.roundedTB_Repeats.BorderFocusColor = System.Drawing.Color.MediumOrchid;
            this.roundedTB_Repeats.BorderRadius = 15;
            this.roundedTB_Repeats.BorderSize = 2;
            this.roundedTB_Repeats.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.roundedTB_Repeats.ForeColor = System.Drawing.SystemColors.WindowText;
            this.roundedTB_Repeats.Location = new System.Drawing.Point(277, 289);
            this.roundedTB_Repeats.Margin = new System.Windows.Forms.Padding(4);
            this.roundedTB_Repeats.MaxTextLength = 3;
            this.roundedTB_Repeats.Multiline = false;
            this.roundedTB_Repeats.Name = "roundedTB_Repeats";
            this.roundedTB_Repeats.Padding = new System.Windows.Forms.Padding(14, 5, 14, 5);
            this.roundedTB_Repeats.Size = new System.Drawing.Size(61, 31);
            this.roundedTB_Repeats.TabIndex = 5;
            this.roundedTB_Repeats.Texts = "1";
            this.roundedTB_Repeats.TextsAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.roundedTB_Repeats.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.roundedTB_Repeats_KeyPress);
            this.roundedTB_Repeats.Leave += new System.EventHandler(this.roundedTB_Repeats_Leave);
            // 
            // lbl_Sound
            // 
            this.lbl_Sound.AutoSize = true;
            this.lbl_Sound.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Sound.Location = new System.Drawing.Point(63, 294);
            this.lbl_Sound.Name = "lbl_Sound";
            this.lbl_Sound.Size = new System.Drawing.Size(53, 20);
            this.lbl_Sound.TabIndex = 4;
            this.lbl_Sound.Text = "Sound";
            // 
            // toggleB_Sound
            // 
            this.toggleB_Sound.AutoSize = true;
            this.toggleB_Sound.Location = new System.Drawing.Point(12, 294);
            this.toggleB_Sound.MinimumSize = new System.Drawing.Size(45, 22);
            this.toggleB_Sound.Name = "toggleB_Sound";
            this.toggleB_Sound.OffBackBorderColor = System.Drawing.SystemColors.Window;
            this.toggleB_Sound.OffToggleColor = System.Drawing.SystemColors.WindowFrame;
            this.toggleB_Sound.OnBackBorderColor = System.Drawing.Color.MediumOrchid;
            this.toggleB_Sound.OnToggleColor = System.Drawing.Color.DarkViolet;
            this.toggleB_Sound.Size = new System.Drawing.Size(45, 22);
            this.toggleB_Sound.TabIndex = 3;
            this.toggleB_Sound.UseVisualStyleBackColor = true;
            // 
            // tb_MyChat
            // 
            this.tb_MyChat.BackColor = System.Drawing.SystemColors.Window;
            this.tb_MyChat.Location = new System.Drawing.Point(12, 11);
            this.tb_MyChat.Multiline = true;
            this.tb_MyChat.Name = "tb_MyChat";
            this.tb_MyChat.ReadOnly = true;
            this.tb_MyChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_MyChat.Size = new System.Drawing.Size(560, 202);
            this.tb_MyChat.TabIndex = 2;
            this.tb_MyChat.TextChanged += new System.EventHandler(this.tb_MyChat_TextChanged);
            // 
            // tb_Message
            // 
            this.tb_Message.Location = new System.Drawing.Point(12, 223);
            this.tb_Message.Multiline = true;
            this.tb_Message.Name = "tb_Message";
            this.tb_Message.PlaceholderText = "Send a message";
            this.tb_Message.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_Message.Size = new System.Drawing.Size(560, 54);
            this.tb_Message.TabIndex = 1;
            this.tb_Message.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tb_Message_KeyDown);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Send.Location = new System.Drawing.Point(421, 286);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(151, 37);
            this.btn_Send.TabIndex = 0;
            this.btn_Send.TabStop = false;
            this.btn_Send.Text = "Send";
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.btn_Send_Click);
            // 
            // tabAntispam
            // 
            this.tabAntispam.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabAntispam.Controls.Add(this.btn_Unblock);
            this.tabAntispam.Controls.Add(this.lbl_Mod);
            this.tabAntispam.Controls.Add(this.lbl_Role);
            this.tabAntispam.Controls.Add(this.btn_Block);
            this.tabAntispam.Controls.Add(this.gb_Punishment);
            this.tabAntispam.Controls.Add(this.tb_ForbiddenText);
            this.tabAntispam.Controls.Add(this.lbl_ForbiddenText);
            this.tabAntispam.Location = new System.Drawing.Point(4, 29);
            this.tabAntispam.Name = "tabAntispam";
            this.tabAntispam.Size = new System.Drawing.Size(584, 335);
            this.tabAntispam.TabIndex = 3;
            this.tabAntispam.Text = "Antispam";
            // 
            // lbl_ForbiddenText
            // 
            this.lbl_ForbiddenText.AutoSize = true;
            this.lbl_ForbiddenText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_ForbiddenText.Location = new System.Drawing.Point(12, 6);
            this.lbl_ForbiddenText.Name = "lbl_ForbiddenText";
            this.lbl_ForbiddenText.Size = new System.Drawing.Size(108, 20);
            this.lbl_ForbiddenText.TabIndex = 0;
            this.lbl_ForbiddenText.Text = "Forbidden text";
            // 
            // tb_ForbiddenText
            // 
            this.tb_ForbiddenText.Location = new System.Drawing.Point(12, 29);
            this.tb_ForbiddenText.Multiline = true;
            this.tb_ForbiddenText.Name = "tb_ForbiddenText";
            this.tb_ForbiddenText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_ForbiddenText.Size = new System.Drawing.Size(560, 152);
            this.tb_ForbiddenText.TabIndex = 1;
            // 
            // gb_Punishment
            // 
            this.gb_Punishment.Controls.Add(this.tb_Timeout);
            this.gb_Punishment.Controls.Add(this.lbl_Sec);
            this.gb_Punishment.Controls.Add(this.rb_Ban);
            this.gb_Punishment.Controls.Add(this.rb_Timeout);
            this.gb_Punishment.Controls.Add(this.rb_Delete);
            this.gb_Punishment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gb_Punishment.Location = new System.Drawing.Point(12, 187);
            this.gb_Punishment.Name = "gb_Punishment";
            this.gb_Punishment.Size = new System.Drawing.Size(275, 120);
            this.gb_Punishment.TabIndex = 2;
            this.gb_Punishment.TabStop = false;
            this.gb_Punishment.Text = "Punishment";
            // 
            // btn_Block
            // 
            this.btn_Block.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Block.Location = new System.Drawing.Point(297, 196);
            this.btn_Block.Name = "btn_Block";
            this.btn_Block.Size = new System.Drawing.Size(275, 50);
            this.btn_Block.TabIndex = 3;
            this.btn_Block.TabStop = false;
            this.btn_Block.Text = "Block";
            this.btn_Block.UseVisualStyleBackColor = false;
            this.btn_Block.Click += new System.EventHandler(this.btn_Block_Click);
            // 
            // rb_Delete
            // 
            this.rb_Delete.AutoSize = true;
            this.rb_Delete.Location = new System.Drawing.Point(6, 25);
            this.rb_Delete.Name = "rb_Delete";
            this.rb_Delete.Size = new System.Drawing.Size(134, 24);
            this.rb_Delete.TabIndex = 4;
            this.rb_Delete.TabStop = true;
            this.rb_Delete.Text = "Delete message";
            this.rb_Delete.UseVisualStyleBackColor = true;
            // 
            // rb_Timeout
            // 
            this.rb_Timeout.AutoSize = true;
            this.rb_Timeout.Location = new System.Drawing.Point(6, 55);
            this.rb_Timeout.Name = "rb_Timeout";
            this.rb_Timeout.Size = new System.Drawing.Size(116, 24);
            this.rb_Timeout.TabIndex = 5;
            this.rb_Timeout.TabStop = true;
            this.rb_Timeout.Text = "Timeout user";
            this.rb_Timeout.UseVisualStyleBackColor = true;
            // 
            // rb_Ban
            // 
            this.rb_Ban.AutoSize = true;
            this.rb_Ban.Location = new System.Drawing.Point(6, 85);
            this.rb_Ban.Name = "rb_Ban";
            this.rb_Ban.Size = new System.Drawing.Size(86, 24);
            this.rb_Ban.TabIndex = 6;
            this.rb_Ban.TabStop = true;
            this.rb_Ban.Text = "Ban user";
            this.rb_Ban.UseVisualStyleBackColor = true;
            // 
            // lbl_Role
            // 
            this.lbl_Role.AutoSize = true;
            this.lbl_Role.ForeColor = System.Drawing.Color.Plum;
            this.lbl_Role.Location = new System.Drawing.Point(406, 6);
            this.lbl_Role.Name = "lbl_Role";
            this.lbl_Role.Size = new System.Drawing.Size(42, 20);
            this.lbl_Role.TabIndex = 4;
            this.lbl_Role.Text = "Role:";
            // 
            // lbl_Mod
            // 
            this.lbl_Mod.AutoSize = true;
            this.lbl_Mod.ForeColor = System.Drawing.Color.Plum;
            this.lbl_Mod.Location = new System.Drawing.Point(449, 6);
            this.lbl_Mod.Name = "lbl_Mod";
            this.lbl_Mod.Size = new System.Drawing.Size(123, 20);
            this.lbl_Mod.TabIndex = 6;
            this.lbl_Mod.Text = "Not a moderator";
            // 
            // btn_Unblock
            // 
            this.btn_Unblock.BackColor = System.Drawing.SystemColors.Window;
            this.btn_Unblock.Location = new System.Drawing.Point(297, 257);
            this.btn_Unblock.Name = "btn_Unblock";
            this.btn_Unblock.Size = new System.Drawing.Size(275, 50);
            this.btn_Unblock.TabIndex = 7;
            this.btn_Unblock.TabStop = false;
            this.btn_Unblock.Text = "Unblock";
            this.btn_Unblock.UseVisualStyleBackColor = false;
            // 
            // lbl_Sec
            // 
            this.lbl_Sec.AutoSize = true;
            this.lbl_Sec.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Sec.Location = new System.Drawing.Point(237, 57);
            this.lbl_Sec.Name = "lbl_Sec";
            this.lbl_Sec.Size = new System.Drawing.Size(30, 20);
            this.lbl_Sec.TabIndex = 8;
            this.lbl_Sec.Text = "sec";
            // 
            // tb_Timeout
            // 
            this.tb_Timeout.Location = new System.Drawing.Point(131, 54);
            this.tb_Timeout.Name = "tb_Timeout";
            this.tb_Timeout.Size = new System.Drawing.Size(100, 27);
            this.tb_Timeout.TabIndex = 8;
            this.tb_Timeout.Text = "600";
            this.tb_Timeout.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Timeout_KeyPress);
            this.tb_Timeout.Leave += new System.EventHandler(this.tb_Timeout_Leave);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tc_Main);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "TwitchBot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tc_Main.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabChat.ResumeLayout(false);
            this.tabChat.PerformLayout();
            this.tabAntispam.ResumeLayout(false);
            this.tabAntispam.PerformLayout();
            this.gb_Punishment.ResumeLayout(false);
            this.gb_Punishment.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tb_Token;
        private System.Windows.Forms.Label lbl_BotChannelName;
        private System.Windows.Forms.TextBox tb_BotChannelName;
        private System.Windows.Forms.Label lbl_StreamChannelName;
        private System.Windows.Forms.TextBox tb_StreamChannelName;
        private System.Windows.Forms.TabControl tc_Main;
        private System.Windows.Forms.TabPage tabSettings;
        private System.Windows.Forms.TabPage tabCommands;
        private System.Windows.Forms.Button btn_InsertStreamerName;
        private System.Windows.Forms.Button btn_InsertToken;
        private System.Windows.Forms.Button btn_InsertBotName;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.Label lbl_Status;
        private System.Windows.Forms.Label lbl_StatusHeader;
        private System.Windows.Forms.CheckBox cb_Remember;
        private System.Windows.Forms.TabPage tabChat;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.TextBox tb_Message;
        private System.Windows.Forms.TextBox tb_MyChat;
        private Toggle_Button toggleB_Sound;
        private System.Windows.Forms.Label lbl_Sound;
        private System.Windows.Forms.LinkLabel lLbl_Token;
        private User_Controls.Rounded_Textbox roundedTB_Repeats;
        private System.Windows.Forms.Label lbl_Repeats;
        private System.Windows.Forms.TabPage tabAntispam;
        private System.Windows.Forms.Button btn_Unblock;
        private System.Windows.Forms.Label lbl_Mod;
        private System.Windows.Forms.Label lbl_Role;
        private System.Windows.Forms.Button btn_Block;
        private System.Windows.Forms.GroupBox gb_Punishment;
        private System.Windows.Forms.TextBox tb_Timeout;
        private System.Windows.Forms.Label lbl_Sec;
        private System.Windows.Forms.RadioButton rb_Ban;
        private System.Windows.Forms.RadioButton rb_Timeout;
        private System.Windows.Forms.RadioButton rb_Delete;
        private System.Windows.Forms.TextBox tb_ForbiddenText;
        private System.Windows.Forms.Label lbl_ForbiddenText;
    }
}

