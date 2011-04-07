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
    public class CropHelper
    {

        #region Seed Helper Routines

       /// <summary>
       /// 
       /// </summary>
       /// <param name="seed_name"></param>
       /// <param name="seed_price"></param>
       /// <param name="semantics_id"></param>
       /// <returns></returns>
        public int InsertSeedInformation(string seed_name, int semantics_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {

                MySqlCommand cmd = new MySqlCommand("insert into seeds (SEED_NAME, SEMANTICS_ID) VALUES ('" + seed_name + "', " + semantics_id.ToString() + ")", conn);

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
        /// <param name="is_mobile"></param>
        /// <returns></returns>
        public DataSet GetSeeds()
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select ID, SEED_NAME AS VALUE FROM SEEDS", conn);

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
        public DataSet GetCropMappingId(int district_id, int crop_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT id, price, REAPING_START_dATE, REAPING_END_DATE, CULTIVATION_START_dATE, CULTIVATION_END_dATE FROM crop_mappings c where c.crop_lkp_id = " + crop_id.ToString() + " and c.district_id = " + district_id.ToString(), conn);

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
        /// <param name="cropAttributes"></param>
        /// <param name="crop_mapping_id"></param>
        /// <returns></returns>
        public int DeleteAndInsertPesticideAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from crop_pesticides where crop_id = " + crop_mapping_id.ToString(), conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                try
                {

                    foreach (Crop_attributes ca in cropAttributes)
                    {
                        MySqlConnection conn1 = DBUtility.getConnection();

                        MySqlCommand cmd1 = new MySqlCommand("insert into crop_pesticides (crop_id, pesticide_id) values (" + crop_mapping_id + "," + ca.attribute_lkp_id + ")", conn1);

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
        /// <param name="cropAttributes"></param>
        /// <param name="crop_mapping_id"></param>
        /// <returns></returns>
        public int DeleteAndInsertFertilizerAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from crop_fertilizers where crop_mapping_id = " + crop_mapping_id.ToString(), conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                try
                {

                    foreach (Crop_attributes ca in cropAttributes)
                    {
                        MySqlConnection conn1 = DBUtility.getConnection();

                        MySqlCommand cmd1 = new MySqlCommand("insert into crop_fertilizers (crop_mapping_id, fertilizer_id) values (" + crop_mapping_id + "," + ca.attribute_lkp_id + ")", conn1);

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

        public int DeleteAndInsertSeedAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlCommand cmd = new MySqlCommand("delete from crop_seeds where crop_mapping_id = " + crop_mapping_id.ToString(), conn);

                cmd.ExecuteNonQuery();

                conn.Close();

                try
                {

                    foreach (Crop_attributes ca in cropAttributes)
                    {
                        MySqlConnection conn1 = DBUtility.getConnection();

                        MySqlCommand cmd1 = new MySqlCommand("insert into crop_seeds (crop_mapping_id, seed_id, price) values (" + crop_mapping_id + ", " + ca.attribute_lkp_id +", " + ca.price + ")", conn1);

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
        /// <param name="crop_mapping_id"></param>
        /// <param name="price"></param>
        /// <param name="reapingStartDate"></param>
        /// <param name="reapingEndDate"></param>
        /// <param name="cultStartDate"></param>
        /// <param name="cultEndDate"></param>
        /// <returns></returns>
        public int InsertOrUpdateCropMapping(int crop_mapping_id, float price, string reapingStartDate, string reapingEndDate,
            string cultStartDate, string cultEndDate, int district_id, int crop_id)
        {
            if (crop_mapping_id == -1)
            {
                MySqlConnection conn = DBUtility.getConnection();

                try
                {
                    

                    MySqlCommand cmd = new MySqlCommand("insert into crop_mappings (price, REAPING_START_dATE, REAPING_END_DATE, CULTIVATION_START_dATE, CULTIVATION_END_dATE, district_id, crop_lkp_id) " +
                    " values ("+price+",'"+reapingStartDate+"','"+reapingEndDate+"','"+cultStartDate+"','"+cultEndDate+"', " + district_id+ "," +crop_id+ ")", conn);

                    int status = cmd.ExecuteNonQuery();

                    conn.Close();

                    MySqlConnection conn1 = DBUtility.getConnection();

                    try
                    {

                        MySqlDataAdapter dapt = new MySqlDataAdapter("select MAX(ID) from crop_mappings", conn);

                        DataSet dataSet = new DataSet();
                        dapt.Fill(dataSet);


                        int crop_mapping_id_to_return = int.Parse(dataSet.Tables[0].Rows[0][0].ToString());

                        conn1.Close();

                        return crop_mapping_id_to_return;

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
            else
            {
                MySqlConnection conn = DBUtility.getConnection();

                try
                {
                    MySqlDataAdapter dapt = new MySqlDataAdapter("update crop_mappings  set price = "+price+", REAPING_START_dATE = '"+reapingStartDate+"', REAPING_END_DATE = '"+reapingEndDate+"', CULTIVATION_START_dATE = '"+cultStartDate+"', CULTIVATION_END_dATE = '"+cultEndDate+"'" + 
                                        " where id = " + crop_mapping_id.ToString(), conn);

                    DataSet dataSet = new DataSet();
                    dapt.Fill(dataSet);

                    conn.Close();

                    return crop_mapping_id;
                }
                catch (Exception ex)
                {
                    DBUtility.closeConnection(conn);
                    return -1;
                }
 
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="crop_mapping_id"></param>
        /// <returns></returns>
        public DataSet GetPesticidesForaCropMapping(int crop_mapping_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select cp.id as id, cp.pesticide_id as pestId, l.item_name as value from crop_pesticides cp, lookups l where l.id = cp.pesticide_id and cp.crop_id = " + crop_mapping_id.ToString(), conn);

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

        public DataSet GetFertilizersForaCropMapping(int crop_mapping_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select cp.id, cp.fertilizer_id as fertId, l.item_name as value from crop_fertilizers cp, lookups l where l.id = cp.fertilizer_id and cp.crop_mapping_id = " + crop_mapping_id.ToString(), conn);

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

        public DataSet GetSeedsForaCropMapping(int crop_mapping_id)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("select cs.id, s.id as seedId, s.seed_name as seed_name, cs.price from seeds s, crop_seeds cs where s.id = cs.seed_id and cs.crop_mapping_id = " + crop_mapping_id.ToString(), conn);

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


        //select cp.id, l.item_name as value from crop_pesticides cp, lookups l where l.id = cp.pesticide_id and cp.crop_id = 1;
        // select cp.id, l.item_name as value from crop_fertilizers cp, lookups l where l.id = cp.fertilizer_id and cp.crop_mapping_id = 1;
        // select cs.id, s.seed_name as value from seeds s, crop_seeds cs where s.id = cs.seed_id and cs.crop_mapping_id = 1;

        #region Agriculture Equipment Helper routines

        

        #endregion

        #region Schedular

         public DataSet GetCultivationScheduleInfo(string currentDate)
        {
            MySqlConnection conn = DBUtility.getConnection();

            try
            {
                MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT c.district_id, s.urdu_translation as crop, cultivation_start_date,cultivation_end_date  FROM " +

                    " crop_mappings c, lookups l, semantics s where c.crop_lkp_id = l.id and s.id = l.semantics_id and cultivation_start_date like '" + currentDate + "'", conn);

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

         public DataSet GetReapingScheduleInfo(string currentDate)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT c.district_id, s.urdu_translation as crop, reaping_start_date, reaping_end_date  FROM crop_mappings c, " +
                    " lookups l, semantics s where c.crop_lkp_id = l.id and s.id = l.semantics_id and reaping_start_date like '" + currentDate + "'", conn);

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

        #region Menus

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sequence_number"></param>
        /// <returns></returns>
         public DataSet GetLevelOneMenu(int sequence_number)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT l.item_name, l.id FROM menu_hierarchies m, lookups l where " +
                        " m.menu_lkp_id = l.id and m.menu_hierarchy_level = 0 " +
                        " and m.application_id = 1 and m.sequence_number = " + sequence_number.ToString(), conn);

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
        /// <param name="sequence_number"></param>
        /// <returns></returns>
         public DataSet GetLevelTwoMenu(int sequence_number, int parent_lkp_id)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("SELECT l.item_name FROM menu_hierarchies m, lookups l where "+
                " m.menu_lkp_id = l.id and m.menu_hierarchy_level = 1 "+
                " and m.application_id = 1 and m.sequence_number = " + sequence_number.ToString() 
                + " and menu_parent_lkp_id = " + parent_lkp_id.ToString(), conn);

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

        #region Pull Services

         
         public DataSet GetSeedPrice(int city_id, string seedName)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter("select cs.price, sem.urdu_translation from seeds s, crop_mappings c, semantics sem, crop_seeds "+
                    " cs, cities where s.id = cs.seed_id and cs.crop_mapping_id = c.id and c.district_id = cities.district_id and "+                    " s.semantics_id = sem.id and s.seed_name = '"+seedName+"' and cities.id = "+city_id.ToString(), conn);
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

         public DataSet GetCropPrice(int city_id, string cropName)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 MySqlDataAdapter dapt = new MySqlDataAdapter(" SELECT c.price, s.urdu_translation  FROM crop_mappings c, cities, lookups l, semantics s where s.id = " +                    " l.semantics_id and cities.district_id = c.district_id and l.id = c.crop_lkp_id and l.item_name = '"+cropName+"'" +
                    " and cities.id = " + city_id, conn);
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

         public int InsertComplaint(string complaint_type, string complaint_text, int city_id, string phone_number)
         {
             MySqlConnection conn = DBUtility.getConnection();

             try
             {
                 int complaint_type_id = 0;

                 switch (complaint_type)
                 {
                     case "Delayed Purchasing":
                         complaint_type_id = 9;
                         break;
                     case "Unfair Pricing":
                         complaint_type_id = 10;
                         break;
                     case "Adulteration of Pesticides":
                         complaint_type_id = 11;
                         break;
                 }

                 MySqlCommand cmd = new MySqlCommand(" insert into complaintlog (CITY_ID, PHONE_NUMBER, DATE_TIME, COMPLAINT_CATEGORY_LKP_ID, SERVICE_LKP_ID, SEMANTICS_ID) " +
                   " values ("+city_id.ToString()+", '"+phone_number+"', '"+DateTime.Today.ToShortDateString()+"', "+complaint_type_id.ToString()+", 12, 1)", conn);

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


    }
}


