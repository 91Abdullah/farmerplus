using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;


namespace FarmerPlusDataAccessLayer
{
    [DataContract]
    public class HelloWorldDAO
    {
        /// <summary>
        /// String variable containing the Hello World Message
        /// </summary>
        private string _strHelloWorldMessage = null;


        /// <summary>
        /// The public Accessor for _strHelloWorldMessage
        /// </summary>
        [DataMember]
        public string StrHelloWorldMessage
        {
            get { return _strHelloWorldMessage; }
            set { _strHelloWorldMessage = value; }
 
        }
    }
}
