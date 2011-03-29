namespace FarmerPlusClient
{
    partial class CMSComplaintLog
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
            this.groupBoxComplaintLog = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFollowup = new System.Windows.Forms.TextBox();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.dataGridComplaints = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxService = new System.Windows.Forms.ComboBox();
            this.buttonUpdateFollowup = new System.Windows.Forms.Button();
            this.groupBoxComplaintLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComplaints)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxComplaintLog
            // 
            this.groupBoxComplaintLog.Controls.Add(this.buttonUpdateFollowup);
            this.groupBoxComplaintLog.Controls.Add(this.button1);
            this.groupBoxComplaintLog.Controls.Add(this.label3);
            this.groupBoxComplaintLog.Controls.Add(this.textBoxFollowup);
            this.groupBoxComplaintLog.Controls.Add(this.buttonUpdate);
            this.groupBoxComplaintLog.Controls.Add(this.dataGridComplaints);
            this.groupBoxComplaintLog.Controls.Add(this.label2);
            this.groupBoxComplaintLog.Controls.Add(this.comboBoxCategory);
            this.groupBoxComplaintLog.Controls.Add(this.label1);
            this.groupBoxComplaintLog.Controls.Add(this.comboBoxService);
            this.groupBoxComplaintLog.Location = new System.Drawing.Point(12, 6);
            this.groupBoxComplaintLog.Name = "groupBoxComplaintLog";
            this.groupBoxComplaintLog.Size = new System.Drawing.Size(813, 490);
            this.groupBoxComplaintLog.TabIndex = 0;
            this.groupBoxComplaintLog.TabStop = false;
            this.groupBoxComplaintLog.Text = "Complaint Log";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(576, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Play";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 378);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "FollowUp";
            // 
            // textBoxFollowup
            // 
            this.textBoxFollowup.Location = new System.Drawing.Point(97, 364);
            this.textBoxFollowup.Multiline = true;
            this.textBoxFollowup.Name = "textBoxFollowup";
            this.textBoxFollowup.Size = new System.Drawing.Size(472, 91);
            this.textBoxFollowup.TabIndex = 6;
            this.textBoxFollowup.Leave += new System.EventHandler(this.textBoxFollowup_leave);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(296, 60);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(119, 29);
            this.buttonUpdate.TabIndex = 5;
            this.buttonUpdate.Text = "Update Complaints";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // dataGridComplaints
            // 
            this.dataGridComplaints.AllowUserToAddRows = false;
            this.dataGridComplaints.AllowUserToDeleteRows = false;
            this.dataGridComplaints.AllowUserToResizeRows = false;
            this.dataGridComplaints.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridComplaints.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridComplaints.Location = new System.Drawing.Point(18, 111);
            this.dataGridComplaints.MultiSelect = false;
            this.dataGridComplaints.Name = "dataGridComplaints";
            this.dataGridComplaints.ReadOnly = true;
            this.dataGridComplaints.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridComplaints.Size = new System.Drawing.Size(789, 247);
            this.dataGridComplaints.TabIndex = 4;
            this.dataGridComplaints.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridComplaints_RowEnter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Category";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Items.AddRange(new object[] {
            "Delayed Purchasing",
            "Unfair Pricing",
            "Adulteration of Pesticides"});
            this.comboBoxCategory.Location = new System.Drawing.Point(97, 33);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(173, 21);
            this.comboBoxCategory.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Service";
            // 
            // comboBoxService
            // 
            this.comboBoxService.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxService.FormattingEnabled = true;
            this.comboBoxService.Items.AddRange(new object[] {
            "IVR",
            "SMS"});
            this.comboBoxService.Location = new System.Drawing.Point(97, 65);
            this.comboBoxService.Name = "comboBoxService";
            this.comboBoxService.Size = new System.Drawing.Size(173, 21);
            this.comboBoxService.TabIndex = 0;
            // 
            // buttonUpdateFollowup
            // 
            this.buttonUpdateFollowup.Location = new System.Drawing.Point(97, 461);
            this.buttonUpdateFollowup.Name = "buttonUpdateFollowup";
            this.buttonUpdateFollowup.Size = new System.Drawing.Size(103, 23);
            this.buttonUpdateFollowup.TabIndex = 9;
            this.buttonUpdateFollowup.Text = "Update Followup";
            this.buttonUpdateFollowup.UseVisualStyleBackColor = true;
            this.buttonUpdateFollowup.Click += new System.EventHandler(this.button2_Click);
            // 
            // CMSComplaintLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 508);
            this.Controls.Add(this.groupBoxComplaintLog);
            this.Name = "CMSComplaintLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Complaint Log";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CMSComplaintLog_Load);
            this.groupBoxComplaintLog.ResumeLayout(false);
            this.groupBoxComplaintLog.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridComplaints)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxComplaintLog;
        private System.Windows.Forms.DataGridView dataGridComplaints;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxService;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFollowup;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonUpdateFollowup;
    }
}