using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Practices.EnterpriseLibrary.Logging;
using Microsoft.Practices.EnterpriseLibrary.ExceptionHandling;


namespace FarmerPlusClient
{
    public partial class HelloWorld : Form
    {
        int countDownFactor = 5;
        //ServiceReference1.HelloWorldServiceClient webserviceClient = new FarmerPlusClient.ServiceReference1.HelloWorldServiceClient("FarmerPlus");

        public HelloWorld()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // this.lblMessage.Text = ((ServiceReference1.HelloWorldDAO)webserviceClient.GetHelloWorldMessage(1)).StrHelloWorldMessage;            
        }

        private void timerFader_Tick(object sender, EventArgs e)
        {
            if (countDownFactor == 0)
            {
                this.Close();
            }

            this.lblTimer.Text = countDownFactor.ToString();
            countDownFactor--;          
        }
    }
}
