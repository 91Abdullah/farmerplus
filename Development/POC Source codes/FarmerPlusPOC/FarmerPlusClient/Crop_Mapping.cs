using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmerPlusDataObjectLayer;


namespace FarmerPlusClient
{
    public partial class Crop_Mapping : Form
    {

        ServiceReferenceCropCommonHelper.CropHelperServicesClient cropServiceClient = new ServiceReferenceCropCommonHelper.CropHelperServicesClient();
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new ServiceReferenceCommonHelper.CommonHelperServiceClient();


        int crop_mapping_id = -1;
        DateTime reaping_start_date = DateTime.Today;
        DateTime reaping_end_date = DateTime.Today;
        DateTime cult_start_date = DateTime.Today;
        DateTime cult_end_date = DateTime.Today;
        float price = 0;

        public Crop_Mapping()
        {
            InitializeComponent();
        }

        private void btnNewCrop_Click(object sender, EventArgs e)
        {
            Add_Crop adCrop = new Add_Crop();
            adCrop.ShowDialog();
        }

        private void Crop_Mapping_Load(object sender, EventArgs e)
        {


            //this.listBoxPesticides.ValueMember = "ColumnPest";
            //this.listBoxPesticides.DisplayMember = "VALUE";
            //this.listBoxPesticides.DataSource = commonServiceClient.GetLookupList("Pesticide").Tables[0];

            //this.listBoxFertilizers.ValueMember = "ID";
            //this.listBoxFertilizers.DisplayMember = "VALUE";
            //this.listBoxFertilizers.DataSource = commonServiceClient.GetLookupList("Fertilizer").Tables[0];

            //this.listBoxSeeds.ValueMember = "ID";
            //this.listBoxSeeds.DisplayMember = "VALUE";
            //this.listBoxSeeds.DataSource = cropServiceClient.GetSeeds().Tables[0];

            this.comboBoxDistricts.ValueMember = "ID";
            this.comboBoxDistricts.DisplayMember = "VALUE";
            this.comboBoxDistricts.DataSource = commonServiceClient.GetDistrictsList().Tables[0];

            this.comboBoxCrops.ValueMember = "ID";
            this.comboBoxCrops.DisplayMember = "VALUE";
            this.comboBoxCrops.DataSource = commonServiceClient.GetLookupList("Crop").Tables[0];

            

            

            //this.dataGridViewPesticides.DataSource = crop
            

            //DataSet ds = cropServiceClient.GetCropMappingId(int.Parse(this.comboBoxDistricts.SelectedValue.ToString()), int.Parse(this.comboBoxCrops.SelectedValue.ToString()));

            //if (ds.Tables.Count > 0)
            //{
            //    crop_mapping_id = int.Parse(ds.Tables[0].Rows[0][0].ToString());

            //    price = int.Parse(ds.Tables[0].Rows[0][1].ToString());

            //    reaping_start_date = DateTime.Parse(ds.Tables[0].Rows[0][2].ToString());
            //    reaping_end_date = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString());
            //    cult_start_date = DateTime.Parse(ds.Tables[0].Rows[0][4].ToString());
            //    cult_end_date = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());
            //}           
            
        }



        private void comboBoxCrops_SelectedIndexChanged(object sender, EventArgs e)
        {
            

            this.ColumnPest.ValueMember = "ID";
            this.ColumnPest.DisplayMember = "VALUE";
            this.ColumnPest.DataSource = commonServiceClient.GetLookupList("Pesticide").Tables[0];

            this.ColumnSeed.ValueMember = "ID";
            this.ColumnSeed.DisplayMember = "VALUE";
            this.ColumnSeed.DataSource = cropServiceClient.GetSeeds().Tables[0];

            this.ColumnFerts.ValueMember = "ID";
            this.ColumnFerts.DisplayMember = "VALUE";
            this.ColumnFerts.DataSource = commonServiceClient.GetLookupList("Fertilizer").Tables[0];

            this.dataGridViewFertilizers.Columns.Clear();
            this.dataGridViewSeeds.Columns.Clear();
            this.dataGridViewPesticides.Columns.Clear();

            if (this.dataGridViewFertilizers.Columns.Count == 0)
            {

                this.dataGridViewFertilizers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnFerts});
            }

            if (this.dataGridViewSeeds.Columns.Count == 0)
            {
                this.dataGridViewSeeds.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnSeed/*,
                this.ColumnPrice*/});

            //    this.ColumnSeed.Frozen = true;
              //  this.ColumnPrice.Frozen = true;
            }

            if (this.dataGridViewPesticides.Columns.Count == 0)
            {
                this.dataGridViewPesticides.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.ColumnPest});
            }

            DataSet ds = cropServiceClient.GetCropMappingId(int.Parse(this.comboBoxDistricts.SelectedValue.ToString()), int.Parse(this.comboBoxCrops.SelectedValue.ToString()));

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                crop_mapping_id = int.Parse(ds.Tables[0].Rows[0][0].ToString());

                price = int.Parse(ds.Tables[0].Rows[0][1].ToString());

                reaping_start_date = DateTime.Parse(ds.Tables[0].Rows[0][2].ToString());
                reaping_end_date = DateTime.Parse(ds.Tables[0].Rows[0][3].ToString());
                cult_start_date = DateTime.Parse(ds.Tables[0].Rows[0][4].ToString());
                cult_end_date = DateTime.Parse(ds.Tables[0].Rows[0][5].ToString());                
            }
            else
            {
                crop_mapping_id = -1;

                price = 0;

                reaping_start_date = DateTime.Today;
                reaping_end_date = DateTime.Today;
                cult_start_date = DateTime.Today;
                cult_end_date = DateTime.Today;
            }

            DataTable dataTablePesticides = cropServiceClient.GetPesticidesForaCropMapping(crop_mapping_id).Tables[0];
            DataTable dataTableFertilizers = cropServiceClient.GetFertilizersForaCropMapping(crop_mapping_id).Tables[0];
            DataTable dataTableSeeds = cropServiceClient.GetSeedsForaCropMapping(crop_mapping_id).Tables[0];


            this.dataGridViewPesticides.DataSource = dataTablePesticides;
            this.dataGridViewPesticides.Columns[0].DataPropertyName = "pestId";

            //this.dataGridViewPesticides.Columns[1].Visible = false;
            //this.dataGridViewPesticides.Columns[2].Visible = false;
            //this.dataGridViewPesticides.Columns[3].Visible = false;


            this.dataGridViewFertilizers.DataSource = dataTableFertilizers;
            this.dataGridViewFertilizers.Columns[0].DataPropertyName = "fertId";
            //this.dataGridViewFertilizers.Columns[1].Visible = false;
            //this.dataGridViewFertilizers.Columns[2].Visible = false;
            //this.dataGridViewFertilizers.Columns[3].Visible = false;


            this.dataGridViewSeeds.DataSource = dataTableSeeds;
            this.dataGridViewSeeds.Columns[0].DataPropertyName = "seedId";
            //this.dataGridViewSeeds.Columns[1].DataPropertyName = "price";

            //DataGridViewColumn columnSeedtemp =  this.dataGridViewSeeds.Columns[3];
            //this.dataGridViewSeeds.Columns.RemoveAt(3);
            //this.dataGridViewSeeds.Columns.Insert(0, columnSeedtemp);
            
            //this.dataGridViewSeeds.Columns[2].Visible = false;
            //this.dataGridViewSeeds.Columns[3].Visible = false;
            //this.dataGridViewSeeds.Columns[4].Visible = false;
            //this.dataGridViewSeeds.Columns[5].Visible = false;

           

            this.textBoxPrice.Text = price.ToString();
            this.dateTimePickerReapStart.Value = reaping_start_date;
            this.dateTimePickerReapEnd.Value = reaping_end_date;
            this.dateTimePickerCultStart.Value = cult_start_date;
            this.dateTimePickerCultEnd.Value = cult_end_date;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            crop_mapping_id = cropServiceClient.InsertOrUpdateCropMapping(crop_mapping_id, int.Parse(this.textBoxPrice.Text), this.dateTimePickerReapStart.Value.ToShortDateString(), this.dateTimePickerReapEnd.Value.ToShortDateString(), this.dateTimePickerCultStart.Value.ToShortDateString(),
                this.dateTimePickerCultEnd.Value.ToShortDateString(), int.Parse(this.comboBoxDistricts.SelectedValue.ToString()), int.Parse(this.comboBoxCrops.SelectedValue.ToString()));

            List<Crop_attributes> listPests = new List<Crop_attributes>();
            List<Crop_attributes> listFerts = new List<Crop_attributes>();
            List<Crop_attributes> listSeeds = new List<Crop_attributes>();


            for (int i = 0; i < this.dataGridViewPesticides.Rows.Count - 1; i ++ )                
                {
                    Crop_attributes ca = new Crop_attributes();
                    ca.attribute_lkp_id = int.Parse(this.dataGridViewPesticides.Rows[i].Cells[0].Value.ToString());
                    listPests.Add(ca);
                }

            for (int i = 0; i < this.dataGridViewFertilizers.Rows.Count - 1; i++)
            {
                Crop_attributes ca = new Crop_attributes();
                ca.attribute_lkp_id = int.Parse(this.dataGridViewFertilizers.Rows[i].Cells[0].Value.ToString());
                listFerts.Add(ca);
            }

            for (int i = 0; i < this.dataGridViewSeeds.Rows.Count - 1; i++)
            {
                Crop_attributes ca = new Crop_attributes();
                ca.attribute_lkp_id = int.Parse(this.dataGridViewSeeds.Rows[i].Cells[0].Value.ToString());
                ca.price = int.Parse(this.dataGridViewSeeds.Rows[i].Cells["price"].Value.ToString());
                listSeeds.Add(ca);
            }

            cropServiceClient.DeleteAndInsertPesticideAttributes(listPests.ToArray(), crop_mapping_id);
            cropServiceClient.DeleteAndInsertFertilizerAttributes(listFerts.ToArray(), crop_mapping_id);
            cropServiceClient.DeleteAndInsertSeedAttributes(listSeeds.ToArray(), crop_mapping_id);

        }

        private void listBoxFertilizers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonSMS_Click(object sender, EventArgs e)
        {

            FarmerPlusSMS.SMS_Manager manager = new FarmerPlusSMS.SMS_Manager();
            DataTable phoneNumbers = commonServiceClient.GetCallerOfADistrict(int.Parse(this.comboBoxDistricts.SelectedValue.ToString())).Tables[0];

            foreach (DataRow rowWalker in phoneNumbers.Rows)
            {
                string urduCrop = commonServiceClient.GetUrduNameOfALookupId(int.Parse(this.comboBoxCrops.SelectedValue.ToString()));
                manager.ThrowSms(urduCrop + "کی موجودہ قیمت" + this.textBoxPrice.Text + "روپے ", rowWalker[0].ToString());
            }
            
           
        }

      
        
        
    }
}
