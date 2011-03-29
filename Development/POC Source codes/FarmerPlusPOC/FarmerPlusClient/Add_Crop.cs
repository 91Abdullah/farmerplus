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
    public partial class Add_Crop : Form
    {
        public string recordedVoice = "";
        
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();
        public Add_Crop()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int crop_group_id = commonServiceClient.GetLookupGroupId("Crop");

            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoice, this.textBoxUrduName.Text);

            commonServiceClient.InsertInLookup(this.textBoxName.Text, crop_group_id, semantics_id);

            this.Close();
        }

        private void Add_Crop_Load(object sender, EventArgs e)
        {

        }

        private void buttonRecord_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoice = recorder.filePathToReturn;
        }
    }
}
