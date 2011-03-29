using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace FarmerPlusClient
{
    public partial class CMSMainForm : Form
    {
        private int childFormNumber = 0;

        public CMSMainForm()
        {
         
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }



        private void CMSMainForm_Load(object sender, EventArgs e)
        {

            userAuthentication();
               
          


        }

        public void userAuthentication()
        {
            CMSLogin  UserLogin = new CMSLogin();
            UserLogin.ShowDialog();     

        }

        public void childFromLoad(Form xForm)
        {
             
             
            foreach (Form childForm in this.MdiChildren)
            {
                if (childForm.GetType() == xForm.GetType())
                {
                    childForm.Focus();

                MessageBox.Show("Already Active");                   
                    return;
                }                
            }

            //xForm = new xForm.Name();

            xForm.MdiParent = this;
            xForm.WindowState = FormWindowState.Maximized;
            xForm.Show();
        
        }
     
        private void complaintsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childFromLoad(new CMSComplaintLog());
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            childFromLoad(new CMSWarningManager());
        }

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            childFromLoad(new CMSLocation());
        }

        private void cropMappingToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            childFromLoad( new Crop_Mapping());
        }

        private void addNewCropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Crop cropForm = new Add_Crop();
            cropForm.ShowDialog();
        }

        private void addCompanyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Company companyForm = new Add_Company();
            companyForm.ShowDialog();
        }

        private void addNewSeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Seed seedForm = new Add_Seed();
            seedForm.ShowDialog();
        }

        private void addNewPesticideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Pesticide pesticideForm = new Add_Pesticide();
            pesticideForm.ShowDialog();
        }

        private void addNewFertilizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_Fertilizer fertilizerForm = new Add_Fertilizer();
            fertilizerForm.ShowDialog();
        }

        private void addNewAgriEquipmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Add_AgriEquipment agriEquipmentForm = new Add_AgriEquipment();
            agriEquipmentForm.ShowDialog();
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            string abc = recorder.filePathToReturn;
        }
       
    }
  
    }
