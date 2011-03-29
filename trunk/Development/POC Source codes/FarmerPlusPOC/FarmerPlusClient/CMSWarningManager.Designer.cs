namespace FarmerPlusClient
{
    partial class CMSWarningManager
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.comboBoxMessageType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxComplaintLog = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.comboBoxDistrict = new System.Windows.Forms.ComboBox();
            this.comboBoxAnnouncementType = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBoxComplaintLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Announcement Type";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(129, 143);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMessage.Size = new System.Drawing.Size(444, 156);
            this.txtMessage.TabIndex = 11;
            this.txtMessage.Enter += new System.EventHandler(this.textBox3_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "District";
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(265, 334);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(144, 46);
            this.btnSchedule.TabIndex = 15;
            this.btnSchedule.Text = "Send Announcement";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // comboBoxMessageType
            // 
            this.comboBoxMessageType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMessageType.FormattingEnabled = true;
            this.comboBoxMessageType.Items.AddRange(new object[] {
            "SMS",
            "IVR",
            "Both"});
            this.comboBoxMessageType.Location = new System.Drawing.Point(129, 50);
            this.comboBoxMessageType.Name = "comboBoxMessageType";
            this.comboBoxMessageType.Size = new System.Drawing.Size(182, 21);
            this.comboBoxMessageType.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Message Type";
            // 
            // groupBoxComplaintLog
            // 
            this.groupBoxComplaintLog.Controls.Add(this.label5);
            this.groupBoxComplaintLog.Controls.Add(this.label2);
            this.groupBoxComplaintLog.Controls.Add(this.comboBoxCity);
            this.groupBoxComplaintLog.Controls.Add(this.comboBoxDistrict);
            this.groupBoxComplaintLog.Controls.Add(this.comboBoxAnnouncementType);
            this.groupBoxComplaintLog.Controls.Add(this.txtMessage);
            this.groupBoxComplaintLog.Controls.Add(this.label1);
            this.groupBoxComplaintLog.Controls.Add(this.label4);
            this.groupBoxComplaintLog.Controls.Add(this.comboBoxMessageType);
            this.groupBoxComplaintLog.Controls.Add(this.btnSchedule);
            this.groupBoxComplaintLog.Controls.Add(this.label3);
            this.groupBoxComplaintLog.Controls.Add(this.button1);
            this.groupBoxComplaintLog.Location = new System.Drawing.Point(12, 12);
            this.groupBoxComplaintLog.Name = "groupBoxComplaintLog";
            this.groupBoxComplaintLog.Size = new System.Drawing.Size(687, 402);
            this.groupBoxComplaintLog.TabIndex = 25;
            this.groupBoxComplaintLog.TabStop = false;
            this.groupBoxComplaintLog.Text = "Announcement";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Type SMS (Urdu)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "City";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Items.AddRange(new object[] {
            "SMS",
            "IVR",
            "Both"});
            this.comboBoxCity.Location = new System.Drawing.Point(129, 103);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(182, 21);
            this.comboBoxCity.TabIndex = 27;
            // 
            // comboBoxDistrict
            // 
            this.comboBoxDistrict.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistrict.FormattingEnabled = true;
            this.comboBoxDistrict.Items.AddRange(new object[] {
            "SMS",
            "IVR",
            "Both"});
            this.comboBoxDistrict.Location = new System.Drawing.Point(129, 76);
            this.comboBoxDistrict.Name = "comboBoxDistrict";
            this.comboBoxDistrict.Size = new System.Drawing.Size(182, 21);
            this.comboBoxDistrict.TabIndex = 26;
            this.comboBoxDistrict.SelectedIndexChanged += new System.EventHandler(this.comboBoxDistrict_SelectedIndexChanged);
            // 
            // comboBoxAnnouncementType
            // 
            this.comboBoxAnnouncementType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAnnouncementType.FormattingEnabled = true;
            this.comboBoxAnnouncementType.Items.AddRange(new object[] {
            "Flood Warning",
            "Pest Warning",
            "Marketing Announcement"});
            this.comboBoxAnnouncementType.Location = new System.Drawing.Point(129, 23);
            this.comboBoxAnnouncementType.Name = "comboBoxAnnouncementType";
            this.comboBoxAnnouncementType.Size = new System.Drawing.Size(182, 21);
            this.comboBoxAnnouncementType.TabIndex = 25;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "Record Voice (IVR)";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CMSWarningManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 431);
            this.Controls.Add(this.groupBoxComplaintLog);
            this.Name = "CMSWarningManager";
            this.Text = "CMS Announcements";
            this.Load += new System.EventHandler(this.CMSMarketingManager_Load);
            this.groupBoxComplaintLog.ResumeLayout(false);
            this.groupBoxComplaintLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.ComboBox comboBoxMessageType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBoxComplaintLog;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.ComboBox comboBoxDistrict;
        private System.Windows.Forms.ComboBox comboBoxAnnouncementType;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
    }
}