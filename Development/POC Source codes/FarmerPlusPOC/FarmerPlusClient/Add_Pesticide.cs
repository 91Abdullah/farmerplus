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
    public partial class Add_Pesticide : Form
    {
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();
        public string recordedVoice = "";
        public Add_Pesticide()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int pesticide_group_id = commonServiceClient.GetLookupGroupId("Pesticide");

            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoice, this.textBoxUrdu.Text);

            commonServiceClient.InsertInLookup(this.textBoxName.Text, pesticide_group_id, semantics_id);

            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoice = recorder.filePathToReturn;
        }

        private void Add_Pesticide_Load(object sender, EventArgs e)
        {

        }
    }
}
