namespace FarmerPlusClient
{
    partial class Add_Crop
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxUrduName = new System.Windows.Forms.TextBox();
            this.buttonRecord = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(70, 28);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(219, 40);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxUrduName
            // 
            this.textBoxUrduName.Location = new System.Drawing.Point(70, 80);
            this.textBoxUrduName.Multiline = true;
            this.textBoxUrduName.Name = "textBoxUrduName";
            this.textBoxUrduName.Size = new System.Drawing.Size(219, 40);
            this.textBoxUrduName.TabIndex = 1;
            // 
            // buttonRecord
            // 
            this.buttonRecord.Location = new System.Drawing.Point(295, 82);
            this.buttonRecord.Name = "buttonRecord";
            this.buttonRecord.Size = new System.Drawing.Size(95, 37);
            this.buttonRecord.TabIndex = 2;
            this.buttonRecord.Text = "Record Voice";
            this.buttonRecord.UseVisualStyleBackColor = true;
            this.buttonRecord.Click += new System.EventHandler(this.buttonRecord_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(162, 148);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(90, 34);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Crop Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Urdu";
            // 
            // Add_Crop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 194);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonRecord);
            this.Controls.Add(this.textBoxUrduName);
            this.Controls.Add(this.textBoxName);
            this.Name = "Add_Crop";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Crop";
            this.Load += new System.EventHandler(this.Add_Crop_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxUrduName;
        private System.Windows.Forms.Button buttonRecord;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}