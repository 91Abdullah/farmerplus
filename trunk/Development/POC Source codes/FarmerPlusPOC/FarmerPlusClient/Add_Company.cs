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
    public partial class Add_Company : Form
    {
        public string recordedVoice = "";
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public Add_Company()
        {
            InitializeComponent();
        }

        private void Add_Company_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoice, this.textBoxUrdu.Text);

            commonServiceClient.InsertCompany(this.textBoxCompanyName.Text, this.textBoxContactNumber.Text, semantics_id);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoice = recorder.filePathToReturn;
        }

       
    }
}
