using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmerPlusDataObjectLayer;
using FarmerPlusSMS;

namespace FarmerPlusScheduarManager
{
    public partial class SchedularDashboard : Form
    {
        ServiceReferenceCrop.CropHelperServicesClient cropServiceClient = new ServiceReferenceCrop.CropHelperServicesClient();
        ServiceReferenceWeather.WeatherServicesClient weatherServiceClient = new ServiceReferenceWeather.WeatherServicesClient();
        ServiceReferenceCommon.CommonHelperServiceClient commonServiceClient = new ServiceReferenceCommon.CommonHelperServiceClient();
        
        public SchedularDashboard()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.timerSchedular.Enabled = true;           
            
        }

        /// <summary>
        /// Parses the Wind from Service String
        /// </summary>
        /// <param name="windString"></param>
        /// <returns></returns>
        private int GetCurrentWindSpeed(string windString)
        {
            string[] tokens = windString.Split(" ".ToArray());

            return int.Parse(tokens[tokens.Length - 2]);
        }

        void WeatherScheduleFunctionality()
        {
            string weatherService = System.Configuration.ConfigurationSettings.AppSettings["WeatherServices"].ToString();
            SMS_Manager smsManager = new SMS_Manager();

            if (weatherService.ToLower().Equals("on"))
            {
                DataSet cities = commonServiceClient.GetCitiesList();

                // wind
                foreach (DataRow city in cities.Tables[0].Rows)
                {

                    #region Wind

                    int windLevel = int.Parse(System.Configuration.ConfigurationSettings.AppSettings["WindLevel"].ToString());

                    ServiceReferenceWeather.Conditions conditions = new ServiceReferenceWeather.Conditions();

                    conditions = weatherServiceClient.GetCurrentConditions("cc " + city[1].ToString().ToLower());

                    int currentWindLevel = GetCurrentWindSpeed(conditions.Wind);

                    if (currentWindLevel > windLevel)
                    {
                        DataTable phoneNumbers = commonServiceClient.GetCallerOfACity(int.Parse(city[0].ToString())).Tables[0];

                        foreach (DataRow phoneWalker in phoneNumbers.Rows)
                        {
                            smsManager.ThrowSms("آج آندھی کا امکان ہے۔", phoneWalker[0].ToString());
                        }
                    }

                    #endregion


                    #region Rain

                    if (conditions.Condition.ToLower().Contains("rain"))
                    {
                        DataTable phoneNumbers = commonServiceClient.GetCallerOfACity(int.Parse(city[0].ToString())).Tables[0];

                        foreach (DataRow phoneWalker in phoneNumbers.Rows)
                        {
                            smsManager.ThrowSms("آج بارش کا امکان ہے ۔", phoneWalker[0].ToString());
                        }
                    }

                    #endregion



                }
            }
        }

        void CropScheduleFunctionality()
        {
            string cultivationService = System.Configuration.ConfigurationSettings.AppSettings["CultivationSchedular"].ToString();
            string reapingService = System.Configuration.ConfigurationSettings.AppSettings["ReapingShcedular"].ToString();

            SMS_Manager smsManager = new SMS_Manager();

            if (cultivationService.ToLower().Equals("on"))
            {
                DataSet cultInfo = cropServiceClient.GetCultivationScheduleInfo(DateTime.Today.ToShortDateString());

                foreach (DataRow rowWalker in cultInfo.Tables[0].Rows)
                {
                    int district_id = int.Parse(rowWalker[0].ToString());
                    string crop_name = rowWalker[1].ToString();
                    string cultStartDate = rowWalker[2].ToString();
                    string cultEndDaet = rowWalker[3].ToString();

                    DataTable phoneNumbers = commonServiceClient.GetCallerOfADistrict(district_id).Tables[0];

                    foreach (DataRow phoneWalker in phoneNumbers.Rows)
                    {
                        smsManager.ThrowSms(rowWalker[1].ToString() + " کی کاشت کا وقت آ گیا ہے۔", phoneWalker[0].ToString());
                    }
                }
            }

            if (reapingService.ToLower().Equals("on"))
            {
                DataSet reapingInfo = cropServiceClient.GetReapingScheduleInfo(DateTime.Today.ToShortDateString());

                foreach (DataRow rowWalker in reapingInfo.Tables[0].Rows)
                {
                    int district_id = int.Parse(rowWalker[0].ToString());
                    string crop_name = rowWalker[1].ToString();
                    string reapingStartDate = rowWalker[2].ToString();
                    string reapingEndDaet = rowWalker[3].ToString();

                    DataTable phoneNumbers = commonServiceClient.GetCallerOfADistrict(district_id).Tables[0];

                    foreach (DataRow phoneWalker in phoneNumbers.Rows)
                    {
                        smsManager.ThrowSms(rowWalker[1].ToString() + " کی کٹائی کا وقت آ گیا ہے۔", phoneWalker[0].ToString());
                    }
                }
            }                         
        }
        

        private void timerSchedular_Tick(object sender, EventArgs e)
        {
            CropScheduleFunctionality();
        }

        private void timerWeather_Tick(object sender, EventArgs e)
        {
            WeatherScheduleFunctionality();
        }

        private void buttonCropSchedular_Click(object sender, EventArgs e)
        {
            CropScheduleFunctionality();
        }

        private void buttonWeatherSchedular_Click(object sender, EventArgs e)
        {
            WeatherScheduleFunctionality();
        }
    }
}
