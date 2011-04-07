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
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICropHelperServices" in both code and config file together.
    [ServiceContract]
    public interface ICropHelperServices
    {
        [OperationContract]
        void DoWork();

        [OperationContract]
        int InsertSeedInformation(string seed_name, int semantics_id);

        [OperationContract]
        DataSet GetSeeds();

        [OperationContract]
        DataSet GetCropMappingId(int district_id, int crop_id);

        [OperationContract]
        int InsertOrUpdateCropMapping(int crop_mapping_id, float price, string reapingStartDate, string reapingEndDate,
            string cultStartDate, string cultEndDate, int district_id, int crop_id);

        [OperationContract]
        DataSet GetSeedsForaCropMapping(int crop_mapping_id);

        [OperationContract]
        DataSet GetPesticidesForaCropMapping(int crop_mapping_id);

        [OperationContract]
        DataSet GetFertilizersForaCropMapping(int crop_mapping_id);

        [OperationContract]
        int DeleteAndInsertSeedAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id);

        [OperationContract]
        int DeleteAndInsertFertilizerAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id);

        [OperationContract]
        int DeleteAndInsertPesticideAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id);

        [OperationContract]
        DataSet GetReapingScheduleInfo(string currentDate);

        [OperationContract]
        DataSet GetCultivationScheduleInfo(string currentDate);

        [OperationContract]
        DataSet GetLevelTwoMenu(int sequence_number, int parent_lkp_id);

        [OperationContract]
        DataSet GetLevelOneMenu(int sequence_number);

        [OperationContract]
        int InsertComplaint(string complaint_type, string complaint_text, int city_id, string phone_number);

        [OperationContract]
        DataSet GetCropPrice(int city_id, string cropName);

        [OperationContract]
        DataSet GetSeedPrice(int city_id, string seedName);
    }
}
