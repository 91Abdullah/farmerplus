namespace FarmerPlusClient
{
    partial class CMSLogin
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
            this.grpboxLogin = new System.Windows.Forms.GroupBox();
            this.lblError = new System.Windows.Forms.Label();
            this.picboxLogin = new System.Windows.Forms.PictureBox();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.grpboxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // grpboxLogin
            // 
            this.grpboxLogin.Controls.Add(this.lblError);
            this.grpboxLogin.Controls.Add(this.picboxLogin);
            this.grpboxLogin.Controls.Add(this.txtPass);
            this.grpboxLogin.Controls.Add(this.txtUser);
            this.grpboxLogin.Controls.Add(this.lblPass);
            this.grpboxLogin.Controls.Add(this.lblUser);
            this.grpboxLogin.Controls.Add(this.btnCancel);
            this.grpboxLogin.Controls.Add(this.btnLogin);
            this.grpboxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpboxLogin.Location = new System.Drawing.Point(12, 12);
            this.grpboxLogin.Name = "grpboxLogin";
            this.grpboxLogin.Size = new System.Drawing.Size(391, 220);
            this.grpboxLogin.TabIndex = 0;
            this.grpboxLogin.TabStop = false;
            this.grpboxLogin.Text = "Login";
            // 
            // lblError
            // 
            this.lblError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(50, 134);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(147, 13);
            this.lblError.TabIndex = 7;
            this.lblError.Text = "Invalid username or password";
            this.lblError.Visible = false;
            // 
            // picboxLogin
            // 
            this.picboxLogin.Image = global::FarmerPlusClient.Properties.Resources._lock;
            this.picboxLogin.InitialImage = null;
            this.picboxLogin.Location = new System.Drawing.Point(326, 36);
            this.picboxLogin.Name = "picboxLogin";
            this.picboxLogin.Size = new System.Drawing.Size(57, 70);
            this.picboxLogin.TabIndex = 6;
            this.picboxLogin.TabStop = false;
            // 
            // txtPass
            // 
            this.txtPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPass.Location = new System.Drawing.Point(83, 72);
            this.txtPass.Multiline = true;
            this.txtPass.Name = "txtPass";
            this.txtPass.PasswordChar = '*';
            this.txtPass.Size = new System.Drawing.Size(213, 40);
            this.txtPass.TabIndex = 1;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.Location = new System.Drawing.Point(83, 19);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(213, 40);
            this.txtUser.TabIndex = 0;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(9, 86);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(53, 13);
            this.lblPass.TabIndex = 3;
            this.lblPass.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(6, 34);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(60, 13);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User Name";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(203, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(96, 41);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(104, 161);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(93, 41);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // CMSLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 241);
            this.Controls.Add(this.grpboxLogin);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CMSLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Farmer Plus";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CMSLogin_FormClosed);
            this.Load += new System.EventHandler(this.CMSLogin_Load);
            this.grpboxLogin.ResumeLayout(false);
            this.grpboxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpboxLogin;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.PictureBox picboxLogin;
        private System.Windows.Forms.Label lblError;
    }
}