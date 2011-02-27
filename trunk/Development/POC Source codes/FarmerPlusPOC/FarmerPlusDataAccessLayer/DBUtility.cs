using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System.Configuration;
using System.Data;
using MySql.Data.MySqlClient;

namespace FarmerPlusDataAccessLayer
{
    public class DBUtility
    {
        public static MySqlConnection getConnection()
        {
            try
            {                
                MySqlConnection conn = new MySqlConnection(System.Configuration.ConfigurationSettings.AppSettings["ConnectionStringTag"].ToString());
                conn.Open();

                return conn;
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public static void closeConnection(MySqlConnection conn)
        {
            conn.Close();
        }
    }  
}
