namespace FarmerPlusClient
{
    partial class PhoneRanges
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
            this.dataGridViewPhoneRanges = new System.Windows.Forms.DataGridView();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPhoneCode = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lableVendorType = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneRanges)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPhoneRanges
            // 
            this.dataGridViewPhoneRanges.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPhoneRanges.Location = new System.Drawing.Point(12, 41);
            this.dataGridViewPhoneRanges.Name = "dataGridViewPhoneRanges";
            this.dataGridViewPhoneRanges.Size = new System.Drawing.Size(662, 292);
            this.dataGridViewPhoneRanges.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(275, 339);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "City";
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(61, 10);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(148, 21);
            this.comboBoxCity.TabIndex = 28;
            this.comboBoxCity.SelectedIndexChanged += new System.EventHandler(this.comboBoxCity_SelectedIndexChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(370, 339);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(75, 23);
            this.buttonCancel.TabIndex = 30;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Phone code : ";
            // 
            // labelPhoneCode
            // 
            this.labelPhoneCode.AutoSize = true;
            this.labelPhoneCode.Location = new System.Drawing.Point(304, 14);
            this.labelPhoneCode.Name = "labelPhoneCode";
            this.labelPhoneCode.Size = new System.Drawing.Size(35, 13);
            this.labelPhoneCode.TabIndex = 32;
            this.labelPhoneCode.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(355, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "Vendor Type : ";
            // 
            // lableVendorType
            // 
            this.lableVendorType.AutoSize = true;
            this.lableVendorType.Location = new System.Drawing.Point(428, 14);
            this.lableVendorType.Name = "lableVendorType";
            this.lableVendorType.Size = new System.Drawing.Size(35, 13);
            this.lableVendorType.TabIndex = 34;
            this.lableVendorType.Text = "label4";
            // 
            // PhoneRanges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 374);
            this.Controls.Add(this.lableVendorType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelPhoneCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.dataGridViewPhoneRanges);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PhoneRanges";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PhoneRanges";
            this.Load += new System.EventHandler(this.PhoneRanges_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPhoneRanges)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPhoneRanges;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPhoneCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lableVendorType;
    }
}