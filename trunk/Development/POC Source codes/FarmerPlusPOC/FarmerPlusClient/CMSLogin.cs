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
    public partial class CMSLogin : Form
    {
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new ServiceReferenceCommonHelper.CommonHelperServiceClient();

        public CMSLogin()
        {
            InitializeComponent();
        }

        private void  btnLogin_Click(object sender, EventArgs e)
        {
           // picboxLogin.Image = Properties.Resources.unlock;

            if (commonServiceClient.GetLoginInfor(this.txtUser.Text.Trim(), this.txtPass.Text.Trim()).Tables[0].Rows.Count <= 0)
            {
                lblError.Text = "Invalid Username / Password. Please Try Again";
                lblError.Visible = true;
            }
            else
            {
                this.Hide();
            }           
          
        }

        private void  btnCancel_Click(object sender, EventArgs e)
        {
                     
            Application.Exit();

        }

        private void CMSLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void CMSLogin_Load(object sender, EventArgs e)
        {

        }

       
        
   
    }
}
