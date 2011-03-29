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
    public partial class CMSLocation : Form
    {
        Form f;
        //private Panel buttonPanel = new Panel();
        //private DataGridView songsDataGridView = new DataGridView();
        //private Button addNewRowButton = new Button();
        //private Button deleteRowButton = new Button();

        public string recordedVoiceDistrict = "";
        public string recordedVoiceCity = "";
        
        
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public CMSLocation()
        {
            InitializeComponent();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // f = SetupLayout("There is Complaint SMS");            
            //f.ShowDialog();
           
            //SetupDataGridView();
            //PopulateDataGridView();

            PhoneRanges rangesDialogeBox = new PhoneRanges();
            rangesDialogeBox.is_mobile = this.comboBoxVendorType.SelectedItem.Equals("Cellular") ? 1 : 0;
            rangesDialogeBox.phone_code_id = int.Parse(this.comboBoxVendorCode.SelectedValue.ToString());
            rangesDialogeBox.phone_code = this.comboBoxVendorCode.Text;
            rangesDialogeBox.ShowDialog();

        }

       
       
        //private Form SetupLayout(string ComplaintSms)
        //{
        //    Form frm = new Form();

        //    Panel buttonPanel = new Panel();
        //    DataGridView songsDataGridView = new DataGridView();
        //    Button addNewRowButton = new Button();
        //    Button deleteRowButton = new Button();

        //    frm.AutoScaleDimensions = new System.Drawing.SizeF(160F, 230F);
        //    frm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        //    frm.Name = "frm_ComplaintMsg";
        //    //dimension is irrelevant at the moment
        //    frm.ClientSize = new System.Drawing.Size(600, 500);
        //    //the parent will be the current form
        //    //frm.MdiParent = this;
        //    //splash screen mode form, why not...
        //    frm.ControlBox = true;
        //    frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle
        //       .FixedSingle;
        //    frm.AutoSizeMode = System.Windows.Forms.AutoSizeMode
        //       .GrowAndShrink;
        //    frm.BackColor = System.Drawing.Color.LightGray;

        //    //frm.Size = new Size(600, 500);

        //    addNewRowButton.Text = "Add Row";
        //    addNewRowButton.Location = new Point(10, 10);
        //    addNewRowButton.Click += new EventHandler(addNewRowButton_Click);

        //    deleteRowButton.Text = "Delete Row";
        //    deleteRowButton.Location = new Point(100, 10);
        //    deleteRowButton.Click += new EventHandler(deleteRowButton_Click);

        //    buttonPanel.Controls.Add(addNewRowButton);
        //    buttonPanel.Controls.Add(deleteRowButton);
        //    buttonPanel.Height = 50;
        //    buttonPanel.Dock = DockStyle.Bottom;

        //    frm.Controls.Add(buttonPanel);
        //    frm.SuspendLayout();

           
        //    //////////////// Set Grid
        //    frm.Controls.Add(songsDataGridView);

        //    songsDataGridView.ColumnCount = 3;

        //    songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
        //    songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        //    songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
        //        new Font(songsDataGridView.Font, FontStyle.Bold);

        //    songsDataGridView.Name = "songsDataGridView";
        //    songsDataGridView.Location = new Point(8, 8);
        //    songsDataGridView.Size = new Size(500, 250);
        //    songsDataGridView.AutoSizeRowsMode =
        //        DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
        //    songsDataGridView.ColumnHeadersBorderStyle =
        //        DataGridViewHeaderBorderStyle.Single;
        //    songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
        //    songsDataGridView.GridColor = Color.Black;
        //    songsDataGridView.RowHeadersVisible = false;

        //    songsDataGridView.Columns[0].Name = "City";
        //    songsDataGridView.Columns[1].Name = "Start Range";
        //    songsDataGridView.Columns[2].Name = "End Range";
        //    //songsDataGridView.Columns[1].Name = "Track";
        //    //songsDataGridView.Columns[2].Name = "Title";
        //    //songsDataGridView.Columns[3].Name = "Artist";
        //    //songsDataGridView.Columns[4].Name = "Album";
        //    songsDataGridView.Columns[0].DefaultCellStyle.Font =
        //        new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

        //    songsDataGridView.SelectionMode =
        //        DataGridViewSelectionMode.FullRowSelect;
        //    songsDataGridView.MultiSelect = false;
        //    songsDataGridView.Dock = DockStyle.Fill;

        //    songsDataGridView.CellFormatting += new
        //        DataGridViewCellFormattingEventHandler(
        //        songsDataGridView_CellFormatting);
        //    ///////////


        //    /////////// populate rid///////
        ////    string[] row0 = { "11/22/1968", "29", "Revolution 9", 
        ////"Beatles", "The Beatles [White Album]" };
        ////    string[] row1 = { "1960", "6", "Fools Rush In", 
        ////"Frank Sinatra", "Nice 'N' Easy" };
        ////    string[] row2 = { "11/11/1971", "1", "One of These Days", 
        ////"Pink Floyd", "Meddle" };
        ////    string[] row3 = { "1988", "7", "Where Is My Mind?", 
        ////"Pixies", "Surfer Rosa" };
        ////    string[] row4 = { "5/1981", "9", "Can't Find My Mind", 
        ////"Cramps", "Psychedelic Jungle" };
        ////    string[] row5 = { "6/10/2003", "13", 
        ////"Scatterbrain. (As Dead As Leaves.)", 
        ////"Radiohead", "Hail to the Thief" };
        ////    string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };
        //    string[] row0 = { "Lahore", "31","39" };
        //    string[] row1 = { "Multan", "21 ","29" };
        //    string[] row2 = { "Muzaffargarh", "11","18" };
        //    string[] row3 = { "Sialkot", "01", "12" };
        //    string[] row4 = { "Faisalabad", "91","93" };
        //    string[] row5 = { "Jhang", "94", " 97" };
        //    string[] row6 = { "Kasur", "83"," 85" };

        //    songsDataGridView.Rows.Add(row0);
        //    songsDataGridView.Rows.Add(row1);
        //    songsDataGridView.Rows.Add(row2);
        //    songsDataGridView.Rows.Add(row3);
        //    songsDataGridView.Rows.Add(row4);
        //    songsDataGridView.Rows.Add(row5);
        //    songsDataGridView.Rows.Add(row6);

        //    songsDataGridView.Columns[0].DisplayIndex = 0;
        //    songsDataGridView.Columns[1].DisplayIndex = 1;
        //    songsDataGridView.Columns[2].DisplayIndex =2;
        //    //songsDataGridView.Columns[3].DisplayIndex = 1;
        //    //songsDataGridView.Columns[4].DisplayIndex = 2;
        //    //////////////////

        //    return frm;
        //}

        private void SetupDataGridView()
        {
            //frm.Controls.Add(songsDataGridView);

            //songsDataGridView.ColumnCount = 5;

            //songsDataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            //songsDataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            //songsDataGridView.ColumnHeadersDefaultCellStyle.Font =
            //    new Font(songsDataGridView.Font, FontStyle.Bold);

            //songsDataGridView.Name = "songsDataGridView";
            //songsDataGridView.Location = new Point(8, 8);
            //songsDataGridView.Size = new Size(500, 250);
            //songsDataGridView.AutoSizeRowsMode =
            //    DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            //songsDataGridView.ColumnHeadersBorderStyle =
            //    DataGridViewHeaderBorderStyle.Single;
            //songsDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.Single;
            //songsDataGridView.GridColor = Color.Black;
            //songsDataGridView.RowHeadersVisible = false;

            //songsDataGridView.Columns[0].Name = "Release Date";
            //songsDataGridView.Columns[1].Name = "Track";
            //songsDataGridView.Columns[2].Name = "Title";
            //songsDataGridView.Columns[3].Name = "Artist";
            //songsDataGridView.Columns[4].Name = "Album";
            //songsDataGridView.Columns[4].DefaultCellStyle.Font =
            //    new Font(songsDataGridView.DefaultCellStyle.Font, FontStyle.Italic);

            //songsDataGridView.SelectionMode =
            //    DataGridViewSelectionMode.FullRowSelect;
            //songsDataGridView.MultiSelect = false;
            //songsDataGridView.Dock = DockStyle.Fill;

            //songsDataGridView.CellFormatting += new
            //    DataGridViewCellFormattingEventHandler(
            //    songsDataGridView_CellFormatting);

            
        }
        private void PopulateDataGridView()
        {

        //    string[] row0 = { "11/22/1968", "29", "Revolution 9", 
        //"Beatles", "The Beatles [White Album]" };
        //    string[] row1 = { "1960", "6", "Fools Rush In", 
        //"Frank Sinatra", "Nice 'N' Easy" };
        //    string[] row2 = { "11/11/1971", "1", "One of These Days", 
        //"Pink Floyd", "Meddle" };
        //    string[] row3 = { "1988", "7", "Where Is My Mind?", 
        //"Pixies", "Surfer Rosa" };
        //    string[] row4 = { "5/1981", "9", "Can't Find My Mind", 
        //"Cramps", "Psychedelic Jungle" };
        //    string[] row5 = { "6/10/2003", "13", 
        //"Scatterbrain. (As Dead As Leaves.)", 
        //"Radiohead", "Hail to the Thief" };
        //    string[] row6 = { "6/30/1992", "3", "Dress", "P J Harvey", "Dry" };

        //    songsDataGridView.Rows.Add(row0);
        //    songsDataGridView.Rows.Add(row1);
        //    songsDataGridView.Rows.Add(row2);
        //    songsDataGridView.Rows.Add(row3);
        //    songsDataGridView.Rows.Add(row4);
        //    songsDataGridView.Rows.Add(row5);
        //    songsDataGridView.Rows.Add(row6);

        //    songsDataGridView.Columns[0].DisplayIndex = 3;
        //    songsDataGridView.Columns[1].DisplayIndex = 4;
        //    songsDataGridView.Columns[2].DisplayIndex = 0;
        //    songsDataGridView.Columns[3].DisplayIndex = 1;
        //    songsDataGridView.Columns[4].DisplayIndex = 2;
        }

        private void songsDataGridView_CellFormatting(object sender,
    System.Windows.Forms.DataGridViewCellFormattingEventArgs e)
        {
            //if (e != null)
            //{
            //    if (this.songsDataGridView.Columns[e.ColumnIndex].Name == "Release Date")
            //    {
            //        if (e.Value != null)
            //        {
            //            try
            //            {
            //                e.Value = DateTime.Parse(e.Value.ToString())
            //                    .ToLongDateString();
            //                e.FormattingApplied = true;
            //            }
            //            catch (FormatException)
            //            {
            //                Console.WriteLine("{0} is not a valid date.", e.Value.ToString());
            //            }
            //        }
            //    }
            //}
        }

        private void addNewRowButton_Click(object sender, EventArgs e)
        {
           
            //this.songsDataGridView.Rows.Add();
        }

        private void deleteRowButton_Click(object sender, EventArgs e)
        {
            //if (this.songsDataGridView.SelectedRows.Count > 0 &&
            //    this.songsDataGridView.SelectedRows[0].Index !=
            //    this.songsDataGridView.Rows.Count - 1)
            //{
            //    this.songsDataGridView.Rows.RemoveAt(
            //        this.songsDataGridView.SelectedRows[0].Index);
            //}
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void CMSLocation_Load(object sender, EventArgs e)
        {
            this.comboBoxDistrict.DataSource = commonServiceClient.GetDistrictsList().Tables[0];
            this.comboBoxDistrict.ValueMember = "ID";
            this.comboBoxDistrict.DisplayMember = "VALUE";

            this.comboBoxVendorType.SelectedIndex = 0;

            this.comboBoxVendorCode.DataSource = commonServiceClient.GetVendorCodes(1).Tables[0];
            this.comboBoxVendorCode.ValueMember = "ID";
            this.comboBoxVendorCode.DisplayMember = "VALUE";
            

        }

        private void buttonSaveDistricct_Click(object sender, EventArgs e)
        {
            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoiceDistrict, this.textBoxDistrictUrdu.Text);

            commonServiceClient.InsertInDistricts(this.textBoxDistrictName.Text, semantics_id);

            this.comboBoxDistrict.DataSource = commonServiceClient.GetDistrictsList().Tables[0];
            this.comboBoxDistrict.ValueMember = "ID";
            this.comboBoxDistrict.DisplayMember = "VALUE";            
        }

        private void buttonSaveCity_Click(object sender, EventArgs e)
        {
            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoiceCity, this.textBoxCityUrdu.Text);

            commonServiceClient.InsertInCities(this.textBoxCityName.Text, int.Parse(this.comboBoxDistrict.SelectedValue.ToString()), semantics_id);            
        }

        private void buttonSavePhoneCode_Click(object sender, EventArgs e)
        {
            if (comboBoxVendorCode.SelectedIndex == -1)
            {
                if (this.comboBoxVendorType.SelectedItem.Equals("Cellular"))
                {
                    commonServiceClient.CreateVendorCode(this.comboBoxVendorCode.Text, 1);
                }
                else
                {
                    commonServiceClient.CreateVendorCode(this.comboBoxVendorCode.Text, 0);
                }

                this.comboBoxVendorType.SelectedIndex = 0;

                
            }
            
        }

        private void comboBoxVendorType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxVendorType.SelectedIndex == 0) // Mobile
            {
                this.comboBoxVendorCode.DataSource = commonServiceClient.GetVendorCodes(1).Tables[0];
                this.comboBoxVendorCode.ValueMember = "ID";
                this.comboBoxVendorCode.DisplayMember = "VALUE";
            }
            else // Landline
            {
                this.comboBoxVendorCode.DataSource = commonServiceClient.GetVendorCodes(0).Tables[0];
                this.comboBoxVendorCode.ValueMember = "ID";
                this.comboBoxVendorCode.DisplayMember = "VALUE"; 
            }
            
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoiceDistrict = recorder.filePathToReturn;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoiceCity = recorder.filePathToReturn;
        }

     










    }
}
