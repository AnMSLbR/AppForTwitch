
namespace AppForTwitch
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_Token = new System.Windows.Forms.Label();
            this.tb_Token = new System.Windows.Forms.TextBox();
            this.lbl_BotChannelName = new System.Windows.Forms.Label();
            this.tb_BotChannelName = new System.Windows.Forms.TextBox();
            this.lbl_StreamChannelName = new System.Windows.Forms.Label();
            this.tb_StreamChannelName = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_Start = new System.Windows.Forms.Button();
            this.btn_InsertToken = new System.Windows.Forms.Button();
            this.btn_InsertBotName = new System.Windows.Forms.Button();
            this.btn_InsertStreamerName = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Malgun Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.Location = new System.Drawing.Point(-4, -3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 368);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.TabStop = false;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage1.Controls.Add(this.btn_Start);
            this.tabPage1.Controls.Add(this.btn_InsertToken);
            this.tabPage1.Controls.Add(this.btn_InsertBotName);
            this.tabPage1.Controls.Add(this.btn_InsertStreamerName);
            this.tabPage1.Controls.Add(this.tb_Token);
            this.tabPage1.Controls.Add(this.tb_StreamChannelName);
            this.tabPage1.Controls.Add(this.lbl_Token);
            this.tabPage1.Controls.Add(this.lbl_StreamChannelName);
            this.tabPage1.Controls.Add(this.lbl_BotChannelName);
            this.tabPage1.Controls.Add(this.tb_BotChannelName);
            this.tabPage1.ImageIndex = 0;
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 335);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Settings";
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
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 335);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Commands";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "TwitchBot";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_Token;
        private System.Windows.Forms.TextBox tb_Token;
        private System.Windows.Forms.Label lbl_BotChannelName;
        private System.Windows.Forms.TextBox tb_BotChannelName;
        private System.Windows.Forms.Label lbl_StreamChannelName;
        private System.Windows.Forms.TextBox tb_StreamChannelName;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_InsertStreamerName;
        private System.Windows.Forms.Button btn_InsertToken;
        private System.Windows.Forms.Button btn_InsertBotName;
        private System.Windows.Forms.Button btn_Start;
    }
}

