
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
            this.lbl_Token = new System.Windows.Forms.Label();
            this.tb_Token = new System.Windows.Forms.TextBox();
            this.lbl_BotChannelName = new System.Windows.Forms.Label();
            this.tb_BotChannelName = new System.Windows.Forms.TextBox();
            this.lbl_StreamChannelName = new System.Windows.Forms.Label();
            this.tb_StreamChannelName = new System.Windows.Forms.TextBox();
            this.tc_Main = new System.Windows.Forms.TabControl();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.cb_Remember = new System.Windows.Forms.CheckBox();
            this.lbl_Status = new System.Windows.Forms.Label();
            this.lbl_StatusHeader = new System.Windows.Forms.Label();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_InsertToken = new System.Windows.Forms.Button();
            this.btn_InsertBotName = new System.Windows.Forms.Button();
            this.btn_InsertStreamerName = new System.Windows.Forms.Button();
            this.tabCommands = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.tc_Main.SuspendLayout();
            this.tabSettings.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Token
            // 
            this.lbl_Token.AutoSize = true;
            this.lbl_Token.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_Token.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_Token.Location = new System.Drawing.Point(12, 12);
            this.lbl_Token.Name = "lbl_Token";
            this.lbl_Token.Size = new System.Drawing.Size(104, 20);
            this.lbl_Token.TabIndex = 0;
            this.lbl_Token.Text = "OAuth Token:";
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
            this.tc_Main.Controls.Add(this.tabPage3);
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
            this.tabSettings.Controls.Add(this.cb_Remember);
            this.tabSettings.Controls.Add(this.lbl_Status);
            this.tabSettings.Controls.Add(this.lbl_StatusHeader);
            this.tabSettings.Controls.Add(this.btn_Start);
            this.tabSettings.Controls.Add(this.btn_InsertToken);
            this.tabSettings.Controls.Add(this.btn_InsertBotName);
            this.tabSettings.Controls.Add(this.btn_InsertStreamerName);
            this.tabSettings.Controls.Add(this.tb_Token);
            this.tabSettings.Controls.Add(this.tb_StreamChannelName);
            this.tabSettings.Controls.Add(this.lbl_Token);
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
            this.lbl_Status.Size = new System.Drawing.Size(15, 20);
            this.lbl_Status.TabIndex = 11;
            this.lbl_Status.Text = "s";
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
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage3.Controls.Add(this.button1);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(584, 335);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabChat";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.tc_Main.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Token;
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
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
    }
}

