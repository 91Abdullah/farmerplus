using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using FarmerPlusDataObjectLayer;

namespace FarmerPlusWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommonHelperService" in both code and config file together.
    [ServiceContract]
    public interface ICommonHelperService
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int InsertAndGetSemantics(string file_path, string urdu_name);

        [OperationContract]
        int GetLookupGroupId(string lookup_group_name);

        [OperationContract]
        int InsertInLookup(string item_name, int group_id, int semantics_id);

        [OperationContract]
        int InsertCompany(string compay_name, string contact_number, int semantics_id);

        [OperationContract]
        DataSet GetLookupList(string groupName);

        [OperationContract]
        DataSet GetCompaniesList();

        [OperationContract]
        DataSet GetCitiesList();

        [OperationContract]
        int InsertInAgriEquipmentMapping(int agriequiplkpid, int city_id, int company_id, int price);

        [OperationContract]
        DataSet GetDistrictsList();

        [OperationContract]
        int InsertInCities(string city_name, int district_id, int semantics_id);

        [OperationContract]
        int InsertInDistricts(string district_name, int semantics_id);

        [OperationContract]
        DataSet GetComplaints(int service_id, int category_id);

        [OperationContract]
        string GetComplaintFollowup(int complaint_id);

        [OperationContract]
        int UpdateComplaintFolloup(int complaint_id, string complaint_followup);

        [OperationContract]
        DataSet GetVendorCodes(int is_mobile);

        [OperationContract]
        int CreateVendorCode(string vendor_code, int is_mobile);

        [OperationContract]
        DataSet GetPhoneRanges(int is_mobile, int vendor_code_id, int city_id);

        [OperationContract]
        int DeleteAndInsertPhoneRanges(int vendor_code_id, int city_id, List<Phone_Ranges> list);

        [OperationContract]
        DataSet GetLoginInfor(string username, string password);

        [OperationContract]
        DataSet GetCitiesInADistrict(int district_id);
        
        [OperationContract]
        DataSet GetCallerOfACity(int city_id);

        [OperationContract]
        DataSet GetCallerOfADistrict(int district_id);

        [OperationContract]
        string GetUrduNameOfALookupId(int lkp_id);
    }
}
