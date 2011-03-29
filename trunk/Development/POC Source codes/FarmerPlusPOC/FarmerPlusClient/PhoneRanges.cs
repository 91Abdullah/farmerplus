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
    public partial class PhoneRanges : Form
    {
        public int is_mobile = 0;
        public int phone_code_id = -1;
        public string phone_code = "";

        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public PhoneRanges()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            //Save and then
            List<Phone_Ranges> rangeList = new List<Phone_Ranges>();
            for( int i = 0 ; i <= this.dataGridViewPhoneRanges.Rows.Count - 2 ; i++)
            {
                Phone_Ranges range = new Phone_Ranges();
                range.Start_Range = this.dataGridViewPhoneRanges.Rows[i].Cells[0].Value.ToString();
                range.End_Range = this.dataGridViewPhoneRanges.Rows[i].Cells[1].Value.ToString();

                rangeList.Add(range);
            }

            commonServiceClient.DeleteAndInsertPhoneRanges(phone_code_id, int.Parse(this.comboBoxCity.SelectedValue.ToString()), rangeList.ToArray());

            this.Close();
        }

        private void comboBoxCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.comboBoxCity.Items.Count > 0)
            {
                this.dataGridViewPhoneRanges.DataSource = commonServiceClient.GetPhoneRanges(is_mobile, phone_code_id, int.Parse(this.comboBoxCity.SelectedValue.ToString())).Tables[0];
                //this.dataGridViewPhoneRanges.Columns[0].ReadOnly = true;
            }
        }

        private void PhoneRanges_Load(object sender, EventArgs e)
        {

            labelPhoneCode.Text = this.phone_code;

            if (this.is_mobile == 1)
            {
                lableVendorType.Text = "Cellular";
            }
            else
            {
                lableVendorType.Text = "Landline";
            }

            DataSet citiesDS = commonServiceClient.GetCitiesList();

            this.comboBoxCity.ValueMember = "ID";
            this.comboBoxCity.DisplayMember = "VALUE";
            this.comboBoxCity.DataSource = citiesDS.Tables[0];
            

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
