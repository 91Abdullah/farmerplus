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
    public partial class Add_Seed : Form
    {
        public string recordedVoice = "";
        ServiceReferenceCropCommonHelper.CropHelperServicesClient cropServiceClient = new ServiceReferenceCropCommonHelper.CropHelperServicesClient();
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public Add_Seed()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoice, this.textBoxUrdu.Text);

            cropServiceClient.InsertSeedInformation(this.textBoxName.Text, semantics_id);

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
