using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;


namespace FarmerPlusDataAccessLayer
{
    /// <summary>
    /// This class will hold all common db related routines
    /// </summary>
    public class CommonHelper
    {

        #region Location Helper Routines

        /// <summary>
        /// For gettign Urdu semantics of a city name
        /// </summary>
        /// <param name="cityId"></param>
        /// <returns></returns>
        public string GetCityUrduName(int cityId)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT S.URDU_TRANSLATION FROM CITIES C, SEMANTICS S WHERE C.SEMANTICS_ID = S.ID AND C.ID = " + cityId.ToString(), conn);

                DataSet dataSet = new DataSet();
                dapt.Fill(dataSet);

                
                string UrduCityName = dataSet.Tables[0].Rows[0][0].ToString();

                conn.Close();

                return UrduCityName;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return null;
            }
        }

        /// <summary>
        /// Get Id for a city based on city name
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
        public int GetCityIdForCityName(string cityName)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT ID FROM CITIES C WHERE C.NAME LIKE = " + cityName, conn);

                DataSet dataSet = new DataSet();
                dapt.Fill(dataSet);


                int cityId = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                conn.Close();

                return cityId;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        #endregion

        #region Profile Helper Routines
         
        public DataSet GetCityUrduName()
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT C.ID, C.CITY_ID, C.IS_PUSH_SERVICE_ALLOWED, C.LAST_CALL_DATE  FROM caller_history c", conn);

                DataSet dataSet = new DataSet();
                dapt.Fill(dataSet);                              

                conn.Close();

                return dataSet;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return null;
            }
        }

        #endregion
        
    }
}


