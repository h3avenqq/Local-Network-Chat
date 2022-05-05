namespace Local_Network_Chat
{
    partial class FrmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageChat = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.GbxClient1 = new System.Windows.Forms.GroupBox();
            this.TxtIpHost = new System.Windows.Forms.TextBox();
            this.TxtPortHost = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LbxChat = new System.Windows.Forms.ListBox();
            this.BtnSendMessage = new System.Windows.Forms.Button();
            this.TxtNicknameHost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.GbxClient2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtNicknameClient = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtPortClient = new System.Windows.Forms.TextBox();
            this.TxtIpClient = new System.Windows.Forms.TextBox();
            this.BtnConnect = new System.Windows.Forms.Button();
            this.BtnDisconect = new System.Windows.Forms.Button();
            this.TxtMessage = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPageChat.SuspendLayout();
            this.GbxClient1.SuspendLayout();
            this.GbxClient2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageChat);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(805, 454);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPageChat
            // 
            this.tabPageChat.Controls.Add(this.BtnDisconect);
            this.tabPageChat.Controls.Add(this.BtnConnect);
            this.tabPageChat.Controls.Add(this.GbxClient2);
            this.tabPageChat.Controls.Add(this.BtnSendMessage);
            this.tabPageChat.Controls.Add(this.TxtMessage);
            this.tabPageChat.Controls.Add(this.LbxChat);
            this.tabPageChat.Controls.Add(this.GbxClient1);
            this.tabPageChat.Location = new System.Drawing.Point(4, 22);
            this.tabPageChat.Name = "tabPageChat";
            this.tabPageChat.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageChat.Size = new System.Drawing.Size(797, 428);
            this.tabPageChat.TabIndex = 0;
            this.tabPageChat.Text = "Chat";
            this.tabPageChat.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 74);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // GbxClient1
            // 
            this.GbxClient1.Controls.Add(this.label5);
            this.GbxClient1.Controls.Add(this.TxtNicknameHost);
            this.GbxClient1.Controls.Add(this.label2);
            this.GbxClient1.Controls.Add(this.label1);
            this.GbxClient1.Controls.Add(this.TxtPortHost);
            this.GbxClient1.Controls.Add(this.TxtIpHost);
            this.GbxClient1.Location = new System.Drawing.Point(161, 6);
            this.GbxClient1.Name = "GbxClient1";
            this.GbxClient1.Size = new System.Drawing.Size(227, 138);
            this.GbxClient1.TabIndex = 0;
            this.GbxClient1.TabStop = false;
            this.GbxClient1.Text = "Client1";
            // 
            // TxtIpHost
            // 
            this.TxtIpHost.Location = new System.Drawing.Point(69, 60);
            this.TxtIpHost.Name = "TxtIpHost";
            this.TxtIpHost.Size = new System.Drawing.Size(152, 20);
            this.TxtIpHost.TabIndex = 0;
            // 
            // TxtPortHost
            // 
            this.TxtPortHost.Location = new System.Drawing.Point(69, 101);
            this.TxtPortHost.Name = "TxtPortHost";
            this.TxtPortHost.Size = new System.Drawing.Size(152, 20);
            this.TxtPortHost.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PORT";
            // 
            // LbxChat
            // 
            this.LbxChat.FormattingEnabled = true;
            this.LbxChat.Location = new System.Drawing.Point(113, 196);
            this.LbxChat.Name = "LbxChat";
            this.LbxChat.Size = new System.Drawing.Size(562, 160);
            this.LbxChat.TabIndex = 5;
            // 
            // BtnSendMessage
            // 
            this.BtnSendMessage.Enabled = false;
            this.BtnSendMessage.Location = new System.Drawing.Point(600, 362);
            this.BtnSendMessage.Name = "BtnSendMessage";
            this.BtnSendMessage.Size = new System.Drawing.Size(75, 31);
            this.BtnSendMessage.TabIndex = 7;
            this.BtnSendMessage.Text = "Send";
            this.BtnSendMessage.UseVisualStyleBackColor = true;
            this.BtnSendMessage.Click += new System.EventHandler(this.BtnSendMessage_Click);
            // 
            // TxtNicknameHost
            // 
            this.TxtNicknameHost.Location = new System.Drawing.Point(69, 25);
            this.TxtNicknameHost.Name = "TxtNicknameHost";
            this.TxtNicknameHost.Size = new System.Drawing.Size(152, 20);
            this.TxtNicknameHost.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Nickname";
            // 
            // GbxClient2
            // 
            this.GbxClient2.Controls.Add(this.label3);
            this.GbxClient2.Controls.Add(this.TxtNicknameClient);
            this.GbxClient2.Controls.Add(this.label4);
            this.GbxClient2.Controls.Add(this.label6);
            this.GbxClient2.Controls.Add(this.TxtPortClient);
            this.GbxClient2.Controls.Add(this.TxtIpClient);
            this.GbxClient2.Location = new System.Drawing.Point(394, 6);
            this.GbxClient2.Name = "GbxClient2";
            this.GbxClient2.Size = new System.Drawing.Size(227, 138);
            this.GbxClient2.TabIndex = 6;
            this.GbxClient2.TabStop = false;
            this.GbxClient2.Text = "Client2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nickname";
            // 
            // TxtNicknameClient
            // 
            this.TxtNicknameClient.Location = new System.Drawing.Point(69, 25);
            this.TxtNicknameClient.Name = "TxtNicknameClient";
            this.TxtNicknameClient.Size = new System.Drawing.Size(152, 20);
            this.TxtNicknameClient.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "PORT";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(46, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "IP";
            // 
            // TxtPortClient
            // 
            this.TxtPortClient.Location = new System.Drawing.Point(69, 101);
            this.TxtPortClient.Name = "TxtPortClient";
            this.TxtPortClient.Size = new System.Drawing.Size(152, 20);
            this.TxtPortClient.TabIndex = 1;
            // 
            // TxtIpClient
            // 
            this.TxtIpClient.Location = new System.Drawing.Point(69, 60);
            this.TxtIpClient.Name = "TxtIpClient";
            this.TxtIpClient.Size = new System.Drawing.Size(152, 20);
            this.TxtIpClient.TabIndex = 0;
            // 
            // BtnConnect
            // 
            this.BtnConnect.Location = new System.Drawing.Point(463, 150);
            this.BtnConnect.Name = "BtnConnect";
            this.BtnConnect.Size = new System.Drawing.Size(75, 31);
            this.BtnConnect.TabIndex = 8;
            this.BtnConnect.Text = "Connect";
            this.BtnConnect.UseVisualStyleBackColor = true;
            this.BtnConnect.Click += new System.EventHandler(this.BtnConnect_Click);
            // 
            // BtnDisconect
            // 
            this.BtnDisconect.Enabled = false;
            this.BtnDisconect.Location = new System.Drawing.Point(546, 150);
            this.BtnDisconect.Name = "BtnDisconect";
            this.BtnDisconect.Size = new System.Drawing.Size(75, 31);
            this.BtnDisconect.TabIndex = 9;
            this.BtnDisconect.Text = "Disconect";
            this.BtnDisconect.UseVisualStyleBackColor = true;
            this.BtnDisconect.Click += new System.EventHandler(this.BtnDisconect_Click);
            // 
            // TxtMessage
            // 
            this.TxtMessage.Location = new System.Drawing.Point(113, 362);
            this.TxtMessage.Multiline = true;
            this.TxtMessage.Name = "TxtMessage";
            this.TxtMessage.Size = new System.Drawing.Size(481, 31);
            this.TxtMessage.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmMain";
            this.Text = "Local Network Chat";
            this.tabControl1.ResumeLayout(false);
            this.tabPageChat.ResumeLayout(false);
            this.tabPageChat.PerformLayout();
            this.GbxClient1.ResumeLayout(false);
            this.GbxClient1.PerformLayout();
            this.GbxClient2.ResumeLayout(false);
            this.GbxClient2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageChat;
        private System.Windows.Forms.Button BtnSendMessage;
        private System.Windows.Forms.ListBox LbxChat;
        private System.Windows.Forms.GroupBox GbxClient1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtNicknameHost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtPortHost;
        private System.Windows.Forms.TextBox TxtIpHost;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnDisconect;
        private System.Windows.Forms.Button BtnConnect;
        private System.Windows.Forms.GroupBox GbxClient2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtNicknameClient;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtPortClient;
        private System.Windows.Forms.TextBox TxtIpClient;
        private System.Windows.Forms.TextBox TxtMessage;
    }
}

