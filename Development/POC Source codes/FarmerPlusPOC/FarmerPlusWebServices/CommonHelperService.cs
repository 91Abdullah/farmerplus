using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FarmerPlusDataAccessLayer;
using System.Data;
using FarmerPlusDataObjectLayer;

namespace FarmerPlusWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CommonHelperService" in both code and config file together.
    public class CommonHelperService : ICommonHelperService
    {
        CommonHelper commonDBHelper = new CommonHelper();

        public void DoWork()
        {
        }       
        
        public DataSet GetCallerOfACity(int city_id)
        {
            return commonDBHelper.GetCallerOfACity(city_id);
        }

        public DataSet GetCallerOfADistrict(int district_id)
        {
            return commonDBHelper.GetCallerOfADistrict(district_id);
        }

        public DataSet GetCitiesInADistrict(int district_id)
        {
            return commonDBHelper.GetCitiesInADistrict(district_id); 
        }

        public DataSet GetLoginInfor(string username, string password)
        {
            return commonDBHelper.GetLoginInfor(username, password);
        }

        public int DeleteAndInsertPhoneRanges(int vendor_code_id, int city_id, List<Phone_Ranges> list)
        {
            return commonDBHelper.DeleteAndInsertPhoneRanges(vendor_code_id, city_id, list);
        }

        public DataSet GetPhoneRanges(int is_mobile, int vendor_code_id, int city_id)
        {
            return commonDBHelper.GetPhoneRanges(is_mobile, vendor_code_id, city_id);
        }

        public DataSet GetVendorCodes(int is_mobile)
        {
            return commonDBHelper.GetVendorCodes(is_mobile);
        }

        public int CreateVendorCode(string vendor_code, int is_mobile)
        {
            return commonDBHelper.CreateVendorCode(vendor_code, is_mobile);
        }

        public string GetComplaintFollowup(int complaint_id)
        {
            return commonDBHelper.GetComplaintFollowup(complaint_id);
        }


        public int UpdateComplaintFolloup(int complaint_id, string complaint_followup)
        {
            return commonDBHelper.UpdateComplaintFolloup(complaint_id, complaint_followup);
        }

        public string GetUrduNameOfALookupId(int lkp_id)
        {
            return commonDBHelper.GetUrduNameOfALookupId(lkp_id);
        }
    
    

        /// <summary>
        /// 
        /// </summary>
        /// <param name="service_id"></param>
        /// <param name="category_id"></param>
        /// <returns></returns>
        public DataSet GetComplaints(int service_id, int category_id)
        {
            return commonDBHelper.GetComplaints(service_id, category_id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="city_name"></param>
        /// <param name="district_id"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInCities(string city_name, int district_id, int semantics_id)
        {
            return commonDBHelper.InsertInCities(city_name, district_id, semantics_id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="district_name"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInDistricts(string district_name, int semantics_id)
        {
            return commonDBHelper.InsertInDistricts(district_name, semantics_id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="file_path"></param>
        /// <param name="urdu_name"></param>
        /// <returns></returns>
        public int InsertAndGetSemantics(string file_path, string urdu_name)
        {
            return commonDBHelper.InsertAndGetSemantics(file_path, urdu_name);                    
        }

        public int InsertCompany(string compay_name, string contact_number, int semantics_id)
        {
            return commonDBHelper.InsertCompany(compay_name, contact_number, semantics_id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lookup_group_name"></param>
        /// <returns></returns>
        public int GetLookupGroupId(string lookup_group_name)        
        {
            return commonDBHelper.GetLookupGroupId(lookup_group_name);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item_name"></param>
        /// <param name="group_id"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertInLookup(string item_name, int group_id, int semantics_id)
        {
            return commonDBHelper.InsertInLookups(item_name, group_id, semantics_id);
        }


        public DataSet GetLookupList(string groupName)
        {
            return commonDBHelper.GetLookupList(groupName);
        }


        public DataSet GetCompaniesList()
        {
            return commonDBHelper.GetCompaniesList();
        }

        public DataSet GetCitiesList()
        {
            return commonDBHelper.GetCitiesList();
        }

        public int GetCityId(string vendorCode, string codeRange)
        {
            return commonDBHelper.GetCityIdforLocationServices(vendorCode, codeRange);
        }


        public int InsertInAgriEquipmentMapping(int agriequiplkpid, int city_id, int company_id, int price)
        {
            return commonDBHelper.InsertInAgriEquipmentMapping(agriequiplkpid, city_id, company_id, price);
        }

        public DataSet GetDistrictsList()
        {
            return commonDBHelper.GetDistrictsList();
        }

        public string GetCityUrduName(int cityId)
        {
            return commonDBHelper.GetCityUrduName(cityId);
        }
    }
}
