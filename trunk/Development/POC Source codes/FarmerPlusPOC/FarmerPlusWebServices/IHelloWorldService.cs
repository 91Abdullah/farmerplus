using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using FarmerPlusDataAccessLayer;

namespace FarmerPlusWebServices
{
    // NOTE: If you change the interface name "IHelloWorldService" here, you must also update the reference to "IHelloWorldService" in App.config.
    [ServiceContract]
    public interface IHelloWorldService
    {
        [OperationContract]
        HelloWorldDAO GetHelloWorldMessage(int messageId);
    }
}
