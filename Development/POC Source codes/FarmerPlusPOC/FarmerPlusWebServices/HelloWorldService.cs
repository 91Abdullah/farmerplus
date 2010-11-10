using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FarmerPlusDataAccessLayer;
using BusinessManagementLayer.Business_Managers;

namespace FarmerPlusWebServices
{
    // NOTE: If you change the class name "HelloWorldService" here, you must also update the reference to "HelloWorldService" in App.config.
    
    public class HelloWorldService : IHelloWorldService
    {
        /// <summary>
        /// Service to get Hello World Message
        /// </summary>
        /// <returns></returns>
        public HelloWorldDAO GetHelloWorldMessage(int messageId)
        {
            HelloWorldManager _helloWorldManager = new HelloWorldManager();

            return _helloWorldManager.TakeTheHelloWorldMessage(messageId);

        }
    }
}
