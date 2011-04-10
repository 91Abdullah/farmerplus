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
            this.buttonCropSchedular = new System.Windows.Forms.Button();
            this.buttonWeatherSchedular = new System.Windows.Forms.Button();
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
            // buttonCropSchedular
            // 
            this.buttonCropSchedular.Location = new System.Drawing.Point(12, 12);
            this.buttonCropSchedular.Name = "buttonCropSchedular";
            this.buttonCropSchedular.Size = new System.Drawing.Size(198, 34);
            this.buttonCropSchedular.TabIndex = 0;
            this.buttonCropSchedular.Text = "Run Crop Schedular Manually";
            this.buttonCropSchedular.UseVisualStyleBackColor = true;
            this.buttonCropSchedular.Click += new System.EventHandler(this.buttonCropSchedular_Click);
            // 
            // buttonWeatherSchedular
            // 
            this.buttonWeatherSchedular.Location = new System.Drawing.Point(271, 12);
            this.buttonWeatherSchedular.Name = "buttonWeatherSchedular";
            this.buttonWeatherSchedular.Size = new System.Drawing.Size(190, 34);
            this.buttonWeatherSchedular.TabIndex = 1;
            this.buttonWeatherSchedular.Text = "Run Weather Schedular Manually";
            this.buttonWeatherSchedular.UseVisualStyleBackColor = true;
            this.buttonWeatherSchedular.Click += new System.EventHandler(this.buttonWeatherSchedular_Click);
            // 
            // SchedularDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 67);
            this.Controls.Add(this.buttonWeatherSchedular);
            this.Controls.Add(this.buttonCropSchedular);
            this.Name = "SchedularDashboard";
            this.Text = "SchedularDashboard";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timerSchedular;
        private System.Windows.Forms.Timer timerWeather;
        private System.Windows.Forms.Button buttonCropSchedular;
        private System.Windows.Forms.Button buttonWeatherSchedular;
    }
}

