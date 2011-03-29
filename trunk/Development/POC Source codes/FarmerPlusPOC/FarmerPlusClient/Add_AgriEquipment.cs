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
    public partial class Add_AgriEquipment : Form
    {
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public string recordedVoice = "";

        public Add_AgriEquipment()
        {
            InitializeComponent();
        }

        private void button2Save_Click(object sender, EventArgs e)
        {
            int agriequipLKPID = 0;



            if (comboBoxAgriEquipment.SelectedIndex == -1)
            {
                int Agri_Equip_group_id = commonServiceClient.GetLookupGroupId("AgriEquipment");

                int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoice, this.textBoxUrdu.Text);

                agriequipLKPID = commonServiceClient.InsertInLookup(this.comboBoxAgriEquipment.Text, Agri_Equip_group_id, semantics_id);
            }
            else
            {
                agriequipLKPID = int.Parse(this.comboBoxAgriEquipment.SelectedValue.ToString());
            }

            

            commonServiceClient.InsertInAgriEquipmentMapping(agriequipLKPID, int.Parse(this.comboBoxCity.SelectedValue.ToString()),
                int.Parse(this.comboBoxCompany.SelectedValue.ToString()), int.Parse(this.textBoxPrice.Text));

            this.Close();
        }

        private void buttonNewCompany_Click(object sender, EventArgs e)
        {
            Add_Company companyForm = new Add_Company();
            companyForm.ShowDialog();

            DataSet companiesDS = commonServiceClient.GetCompaniesList();
            this.comboBoxCompany.DataSource = companiesDS.Tables[0];
            this.comboBoxCompany.ValueMember = "ID";
            this.comboBoxCompany.DisplayMember = "VALUE";

            
        }

        private void Add_AgriEquipment_Load(object sender, EventArgs e)
        {
            DataSet companiesDS =  commonServiceClient.GetCompaniesList();
            DataSet afriEquipDS = commonServiceClient.GetLookupList("AgriEquipment");
            DataSet citiesDS = commonServiceClient.GetCitiesList();

            this.comboBoxAgriEquipment.DataSource = afriEquipDS.Tables[0];
            this.comboBoxAgriEquipment.ValueMember = "ID";
            this.comboBoxAgriEquipment.DisplayMember = "VALUE";

            this.comboBoxCity.DataSource = citiesDS.Tables[0];
            this.comboBoxCity.ValueMember = "ID";
            this.comboBoxCity.DisplayMember = "VALUE";

            this.comboBoxCompany.DataSource = companiesDS.Tables[0];
            this.comboBoxCompany.ValueMember = "ID";
            this.comboBoxCompany.DisplayMember = "VALUE";

        }

        private void buttonRecordVoice_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoice = recorder.filePathToReturn;
        }
    }
}
