using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace FarmerPlusDataAccessLayer
{
    public class HelloWorldDBService
    {
        public HelloWorldDAO GetHelloWorldMessage(int id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
               
                MySqlDataAdapter dapt = new MySqlDataAdapter("select value from helloworld where id =  " + id.ToString() , conn);

                DataSet dataSet = new DataSet();
                dapt.Fill(dataSet);

                HelloWorldDAO hwdtoreturn = new HelloWorldDAO();
                hwdtoreturn.StrHelloWorldMessage = dataSet.Tables[0].Rows[0][0].ToString();

                conn.Close();

                return hwdtoreturn;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return null;
            }
        }
    }
}


