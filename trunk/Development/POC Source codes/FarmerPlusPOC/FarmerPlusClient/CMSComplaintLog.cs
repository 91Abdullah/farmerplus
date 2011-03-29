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
    public partial class CMSComplaintLog : Form
    {
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();
        

        //DataTable table;
        //DataRow row;
        public CMSComplaintLog()
        {
            InitializeComponent();
        }

        private void CMSComplaintLog_Load(object sender, EventArgs e)
        {
            this.comboBoxCategory.DataSource = commonServiceClient.GetLookupList("ComplaintCategory").Tables[0];
            this.comboBoxCategory.DisplayMember = "VALUE";
            this.comboBoxCategory.ValueMember = "ID";


            this.comboBoxService.DataSource = commonServiceClient.GetLookupList("ApplicationType").Tables[0];
            this.comboBoxService.DisplayMember = "VALUE";
            this.comboBoxService.ValueMember = "ID";
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            this.dataGridComplaints.DataSource = commonServiceClient.GetComplaints(int.Parse(this.comboBoxService.SelectedValue.ToString()), int.Parse(this.comboBoxCategory.SelectedValue.ToString())).Tables[0];
        }

        private void dataGridComplaints_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            if (this.dataGridComplaints.SelectedRows.Count > 0)
            {
                
                this.textBoxFollowup.Text = commonServiceClient.GetComplaintFollowup(int.Parse(this.dataGridComplaints.SelectedRows[0].Cells[0].Value.ToString()));
            }
        }

        private void textBoxFollowup_leave(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.dataGridComplaints.SelectedRows.Count > 0)
            {
                commonServiceClient.UpdateComplaintFolloup(int.Parse(this.dataGridComplaints.SelectedRows[0].Cells[0].Value.ToString()), this.textBoxFollowup.Text);
            }
        }

  //      private void groupBoxComplaintLog_Enter(object sender, EventArgs e)
  //      {
  //     //   AddtoGrid();
            
  //     dataGridComplaints.DataSource =CreateDataSource();


  //          DataGridViewButtonColumn dcButton = new DataGridViewButtonColumn();
  //          dcButton.HeaderText = "Complaints";
  //          dcButton.UseColumnTextForButtonValue = true;
  //          dcButton.Text = "Play";

  //         dataGridComplaints.Columns.Add(dcButton); 
  //         //dataGridComplaints.DataBind();
  //      }

  //      DataView CreateDataSource()
  //      {
  //          DataTable dt = new DataTable();
  //          DataRow dr;

  //          dt.Columns.Add(new DataColumn("Complaint #", typeof(string)));
  //          dt.Columns.Add(new DataColumn("City", typeof(string)));
  //          dt.Columns.Add(new DataColumn("Phone", typeof(string)));
  //          dt.Columns.Add(new DataColumn("Follow Up", typeof(string)));
            
             
  //          for (int i = 1; i < 7; i++)
  //          {
  //              dr = dt.NewRow();
               
  //                  dr[0] = "COMP-000" + i;
  //                  dr[1] = "Lahore";
  //                  dr[2] = "0300" + i + (i * 150) + (i * 120);
  //                  dr[3] = "Pending";
               

  //              dt.Rows.Add(dr);
  //          }

  //          DataView dv = new DataView(dt);
           

  //          return dv;
  //      }
  //      void AddtoGrid()  
  //      { 
  //          try 
  //          {  
  //              table = new DataTable();
                
  //             // bcol = new DataGridViewButtonColumn();   
  //             // bcol.HeaderText = "Action ";   
  //             // bcol.Text = "Delete";  
  //             // bcol.Name = "deleteUserButton";   
  //              //bcol.UseColumnTextForButtonValue = true;                     
  //              table.Columns.Add("ID");
  //              table.Columns.Add("City"); 
  //              table.Columns.Add("Phone");
  //              table.Columns.Add("Up");
  
  //              for (int i = 0; i < 5; i++)  
  //              {   
  //                  //row = table.NewRow();
                    
  //                //  asc.Add(userAction.UserName[i]);  
  //                  row["ID"] = "testc";
  //                  row["City"] = "testc";
  //                  row["Phone"] = "testc";
  //                  row["Up"] = "testc";
  //                  table.Rows.Add(row);
                  
  //              }


  //              //dataGridComplaints.DataSource = table;
  //              dataGridComplaints.Rows.Add(row);
  //              //UsersView.AllowUserToAddRows = false;//To remove extra row at the end      
  //            //  UsersView.Columns.Add(bcol);     
  //          } 
  //          catch (Exception ca) 
  //          { 
  //              MessageBox.Show(ca.ToString());    
  //          } 
  //      }

  //      private void dataGridComplaints_CellContentClick(object sender, DataGridViewCellEventArgs e)
  //      {
  //          if (e.ColumnIndex == 4) //Assuming the button column as second column, if not can change the index  
  //          {
  //              //check if anything needs to be validated here  
  //              Form f = CreateFrom("There is Complaint SMS");
           
  //             // f.Text  = dataGridComplaints.Rows[e.RowIndex].Cells[2].Value.ToString();
  //              f.ShowDialog();
  //          }
  //      }//End Function for Getting Present Users 


  //      private Form CreateFrom(string ComplaintSms)
  //      {
  //          Form frm = new Form();
  //          frm.AutoScaleDimensions = new System.Drawing.SizeF(160F, 230F);
  //          frm.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
  //          frm.Name = "frm_ComplaintMsg";
  //          //dimension is irrelevant at the moment
  //          frm.ClientSize = new System.Drawing.Size(240, 240);
  //          //the parent will be the current form
  //          //frm.MdiParent = this;
  //          //splash screen mode form, why not...
  //          frm.ControlBox = true;
  //          frm.FormBorderStyle = System.Windows.Forms.FormBorderStyle
  //             .FixedSingle;
  //          frm.AutoSizeMode = System.Windows.Forms.AutoSizeMode
  //             .GrowAndShrink;
  //          frm.BackColor = System.Drawing.Color.LightGray;



  //          //for (int i=0;i
  //  Label aLabel = new Label();
  //  //aLabel.Font = new System.Drawing.Font(cmbFont.Text, 
  //  //float.Parse(txtSizeFont.Text), System.Drawing.FontStyle
  //  //.Regular, System.Drawing.GraphicsUnit.Point, 
  //  //((byte)(0)));
  //  //backcolor is for testing purposes, to see if the 
  //  //control fits correctly
  //  aLabel.BackColor = System.Drawing.Color.AliceBlue;   
  //aLabel.Location = new System.Drawing.Point(5,35);
 
  //aLabel.Size = new System.Drawing.Size(150, 80);
  //aLabel.Name = "LabelTitle";
  //aLabel.Text = ComplaintSms;
  

    
  //frm.SuspendLayout();
  //aLabel.SuspendLayout();
  //  frm.Controls.Add(aLabel);


  //          return frm;


  //      }

  //      private void CMSComplaintLog_Load(object sender, EventArgs e)
  //      {
  //          this.comboBoxCategory.SelectedIndex = 0;
  //          this.comboBoxService.SelectedIndex = 0;
  //      }

        

       
    }
}
