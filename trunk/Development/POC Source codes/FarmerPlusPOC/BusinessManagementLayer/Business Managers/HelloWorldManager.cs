using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FarmerPlusDataAccessLayer;

namespace BusinessManagementLayer.Business_Managers
{
    public class HelloWorldManager
    {
        public HelloWorldDBService _helloWorldDBService = null;
    
        /// <summary>
        /// Constructor
        /// </summary>
        public HelloWorldManager()
        {
            _helloWorldDBService = new HelloWorldDBService();
            //FarmerPlusDataAccessLayer.DataObjects.
        }

        /// <summary>
        /// This function have all business logic for extracting the Hello World Message.
        /// </summary>
        /// <returns></returns>
        public HelloWorldDAO TakeTheHelloWorldMessage(int messageId)
        {
            HelloWorldDAO helloWorldDataToReturn = _helloWorldDBService.GetHelloWorldMessage(messageId);
            return helloWorldDataToReturn;
        }
    }
}
