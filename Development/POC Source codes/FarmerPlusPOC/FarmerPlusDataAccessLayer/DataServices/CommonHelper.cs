using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using FarmerPlusDataObjectLayer;

namespace FarmerPlusDataAccessLayer
{
    /// <summary>
    /// This class will hold all common db related routines
    /// </summary>
    public class CommonHelper
    {

        #region Location Helper Routines

        /// <summary>
        /// 
        /// </summary>
        /// <param name="is_mobile"></param>
        /// <returns></returns>
        public DataSet GetPhoneRanges(int is_mobile, int vendor_code_id, int city_id)
        {
            MySqlConnection conn = DBUtility.getConnection();
            
            try
            {
                
                MySqlDataAdapter dapt = new MySqlDataAdapter(
                    "SELECT P.START_RANGE, P.END_RANGE "+
                    " FROM phone_locations_mappings p, vendor_phone_codes v where v.id = p.vendor_phone_code_id " +
                    " and v.is_mobile = " + is_mobile +
                    " and v.id = " + vendor_code_id.ToString() +                    
                    " and city_id = " + city_id.ToString(), conn);

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



       /// <summary>
       /// 
       /// </summary>
       /// <param name="vendor_code_id"></param>
       /// <param name="city_id"></param>
       /// <param name="list"></param>
       /// <returns></returns>
        public int DeleteAndInsertPhoneRanges(int vendor_code_id, int city_id, List<Phone_Ranges> list)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("delete FROM phone_locations_mappings where city_id = "+city_id.ToString()+" and vendor_phone_code_id = " + vendor_code_id.ToString(), conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                

                try
                {

                    foreach (Phone_Ranges pr in list)
                    {
                        MySqlConnection conn1 = DBUtility.getConnection();

                        MySqlCommand cmd1 = new MySqlCommand("insert into phone_locations_mappings  (VENDOR_PHONE_CODE_ID, START_RANGE, END_RANGE, CITY_ID) " +
                        " VALUES (" + vendor_code_id.ToString() + ",'"+pr.Start_Range+"','"+pr.End_Range+"',"+city_id+")", conn1);

                        cmd1.ExecuteNonQuery();

                        conn1.Close();
                    }
                    
                    


                    

                    return 1;


                }
                catch (Exception ex)
                {
                    //DBUtility.closeConnection(conn1);
                    return -1;
                }

                
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="is_mobile"></param>
        /// <returns></returns>
        public DataSet GetVendorCodes(int is_mobile)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select ID, phone_code as VALUE from vendor_phone_codes where is_mobile = " + is_mobile.ToString(), conn);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="complaint_id"></param>
        /// <param name="complaint_followup"></param>
        /// <returns></returns>
        public int CreateVendorCode(string vendor_code, int is_mobile)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into vendor_phone_codes (phone_code, is_mobile) values ('" + vendor_code + "', " + is_mobile.ToString() + ")", conn);

                int status = cmd.ExecuteNonQuery();

                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        //////////////////////////////////////

        /// <summary>
        /// 
        /// </summary>
        /// <param name="district_name"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInDistricts(string district_name, int semantics_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into districts (DISTRICT_NAME, SEMANTICS_ID) VALUES ('"
                    + district_name + "', " + semantics_id.ToString() + ")", conn);

                int status = cmd.ExecuteNonQuery();

                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city_name"></param>
        /// <param name="district_id"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInCities(string city_name, int district_id , int semantics_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into cities (NAME, DISTRICT_ID, SEMANTICS_ID) VALUES ('"
                    + city_name + "', " + district_id.ToString() + "," + semantics_id.ToString() + ")", conn);

                int status = cmd.ExecuteNonQuery();

                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }
        

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetCitiesList()
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT c.ID, c.NAME AS VALUE FROM cities c", conn);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="district_id"></param>
        /// <returns></returns>
        public DataSet GetCitiesInADistrict(int district_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT c.ID, c.NAME AS VALUE FROM cities c where c.district_id = " + district_id.ToString(), conn);

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

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public DataSet GetDistrictsList()
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT d.ID, d.DISTRICT_NAME AS VALUE FROM districts d", conn);

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

        /// <summary>
        /// Get Id for a city based on vendorcode and vendor location rnage
        /// </summary>
        /// <param name="cityName"></param>
        /// <returns></returns>
      public int GetCityIdforLocationServices(string vendorCode, string rangeCode)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select C.ID from cities c, phone_locations_mappings p, vendor_phone_codes v where ((p.city_id= C.ID) and ((" + rangeCode + ">= p.Start_Range) and (" + rangeCode + "<=p.End_range)) and (p.VENDOR_PHONE_CODE_ID = v.ID) and (v.phone_code='" + vendorCode + "'))", conn);

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

        #region Lookups

        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public DataSet GetLookupList(string groupName)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT l.ID, l.ITEM_NAME AS VALUE FROM lookups l, lookup_groups lg where l.ITEM_GROUP_ID = lg.ID and lg.GROUP_NAME =  '" + groupName + "'", conn);

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


        public string GetUrduNameOfALookupId(int lkp_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select s.urdu_translation from lookups l, semantics s where l.semantics_id = s.id and l.id = " + lkp_id.ToString(), conn);

                DataSet dataSet = new DataSet();
                dapt.Fill(dataSet);

                conn.Close();

                return dataSet.Tables[0].Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return null;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public int GetLookupGroupId(string groupName)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select id from lookup_groups lg where lg.group_name = '" + groupName + "'", conn);

                DataSet dataSet = new DataSet();
                dapt.Fill(dataSet);


                int groupId = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                conn.Close();

                return groupId;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item_name"></param>
        /// <param name="group_id"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInLookups(string item_name, int group_id, int semantics_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {              

               MySqlCommand cmd = new MySqlCommand("insert into lookups (ITEM_NAME, ITEM_GROUP_ID, SEMANTICS_ID) VALUES ('" + item_name + "', " + group_id.ToString() + " , " + semantics_id.ToString() + ")", conn);

                int status = cmd.ExecuteNonQuery();

                conn.Close();

                MySqlConnection conn1 = DBUtility.getConnection();

                try
                {

                    MySqlDataAdapter dapt = new MySqlDataAdapter("select MAX(L.ID) from LOOKUPS L", conn);

                    DataSet dataSet = new DataSet();
                    dapt.Fill(dataSet);


                    int lookup_id = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                    conn1.Close();

                    return lookup_id;

                }
                catch (Exception ex)
                {
                    DBUtility.closeConnection(conn1);
                    return -1;
                }
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="file_path"></param>
        /// <param name="urdu_text"></param>
        /// <returns></returns>
        public int InsertAndGetSemantics(string file_path, string urdu_text)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                file_path = file_path.Replace(@"\", "~");

                MySqlCommand cmd = new MySqlCommand("insert INTO SEMANTICS (URDU_TRANSLATION, AUDIO_FILE_PATH) VALUES ('" + urdu_text + "', '" + file_path + "')", conn);
                
                int status = cmd.ExecuteNonQuery();

                conn.Close();

                MySqlConnection conn1 = DBUtility.getConnection();

                try
                {

                    MySqlDataAdapter dapt = new MySqlDataAdapter("select MAX(S.ID) from SEMANTICS S", conn);

                    DataSet dataSet = new DataSet();
                    dapt.Fill(dataSet);


                    int semantics_id  = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                    conn1.Close();

                    return semantics_id;
                    
                }
                catch (Exception ex)
                {
                    DBUtility.closeConnection(conn1);
                    return -1;
                }

                
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        #endregion

        #region Company Helper Routines

        /// <summary>
        /// 
        /// </summary>
        /// <param name="compay_name"></param>
        /// <param name="contact_number"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertCompany(string compay_name, string contact_number, int semantics_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into companies (COMPANY_NAME, CONTACT_NUMBER, SEMANTICS_ID) VALUES ('" + compay_name + "', '" + contact_number  + "' , " + semantics_id.ToString() + ")", conn);

                int status = cmd.ExecuteNonQuery();

                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="groupName"></param>
        /// <returns></returns>
        public DataSet GetCompaniesList()
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT c.ID, c.COMPANY_NAME AS VALUE FROM companies c", conn);

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

        #region AgriEquipment Helper Routines

        /// <summary>
        /// 
        /// </summary>
        /// <param name="agriequiplkpid"></param>
        /// <param name="city_id"></param>
        /// <param name="company_id"></param>
        /// <param name="price"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInAgriEquipmentMapping(int agriequiplkpid, int city_id, int company_id, int price)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into agriequipmentmapping (AGRIEQUIP_LKP_ID, CITY_ID, COMPANY_ID, PRICE) VALUES ('"
                    + agriequiplkpid.ToString() + "', " + city_id.ToString() + " , " + company_id.ToString() + " , " + price.ToString() + ")", conn);

                int status = cmd.ExecuteNonQuery();

                conn.Close();

                return status;
            }
            catch (Exception ex)
            {
                DBUtility.closeConnection(conn);
                return -1;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service_id"></param>
        /// <param name="category_id"></param>
        /// <returns></returns>
         public DataSet GetComplaints(int service_id, int category_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT LG.ID, s.urdu_translation AS COMPLAINT, LG.PHONE_NUMBER, C.NAME AS CITY_NAME, LG.FOLLOWUP, DATE_TIME AS COMPLAINT_TIME   FROM COMPLAINTLOG LG, CITIES C, LOOKUPS CATEG_L, LOOKUPS SERV_L, SEMANTICS S " +
                " WHERE LG.CITY_ID = C.ID AND CATEG_L.ID = COMPLAINT_CATEGORY_LKP_ID AND SERV_L.ID = SERVICE_LKP_ID AND S.ID = LG.SEMANTICS_ID " +
                 " AND SERV_L.ID = "+service_id+" AND CATEG_L.ID = " + category_id, conn);

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


        /// <summary>
        /// 
        /// </summary>
        /// <param name="complaint_id"></param>
        /// <returns></returns>
         public string GetComplaintFollowup(int complaint_id)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("select c.followup FROM farmerplus.complaintlog c where c.id = " + complaint_id.ToString(), conn);

                 DataSet dataSet = new DataSet();
                 dapt.Fill(dataSet);

                 conn.Close();

                 return dataSet.Tables[0].Rows[0][0].ToString();
             }
             catch (Exception ex)
             {
                 DBUtility.closeConnection(conn);
                 return null;
             }
         }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="complaint_id"></param>
        /// <param name="complaint_followup"></param>
        /// <returns></returns>
         public int UpdateComplaintFolloup(int complaint_id, string complaint_followup)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {

                 MySqlCommand cmd = new MySqlCommand("update complaintlog cl set cl.followup = '" + complaint_followup + "' where cl.id = " + complaint_id, conn);

                 int status = cmd.ExecuteNonQuery();

                 conn.Close();

                 return status;
             }
             catch (Exception ex)
             {
                 DBUtility.closeConnection(conn);
                 return -1;
             }
         }
        

        #endregion

        #region Login

        /// <summary>
        /// 
        /// </summary>
        /// <param name="username"></param>
        /// <returns></returns>
         public DataSet GetLoginInfor(string username, string password)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {

                 MySqlDataAdapter dapt = new MySqlDataAdapter(
                     "select password from login where user_name like '" + username + "' and password like '" + password + "'" , conn);

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

        #region Caller

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city_id"></param>
        /// <returns></returns>
         public DataSet GetCallerOfACity(int city_id)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("select c.phone_number from caller_history c where c.IS_PUSH_SERVICE_ALLOWED = 1 and c.city_id =  " + city_id, conn);

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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="district_id"></param>
        /// <returns></returns>
         public DataSet GetCallerOfADistrict(int district_id)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("select c.phone_number from caller_history c, cities ct where city_id = ct.id and c.IS_PUSH_SERVICE_ALLOWED = 1 and ct.district_id =  " + district_id, conn);

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

        #region SMS PULL

         /// <summary>
         /// 
         /// </summary>
         /// <param name="file_path"></param>
         /// <param name="urdu_text"></param>
         /// <returns></returns>
         public int GetCallerHistory(string number, int city_id, int is_expert)
         {
             DataSet dataSet = null;
             MySqlConnection conn1 = DBUtility.getConnection();

             try
             {

                 MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT * FROM caller_history c where c.phone_number = '"+number+"'", conn1);

                 dataSet = new DataSet();
                 dapt.Fill(dataSet);

                 conn1.Close();

             }
             catch (Exception ex)
             {
                 DBUtility.closeConnection(conn1);
                 return -1;
             }

             if (dataSet.Tables[0].Rows.Count > 0)
             {
                 MySqlConnection conn = DBUtility.getConnection();

                 try
                 {
                     MySqlCommand cmd = new MySqlCommand("update caller_history c set last_call_date = '"+DateTime.Today.ToString()+
                         "', user_type_lkp_id = "+is_expert+" where phone_number = '"+number+ "'" , conn);

                     int status = cmd.ExecuteNonQuery();

                     conn.Close();

                     return int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                 }
                 catch (Exception ex)
                 {
                     DBUtility.closeConnection(conn);
                     return -1;
                 }
             }
             else
             {

                 MySqlConnection conn = DBUtility.getConnection();

                 try
                 {
                     MySqlCommand cmd = new MySqlCommand("insert into caller_history (phone_number, LAST_CALL_DATE, CITY_ID, IS_PUSH_SERVICE, USER_TYPE_LKP_ID) " +
                    " VALUES ('"+number+"', '"+ DateTime.Today.ToString()+"',"+city_id.ToString()+" ,1 , " + is_expert + " );", conn);

                     int status = cmd.ExecuteNonQuery();

                     conn.Close();

                     MySqlConnection conn2 = DBUtility.getConnection();

                     try
                     {

                         MySqlDataAdapter dapt = new MySqlDataAdapter("select max(id) from caller_history", conn);

                         DataSet dataSet1 = new DataSet();
                         dapt.Fill(dataSet1);


                         int semantics_id = int.Parse(dataSet1.Tables[0].Rows[0][0].ToString());

                         conn2.Close();

                         return semantics_id;

                     }
                     catch (Exception ex)
                     {
                         DBUtility.closeConnection(conn2);
                         return -1;
                     }

                 }
                 catch (Exception ex)
                 {
                     DBUtility.closeConnection(conn);
                     return -1;
                 }
 
             }            
         }

        #endregion


    }
}


