namespace FarmerPlusScheduarManager
{
    partial class SchedularDashboard
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
            this.components = new System.ComponentModel.Container();
            this.timerSchedular = new System.Windows.Forms.Timer(this.components);
            this.timerWeather = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timerSchedular
            // 
            this.timerSchedular.Interval = 60000;
            this.timerSchedular.Tick += new System.EventHandler(this.timerSchedular_Tick);
            // 
            // timerWeather
            // 
            this.timerWeather.Interval = 18000000;
            this.timerWeather.Tick += new System.EventHandler(this.timerWeather_Tick);
            // 
            // SchedularDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 58);
            this.Name = "SchedularDashboard";
            this.Text = "SchedularDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSchedular;
        private System.Windows.Forms.Timer timerWeather;
    }
}

