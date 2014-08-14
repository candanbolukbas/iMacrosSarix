namespace iMacrosSarix
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.lbResults = new System.Windows.Forms.ListBox();
            this.btSelectIPList = new System.Windows.Forms.Button();
            this.lbIpList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ofdSelectIPList = new System.Windows.Forms.OpenFileDialog();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.btStart = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbIIM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUrl = new System.Windows.Forms.TextBox();
            this.pbProgress = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIIMProfile = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btPlayOnly = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbResults
            // 
            this.lbResults.FormattingEnabled = true;
            this.lbResults.HorizontalExtent = 800;
            this.lbResults.HorizontalScrollbar = true;
            this.lbResults.Location = new System.Drawing.Point(12, 91);
            this.lbResults.Name = "lbResults";
            this.lbResults.Size = new System.Drawing.Size(425, 225);
            this.lbResults.TabIndex = 21;
            // 
            // btSelectIPList
            // 
            this.btSelectIPList.Location = new System.Drawing.Point(443, 11);
            this.btSelectIPList.Name = "btSelectIPList";
            this.btSelectIPList.Size = new System.Drawing.Size(96, 30);
            this.btSelectIPList.TabIndex = 20;
            this.btSelectIPList.Text = "Select IP List";
            this.btSelectIPList.UseVisualStyleBackColor = true;
            this.btSelectIPList.Click += new System.EventHandler(this.btSelectIPList_Click);
            // 
            // lbIpList
            // 
            this.lbIpList.FormattingEnabled = true;
            this.lbIpList.Location = new System.Drawing.Point(443, 91);
            this.lbIpList.Name = "lbIpList";
            this.lbIpList.Size = new System.Drawing.Size(96, 225);
            this.lbIpList.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Username:";
            // 
            // ofdSelectIPList
            // 
            this.ofdSelectIPList.FileName = "C:\\ip.txt";
            this.ofdSelectIPList.FileOk += new System.ComponentModel.CancelEventHandler(this.ofdSelectIPList_FileOk);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(80, 39);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(76, 20);
            this.tbPassword.TabIndex = 16;
            this.tbPassword.Text = "20PelcO09";
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(80, 12);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(76, 20);
            this.tbUsername.TabIndex = 15;
            this.tbUsername.Text = "admin";
            // 
            // btStart
            // 
            this.btStart.Location = new System.Drawing.Point(443, 46);
            this.btStart.Name = "btStart";
            this.btStart.Size = new System.Drawing.Size(96, 40);
            this.btStart.TabIndex = 14;
            this.btStart.Text = "Start";
            this.btStart.UseVisualStyleBackColor = true;
            this.btStart.Click += new System.EventHandler(this.btStart_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(163, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "IIM Name:";
            // 
            // tbIIM
            // 
            this.tbIIM.Location = new System.Drawing.Point(246, 39);
            this.tbIIM.Name = "tbIIM";
            this.tbIIM.Size = new System.Drawing.Size(191, 20);
            this.tbIIM.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(163, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "URL ({0} = IP):";
            // 
            // tbUrl
            // 
            this.tbUrl.Enabled = false;
            this.tbUrl.Location = new System.Drawing.Point(246, 66);
            this.tbUrl.Name = "tbUrl";
            this.tbUrl.Size = new System.Drawing.Size(191, 20);
            this.tbUrl.TabIndex = 24;
            // 
            // pbProgress
            // 
            this.pbProgress.Location = new System.Drawing.Point(49, 323);
            this.pbProgress.Name = "pbProgress";
            this.pbProgress.Size = new System.Drawing.Size(490, 24);
            this.pbProgress.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "0 %";
            // 
            // cbIIMProfile
            // 
            this.cbIIMProfile.FormattingEnabled = true;
            this.cbIIMProfile.Items.AddRange(new object[] {
            "Enable SSH",
            "Set Time Server",
            "A/V Config Set to H264"});
            this.cbIIMProfile.Location = new System.Drawing.Point(246, 11);
            this.cbIIMProfile.Name = "cbIIMProfile";
            this.cbIIMProfile.Size = new System.Drawing.Size(191, 21);
            this.cbIIMProfile.TabIndex = 29;
            this.cbIIMProfile.SelectedIndexChanged += new System.EventHandler(this.cbIIMProfile_SelectedIndexChanged);
            this.cbIIMProfile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cbIIMProfile_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "IIM Profile:";
            // 
            // btPlayOnly
            // 
            this.btPlayOnly.Location = new System.Drawing.Point(12, 63);
            this.btPlayOnly.Name = "btPlayOnly";
            this.btPlayOnly.Size = new System.Drawing.Size(144, 23);
            this.btPlayOnly.TabIndex = 31;
            this.btPlayOnly.Text = "Play Only IIM";
            this.btPlayOnly.UseVisualStyleBackColor = true;
            this.btPlayOnly.Click += new System.EventHandler(this.btPlayOnly_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(551, 352);
            this.Controls.Add(this.btPlayOnly);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbIIMProfile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pbProgress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbUrl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbIIM);
            this.Controls.Add(this.lbResults);
            this.Controls.Add(this.btSelectIPList);
            this.Controls.Add(this.lbIpList);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.btStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.Text = "Pelco iMacros";
            this.Resize += new System.EventHandler(this.Main_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResults;
        private System.Windows.Forms.Button btSelectIPList;
        private System.Windows.Forms.ListBox lbIpList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofdSelectIPList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.Button btStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbIIM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUrl;
        private System.Windows.Forms.ProgressBar pbProgress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbIIMProfile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btPlayOnly;

    }
}

