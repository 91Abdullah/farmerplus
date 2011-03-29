namespace FarmerPlusClient
{
    partial class Add_Pesticide
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBoxUrdu = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Urdu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 24;
            this.label1.Text = "Name";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(149, 112);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(88, 36);
            this.buttonSave.TabIndex = 23;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(76, 36);
            this.button1.TabIndex = 22;
            this.button1.Text = "Record Voice";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxUrdu
            // 
            this.textBoxUrdu.Location = new System.Drawing.Point(95, 66);
            this.textBoxUrdu.Multiline = true;
            this.textBoxUrdu.Name = "textBoxUrdu";
            this.textBoxUrdu.Size = new System.Drawing.Size(198, 40);
            this.textBoxUrdu.TabIndex = 21;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 17);
            this.textBoxName.Multiline = true;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(198, 40);
            this.textBoxName.TabIndex = 20;
            // 
            // Add_Pesticide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 173);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxUrdu);
            this.Controls.Add(this.textBoxName);
            this.Name = "Add_Pesticide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add_Pesticide";
            this.Load += new System.EventHandler(this.Add_Pesticide_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBoxUrdu;
        private System.Windows.Forms.TextBox textBoxName;
    }
}