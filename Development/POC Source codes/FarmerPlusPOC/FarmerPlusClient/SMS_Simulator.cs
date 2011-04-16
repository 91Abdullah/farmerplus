using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmerPlusDataObjectLayer;


namespace FarmerPlusClient
{
    public partial class SMS_Simulator : Form
    {
        ServiceReferenceCropCommonHelper.CropHelperServicesClient cropServiceClient = new ServiceReferenceCropCommonHelper.CropHelperServicesClient();
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new ServiceReferenceCommonHelper.CommonHelperServiceClient();

        ServiceReferenceCommonWeather.CommonWeatherServicesClient  weatherServiceClient = new ServiceReferenceCommonWeather.CommonWeatherServicesClient();

        private static readonly char[] whitespace = new char[] { ' ', '\n', '\t', '\r', '\f', '\v' };

        public SMS_Simulator()
        {
            InitializeComponent();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string smsNumber = this.textBoxNumber.Text.Trim();
            string smsText = this.textBoxMessage.Text.Trim();
            string vendorCode = this.textBoxNumber.Text.Substring(0,4); //anystring.Substring(startIndex, length);
            string rangeCode = this.textBoxNumber.Text.Substring(4, 3) ;
            string outputText = "";
            string cityNameOfCaller = "";
           
         
           // int cityIdOfCaller = GetCityOfACaler(ref cityNameOfCaller, smsNumber);
           int cityIdOfCaller =  commonServiceClient.GetCityId(vendorCode, rangeCode);

           cityNameOfCaller = commonServiceClient.GetCityUrduName(cityIdOfCaller);

            int firstLevelMenu = 0;
            int secondLevelMenu = 0;
            string queryText = "";

            smsText = Normalize(smsText);

            smsText = smsText.Replace("  ", " ");

            if (smsText.ToLower().StartsWith("ex"))
            {
                if (smsText.ToLower().Equals("ex"))
                {
                    DataTable table = cropServiceClient.GetMenus(1, 1).Tables[0];

                    outputText  = "Menu Name" + " --- " + "Menu Serice Id" + " --- " + "Service Name" + " --- " + "Serive Id" + Environment.NewLine;

                    foreach (DataRow rowWalker in table.Rows)
                    {
                        outputText += rowWalker[0].ToString() + " --- " + rowWalker[1].ToString() + " --- " + rowWalker[2].ToString() + " --- " + rowWalker[3].ToString() + Environment.NewLine;
                    }
                }
                else
                {

                    firstLevelMenu = int.Parse(smsText.Substring(3, 1));

                    secondLevelMenu = int.Parse(smsText.Substring(5, 1));

                    queryText = smsText.Substring(7, smsText.Length - 7);

                    DataTable levelOneDataset = cropServiceClient.GetLevelOneMenu(firstLevelMenu).Tables[0];

                    string levelOneMenuText = levelOneDataset.Rows[0][0].ToString();
                    int levelOneLkpId = int.Parse(levelOneDataset.Rows[0][1].ToString());

                    string levelTwoMenuText = cropServiceClient.GetLevelTwoMenu(secondLevelMenu, levelOneLkpId).Tables[0].Rows[0][0].ToString();


                    switch (levelOneMenuText)
                    {
                        #region Price
                        case "Price":
                            switch (levelTwoMenuText)
                            {
                                case "Crops":
                                    DataTable cropData = cropServiceClient.GetCropPrice(cityIdOfCaller, queryText).Tables[0];

                                    if (cropData.Rows.Count <= 0)
                                    {
                                        outputText = "آ پ کے سوال کاے مطابق کوئی جواب موجود نہیں , مدد کے لیے خالی  پیغام بھیجیں ";
                                    }
                                    else
                                    {

                                        outputText = cityNameOfCaller + " میں " + cropData.Rows[0][1].ToString() + " کی قیمت ہے - " + cropData.Rows[0][0].ToString() + " روپے ";
                                    }

                                    break;

                                case "Seeds":

                                    DataTable seedData = cropServiceClient.GetSeedPrice(cityIdOfCaller, queryText).Tables[0];

                                    if (seedData.Rows.Count <= 0)
                                    {
                                        outputText = "آ پ کے سوال کاے مطابق کوئی جواب موجود نہیں , مدد کے لیے خالی  پیغام بھیجیں ";
                                    }
                                    else
                                    {
                                        outputText = cityNameOfCaller + " میں " + seedData.Rows[0][1].ToString() + " کے بیج کی قیمت ہے -" + seedData.Rows[0][0].ToString() + " روپے ";
                                    }

                                    break;
                            }
                            break;
                        #endregion

                        #region Weather
                        case "Weather":
                            switch (levelTwoMenuText)
                            {
                                   
                                case "Weather Daily":
                                    WeatherUpdate weather_conn = new WeatherUpdate();
                                    Conditions conditions = new Conditions();
                                     conditions  = weather_conn.GetCurrentWeatherConditions();
                                    outputText = "موسم:" + conditions.Condition;
                                    outputText = outputText + "درجہ حرارت (°F): " + conditions.TempF;
                                    outputText = outputText + "درجہ حرارت " + conditions.TempC + "\r\n"; ; //+ System.Environment.NewLine;
                                    outputText = outputText + conditions.Humidity;// + "\r\n";
                                    outputText = outputText + conditions.Wind;
                                    outputText = outputText + "Humidity: " + conditions.Humidity + "\r\n";
                                    outputText = outputText + "Wind:" + conditions.Wind;
                                  
                                    break;

                                case "Weather Weekly":
                                    //WeatherServices weather_fc = new WeatherServices();

                                    break;
                            }
                            break;
                        #endregion

                        #region Complaints
                        case "Complaints":
                            switch (levelTwoMenuText)
                            {
                                case "Delayed Purchasing":
                                    cropServiceClient.InsertComplaint("Delayed Purchasing", queryText, cityIdOfCaller, smsNumber);

                                    outputText = "آپ کی شکایت کا اندراج ہو گیا ہے۔";
                                    break;

                                case "Unfair Pricing":
                                    cropServiceClient.InsertComplaint("Unfair Pricing", queryText, cityIdOfCaller, smsNumber);

                                    outputText = "آپ کی شکایت کا اندراج ہو گیا ہے۔";
                                    break;

                                case "Adulteration of Pesticides":
                                    cropServiceClient.InsertComplaint("Adulteration of Pesticides", queryText, cityIdOfCaller, smsNumber);

                                    outputText = "آپ کی شکایت کا اندراج ہو گیا ہے۔";
                                    break;
                            }
                            break;
                        #endregion

                      
                    }
                }
            }
            else if (smsText.ToLower().StartsWith("pr"))
            {
                queryText = smsText.Substring(3, smsText.Length - 3);
                DataTable cropData = cropServiceClient.GetCropPrice(cityIdOfCaller, queryText).Tables[0];
                if (cropData.Rows.Count <= 0)
                {
                    DataTable seedData = cropServiceClient.GetSeedPrice(cityIdOfCaller, queryText).Tables[0];
                    if (seedData.Rows.Count <= 0)
                    {
                        outputText = "آ پ کے سوال کاے مطابق کوئی جواب موجود نہیں , مدد کے لیے خالی  پیغام بھیجیں ";
                    }
                    else
                    {
                        outputText = cityNameOfCaller + " میں " + seedData.Rows[0][1].ToString() + " کے بیج کی قیمت ہے -" + seedData.Rows[0][0].ToString() + " روپے ";
                    }
                }
                else
                {

                    outputText = cityNameOfCaller + " میں " + cropData.Rows[0][1].ToString() + " کی قیمت ہے - " + cropData.Rows[0][0].ToString() + " روپے ";
                }

            }
            else if (smsText.ToLower().StartsWith("wt"))
            {
                //queryText = smsText.Substring(3, smsText.Length - 3);

                WeatherUpdate weather_conn = new WeatherUpdate();
                Conditions conditions = new Conditions();
                conditions = weather_conn.GetCurrentWeatherConditions();
                outputText = "موسم:" + conditions.Condition;
                outputText = outputText + "درجہ حرارت (°F): " + conditions.TempF;
                outputText = outputText + "درجہ حرارت " + conditions.TempC + "\r\n"; ; //+ System.Environment.NewLine;
                outputText = outputText + conditions.Humidity;// + "\r\n";
                outputText = outputText + conditions.Wind;
                outputText = outputText + "Humidity: " + conditions.Humidity + "\r\n";
                outputText = outputText + "Wind:" + conditions.Wind;
            }
            else if (smsText.ToLower().StartsWith("a"))
            {
                queryText = smsText.Substring(2, smsText.Length - 2);
                cropServiceClient.InsertComplaint("Adulteration of Pesticides", queryText, cityIdOfCaller, smsNumber);

                outputText = "آپ کی شکایت کا اندراج ہو گیا ہے۔";
                
            }
            else if (smsText.ToLower().StartsWith("d"))
            {
                queryText = smsText.Substring(2, smsText.Length - 2);
                cropServiceClient.InsertComplaint("Delayed Purchasing", queryText, cityIdOfCaller, smsNumber);

                outputText = "آپ کی شکایت کا اندراج ہو گیا ہے۔";
                
            }
            else if (smsText.ToLower().StartsWith("u"))
            {
                queryText = smsText.Substring(2, smsText.Length - 2);
                cropServiceClient.InsertComplaint("Unfair Pricing", queryText, cityIdOfCaller, smsNumber);

                outputText = "آپ کی شکایت کا اندراج ہو گیا ہے۔";
                
            }


            this.textBoxOutput.Text = outputText;
        }

        #region Caller Region 

        public int GetCityOfACaler(ref string city, string sms_number)
        {
            city = "لاہور";
            return 1;
        }

        #endregion

        
        public static string Normalize(string source)
        {
            return String.Join(" ", source.Split(whitespace, StringSplitOptions.RemoveEmptyEntries));
        }


    }
}
