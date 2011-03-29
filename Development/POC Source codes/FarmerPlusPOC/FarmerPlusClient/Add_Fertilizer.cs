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
    public partial class Add_Fertilizer : Form
    {
        public string recordedVoice = "";
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public Add_Fertilizer()
        {
            InitializeComponent();
        }

        private void Add_Fertilizer_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            int fertilizer_group_id = commonServiceClient.GetLookupGroupId("Fertilizer");

            int semantics_id = commonServiceClient.InsertAndGetSemantics(recordedVoice, this.textBoxUrdu.Text);

            commonServiceClient.InsertInLookup(this.textBoxName.Text, fertilizer_group_id, semantics_id);

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
