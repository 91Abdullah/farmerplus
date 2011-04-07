using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FarmerPlusDataAccessLayer;
using FarmerPlusDataObjectLayer;
using System.Data;

namespace FarmerPlusWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CropHelperServices" in both code and config file together.
    public class CropHelperServices : ICropHelperServices
    {
    
        CropHelper cropDBHelper = new CropHelper();

        public void DoWork()
        {
        }

        public int InsertComplaint(string complaint_type, string complaint_text, int city_id, string phone_number)
        { return cropDBHelper.InsertComplaint(complaint_type, complaint_text, city_id, phone_number); }
        public DataSet GetCropPrice(int city_id, string cropName)
        { return cropDBHelper.GetCropPrice(city_id, cropName); }
        public DataSet GetSeedPrice(int city_id, string seedName)
        { return cropDBHelper.GetSeedPrice(city_id, seedName); }

        public DataSet GetLevelTwoMenu(int sequence_number, int parent_lkp_id)
        { return cropDBHelper.GetLevelTwoMenu(sequence_number, parent_lkp_id); }

        public DataSet GetLevelOneMenu(int sequence_number)
        { return cropDBHelper.GetLevelOneMenu(sequence_number); }

        public DataSet GetReapingScheduleInfo(string currentDate)
        { return cropDBHelper.GetReapingScheduleInfo(currentDate); }

        public DataSet GetCultivationScheduleInfo(string currentDate)
        { return cropDBHelper.GetCultivationScheduleInfo(currentDate); }

        public int DeleteAndInsertSeedAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id)
        { return cropDBHelper.DeleteAndInsertSeedAttributes(cropAttributes,crop_mapping_id); }

        public int DeleteAndInsertFertilizerAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id)
        { return cropDBHelper.DeleteAndInsertFertilizerAttributes(cropAttributes, crop_mapping_id); }

        public int DeleteAndInsertPesticideAttributes(List<Crop_attributes> cropAttributes, int crop_mapping_id)
        { return cropDBHelper.DeleteAndInsertPesticideAttributes(cropAttributes, crop_mapping_id); }
        
       public DataSet GetSeedsForaCropMapping(int crop_mapping_id)
        { return cropDBHelper.GetSeedsForaCropMapping(crop_mapping_id); }

        public DataSet GetPesticidesForaCropMapping(int crop_mapping_id)
       { return cropDBHelper.GetPesticidesForaCropMapping(crop_mapping_id); }

        public DataSet GetFertilizersForaCropMapping(int crop_mapping_id)
        { return cropDBHelper.GetFertilizersForaCropMapping(crop_mapping_id); }

        public DataSet GetSeeds()
        {
            return cropDBHelper.GetSeeds();
        }

        public DataSet GetCropMappingId(int district_id, int crop_id)
        {
            return cropDBHelper.GetCropMappingId(district_id, crop_id);
        }


        public int InsertOrUpdateCropMapping(int crop_mapping_id, float price, string reapingStartDate, string reapingEndDate,
            string cultStartDate, string cultEndDate, int district_id, int crop_id)
        {
            return cropDBHelper.InsertOrUpdateCropMapping(crop_mapping_id, price, reapingStartDate, reapingEndDate, cultStartDate, cultEndDate, district_id, crop_id);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="seed_name"></param>
        /// <param name="seed_price"></param>
        /// <param name="semantics_id"></param>
        /// <returns></returns>
        public int InsertSeedInformation(string seed_name, int semantics_id)
        {
             return cropDBHelper.InsertSeedInformation(seed_name, semantics_id);
        }
    }
}
