﻿namespace FarmerPlusClient
{
    partial class CMSMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CMSMainForm));
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.profilingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.locationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cropMappingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewSeedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewPesticideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewFertilizerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewAgriEquipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCompanyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.announcementToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.newWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.sMSSimulatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(882, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // profilingToolStripMenuItem
            // 
            this.profilingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locationToolStripMenuItem,
            this.cropMappingToolStripMenuItem,
            this.addNewCropToolStripMenuItem,
            this.addNewSeedToolStripMenuItem,
            this.addNewPesticideToolStripMenuItem,
            this.addNewFertilizerToolStripMenuItem,
            this.addNewAgriEquipmentToolStripMenuItem,
            this.addCompanyToolStripMenuItem});
            this.profilingToolStripMenuItem.Name = "profilingToolStripMenuItem";
            this.profilingToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.profilingToolStripMenuItem.Text = "&Profiling";
            // 
            // locationToolStripMenuItem
            // 
            this.locationToolStripMenuItem.Name = "locationToolStripMenuItem";
            this.locationToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.locationToolStripMenuItem.Text = "&Location Profile";
            this.locationToolStripMenuItem.Click += new System.EventHandler(this.locationToolStripMenuItem_Click);
            // 
            // cropMappingToolStripMenuItem
            // 
            this.cropMappingToolStripMenuItem.Name = "cropMappingToolStripMenuItem";
            this.cropMappingToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.cropMappingToolStripMenuItem.Text = "&Crop Profile";
            this.cropMappingToolStripMenuItem.Click += new System.EventHandler(this.cropMappingToolStripMenuItem_Click);
            // 
            // addNewCropToolStripMenuItem
            // 
            this.addNewCropToolStripMenuItem.Name = "addNewCropToolStripMenuItem";
            this.addNewCropToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewCropToolStripMenuItem.Text = "&Add New Crop";
            this.addNewCropToolStripMenuItem.Click += new System.EventHandler(this.addNewCropToolStripMenuItem_Click);
            // 
            // addNewSeedToolStripMenuItem
            // 
            this.addNewSeedToolStripMenuItem.Name = "addNewSeedToolStripMenuItem";
            this.addNewSeedToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewSeedToolStripMenuItem.Text = "Add New &Seed";
            this.addNewSeedToolStripMenuItem.Click += new System.EventHandler(this.addNewSeedToolStripMenuItem_Click);
            // 
            // addNewPesticideToolStripMenuItem
            // 
            this.addNewPesticideToolStripMenuItem.Name = "addNewPesticideToolStripMenuItem";
            this.addNewPesticideToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewPesticideToolStripMenuItem.Text = "Add New &Pesticide";
            this.addNewPesticideToolStripMenuItem.Click += new System.EventHandler(this.addNewPesticideToolStripMenuItem_Click);
            // 
            // addNewFertilizerToolStripMenuItem
            // 
            this.addNewFertilizerToolStripMenuItem.Name = "addNewFertilizerToolStripMenuItem";
            this.addNewFertilizerToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewFertilizerToolStripMenuItem.Text = "Add New &Fertilizer";
            this.addNewFertilizerToolStripMenuItem.Click += new System.EventHandler(this.addNewFertilizerToolStripMenuItem_Click);
            // 
            // addNewAgriEquipmentToolStripMenuItem
            // 
            this.addNewAgriEquipmentToolStripMenuItem.Name = "addNewAgriEquipmentToolStripMenuItem";
            this.addNewAgriEquipmentToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addNewAgriEquipmentToolStripMenuItem.Text = "Add New Agri &Equipment";
            this.addNewAgriEquipmentToolStripMenuItem.Click += new System.EventHandler(this.addNewAgriEquipmentToolStripMenuItem_Click);
            // 
            // addCompanyToolStripMenuItem
            // 
            this.addCompanyToolStripMenuItem.Name = "addCompanyToolStripMenuItem";
            this.addCompanyToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.addCompanyToolStripMenuItem.Text = "Add Co&mpany";
            this.addCompanyToolStripMenuItem.Click += new System.EventHandler(this.addCompanyToolStripMenuItem_Click);
            // 
            // complaintsToolStripMenuItem
            // 
            this.complaintsToolStripMenuItem.Name = "complaintsToolStripMenuItem";
            this.complaintsToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.complaintsToolStripMenuItem.Text = "&Complaints";
            this.complaintsToolStripMenuItem.Click += new System.EventHandler(this.complaintsToolStripMenuItem_Click);
            // 
            // announcementToolStripMenuItem4
            // 
            this.announcementToolStripMenuItem4.Name = "announcementToolStripMenuItem4";
            this.announcementToolStripMenuItem4.Size = new System.Drawing.Size(102, 20);
            this.announcementToolStripMenuItem4.Text = "&Announcement";
            this.announcementToolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.sMSSimulatorToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(48, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Test Recorder";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newWindowToolStripMenuItem,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // newWindowToolStripMenuItem
            // 
            this.newWindowToolStripMenuItem.Name = "newWindowToolStripMenuItem";
            this.newWindowToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.newWindowToolStripMenuItem.Text = "&New Window";
            this.newWindowToolStripMenuItem.Click += new System.EventHandler(this.ShowNewForm);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.arrangeIconsToolStripMenuItem.Text = "&Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.ArrangeIconsToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(165, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilingToolStripMenuItem,
            this.complaintsToolStripMenuItem,
            this.announcementToolStripMenuItem4,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(882, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "Farmer Plus";
            // 
            // sMSSimulatorToolStripMenuItem
            // 
            this.sMSSimulatorToolStripMenuItem.Name = "sMSSimulatorToolStripMenuItem";
            this.sMSSimulatorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sMSSimulatorToolStripMenuItem.Text = "&SMS Simulator";
            this.sMSSimulatorToolStripMenuItem.Click += new System.EventHandler(this.sMSSimulatorToolStripMenuItem_Click);
            // 
            // CMSMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CMSMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Farmer Plus";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.CMSMainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem profilingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem locationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cropMappingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewSeedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewPesticideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewFertilizerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewAgriEquipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCompanyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem complaintsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem announcementToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem newWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem sMSSimulatorToolStripMenuItem;
    }
}



