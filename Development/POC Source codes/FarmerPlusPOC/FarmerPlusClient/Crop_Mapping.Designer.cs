namespace FarmerPlusClient
{
    partial class Crop_Mapping
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
            this.comboBoxCrops = new System.Windows.Forms.ComboBox();
            this.btnNewCrop = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridViewFertilizers = new System.Windows.Forms.DataGridView();
            this.ColumnFerts = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.dataGridViewSeeds = new System.Windows.Forms.DataGridView();
            this.ColumnSeed = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.dataGridViewPesticides = new System.Windows.Forms.DataGridView();
            this.ColumnPest = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePickerReapEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerReapStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePickerCultEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerCultStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonIVR = new System.Windows.Forms.Button();
            this.buttonSMS = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxDistricts = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFertilizers)).BeginInit();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeeds)).BeginInit();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesticides)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxCrops
            // 
            this.comboBoxCrops.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCrops.FormattingEnabled = true;
            this.comboBoxCrops.Location = new System.Drawing.Point(109, 61);
            this.comboBoxCrops.Name = "comboBoxCrops";
            this.comboBoxCrops.Size = new System.Drawing.Size(169, 21);
            this.comboBoxCrops.TabIndex = 0;
            this.comboBoxCrops.SelectedIndexChanged += new System.EventHandler(this.comboBoxCrops_SelectedIndexChanged);
            // 
            // btnNewCrop
            // 
            this.btnNewCrop.Location = new System.Drawing.Point(313, 61);
            this.btnNewCrop.Name = "btnNewCrop";
            this.btnNewCrop.Size = new System.Drawing.Size(101, 23);
            this.btnNewCrop.TabIndex = 2;
            this.btnNewCrop.Text = "Add New Crop";
            this.btnNewCrop.UseVisualStyleBackColor = true;
            this.btnNewCrop.Click += new System.EventHandler(this.btnNewCrop_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox7);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(51, 121);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1153, 451);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cultivatio Information";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridViewFertilizers);
            this.groupBox4.Location = new System.Drawing.Point(684, 229);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(449, 184);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Fertilizers";
            // 
            // dataGridViewFertilizers
            // 
            this.dataGridViewFertilizers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFertilizers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFerts});
            this.dataGridViewFertilizers.Location = new System.Drawing.Point(7, 20);
            this.dataGridViewFertilizers.Name = "dataGridViewFertilizers";
            this.dataGridViewFertilizers.Size = new System.Drawing.Size(436, 158);
            this.dataGridViewFertilizers.TabIndex = 2;
            // 
            // ColumnFerts
            // 
            this.ColumnFerts.HeaderText = "ColumnFerts";
            this.ColumnFerts.Name = "ColumnFerts";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.dataGridViewSeeds);
            this.groupBox7.Location = new System.Drawing.Point(7, 235);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(641, 184);
            this.groupBox7.TabIndex = 4;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Seeds";
            // 
            // dataGridViewSeeds
            // 
            this.dataGridViewSeeds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnSeed,
            this.ColumnPrice});
            this.dataGridViewSeeds.Location = new System.Drawing.Point(13, 20);
            this.dataGridViewSeeds.Name = "dataGridViewSeeds";
            this.dataGridViewSeeds.Size = new System.Drawing.Size(622, 153);
            this.dataGridViewSeeds.TabIndex = 3;
            // 
            // ColumnSeed
            // 
            this.ColumnSeed.HeaderText = "ColumnSeed";
            this.ColumnSeed.Name = "ColumnSeed";
            // 
            // ColumnPrice
            // 
            this.ColumnPrice.HeaderText = "ColumnPrice";
            this.ColumnPrice.Name = "ColumnPrice";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.dataGridViewPesticides);
            this.groupBox6.Location = new System.Drawing.Point(678, 20);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(455, 190);
            this.groupBox6.TabIndex = 3;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Pesticides";
            // 
            // dataGridViewPesticides
            // 
            this.dataGridViewPesticides.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPesticides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnPest});
            this.dataGridViewPesticides.Location = new System.Drawing.Point(12, 19);
            this.dataGridViewPesticides.Name = "dataGridViewPesticides";
            this.dataGridViewPesticides.Size = new System.Drawing.Size(437, 160);
            this.dataGridViewPesticides.TabIndex = 1;
            // 
            // ColumnPest
            // 
            this.ColumnPest.HeaderText = "ColumnPest";
            this.ColumnPest.Name = "ColumnPest";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.dateTimePickerReapEnd);
            this.groupBox3.Controls.Add(this.dateTimePickerReapStart);
            this.groupBox3.Location = new System.Drawing.Point(344, 20);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 190);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Reaping Times";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Start Date";
            // 
            // dateTimePickerReapEnd
            // 
            this.dateTimePickerReapEnd.Location = new System.Drawing.Point(66, 82);
            this.dateTimePickerReapEnd.Name = "dateTimePickerReapEnd";
            this.dateTimePickerReapEnd.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerReapEnd.TabIndex = 3;
            // 
            // dateTimePickerReapStart
            // 
            this.dateTimePickerReapStart.Location = new System.Drawing.Point(65, 36);
            this.dateTimePickerReapStart.Name = "dateTimePickerReapStart";
            this.dateTimePickerReapStart.Size = new System.Drawing.Size(210, 20);
            this.dateTimePickerReapStart.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dateTimePickerCultEnd);
            this.groupBox2.Controls.Add(this.dateTimePickerCultStart);
            this.groupBox2.Location = new System.Drawing.Point(7, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(313, 190);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sowing Times";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // dateTimePickerCultEnd
            // 
            this.dateTimePickerCultEnd.Location = new System.Drawing.Point(71, 82);
            this.dateTimePickerCultEnd.Name = "dateTimePickerCultEnd";
            this.dateTimePickerCultEnd.Size = new System.Drawing.Size(208, 20);
            this.dateTimePickerCultEnd.TabIndex = 1;
            // 
            // dateTimePickerCultStart
            // 
            this.dateTimePickerCultStart.Location = new System.Drawing.Point(70, 36);
            this.dateTimePickerCultStart.Name = "dateTimePickerCultStart";
            this.dateTimePickerCultStart.Size = new System.Drawing.Size(209, 20);
            this.dateTimePickerCultStart.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonIVR);
            this.groupBox5.Controls.Add(this.buttonSMS);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBoxPrice);
            this.groupBox5.Location = new System.Drawing.Point(538, 20);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(565, 95);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Pricing Information";
            // 
            // buttonIVR
            // 
            this.buttonIVR.Location = new System.Drawing.Point(465, 38);
            this.buttonIVR.Name = "buttonIVR";
            this.buttonIVR.Size = new System.Drawing.Size(94, 40);
            this.buttonIVR.TabIndex = 3;
            this.buttonIVR.Text = "Send as IVR";
            this.buttonIVR.UseVisualStyleBackColor = true;
            // 
            // buttonSMS
            // 
            this.buttonSMS.Location = new System.Drawing.Point(359, 38);
            this.buttonSMS.Name = "buttonSMS";
            this.buttonSMS.Size = new System.Drawing.Size(94, 40);
            this.buttonSMS.TabIndex = 2;
            this.buttonSMS.Text = "Send as SMS";
            this.buttonSMS.UseVisualStyleBackColor = true;
            this.buttonSMS.Click += new System.EventHandler(this.buttonSMS_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Price";
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(78, 38);
            this.textBoxPrice.Multiline = true;
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(265, 40);
            this.textBoxPrice.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(630, 578);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 46);
            this.button2.TabIndex = 5;
            this.button2.Text = "Add  / Edit Crop Mapping";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Crops";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(55, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Districts";
            // 
            // comboBoxDistricts
            // 
            this.comboBoxDistricts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDistricts.FormattingEnabled = true;
            this.comboBoxDistricts.Location = new System.Drawing.Point(109, 12);
            this.comboBoxDistricts.Name = "comboBoxDistricts";
            this.comboBoxDistricts.Size = new System.Drawing.Size(169, 21);
            this.comboBoxDistricts.TabIndex = 8;
            // 
            // Crop_Mapping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 742);
            this.Controls.Add(this.comboBoxDistricts);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnNewCrop);
            this.Controls.Add(this.comboBoxCrops);
            this.Name = "Crop_Mapping";
            this.Text = "Crop Mapping";
            this.Load += new System.EventHandler(this.Crop_Mapping_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFertilizers)).EndInit();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeeds)).EndInit();
            this.groupBox6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPesticides)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCrops;
        private System.Windows.Forms.Button btnNewCrop;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePickerReapEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerReapStart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerCultEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerCultStart;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboBoxDistricts;
        private System.Windows.Forms.DataGridView dataGridViewFertilizers;
        private System.Windows.Forms.DataGridView dataGridViewSeeds;
        private System.Windows.Forms.DataGridView dataGridViewPesticides;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPest;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnSeed;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnFerts;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnPrice;
        private System.Windows.Forms.Button buttonSMS;
        private System.Windows.Forms.Button buttonIVR;
    }
}