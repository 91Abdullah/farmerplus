using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using BusinessManagementLayer.Business_Managers;
using FarmerPlusDataObjectLayer;

namespace FarmerPlusWebServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "WeatherServices" in both code and config file together.
    public class WeatherServices : IWeatherServices
    {
        public FarmerPlusDataObjectLayer.Conditions GetCurrentConditions(string inputrequest)
        {

            GoogleWeatherService _googleServices = new GoogleWeatherService();

            return _googleServices.GetCurrentConditions(inputrequest);

        }
    }
}
