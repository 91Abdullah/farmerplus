using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FarmerPlusDataObjectLayer;
using System.Threading;
using org.smslib;
using org.smslib.modem;

namespace FarmerPlusClient
{
    class WeatherUpdate
    {
        ServiceReferenceCommonWeather.CommonWeatherServicesClient weatherServiceClient = new ServiceReferenceCommonWeather.CommonWeatherServicesClient();


        public class CallNotification : ICallNotification
        {
            public void process(AGateway gateway, String callerId)
            {
                Console.WriteLine(">>> New call detected from Gateway: " + gateway.getGatewayId() + " : " + callerId);
            }
        }

        public class InboundNotification : IInboundMessageNotification
        {
            public void process(AGateway gateway, org.smslib.Message.MessageTypes msgType, InboundMessage msg)
            {
                if (msgType == org.smslib.Message.MessageTypes.INBOUND) Console.WriteLine(">>> New Inbound message detected from Gateway: " + gateway.getGatewayId());
                else if (msgType == org.smslib.Message.MessageTypes.STATUSREPORT) Console.WriteLine(">>> New Inbound Status Report message detected from Gateway: " + gateway.getGatewayId());
                Console.WriteLine(msg);
                try
                {
                    // Uncomment following line if you wish to delete the message upon arrival.
                    gateway.deleteMessage(msg);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oops!!! Something gone bad...");
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.StackTrace);
                }
            }
        }

        public class GatewayStatusNotification : IGatewayStatusNotification
        {
            public void process(AGateway gateway, org.smslib.AGateway.GatewayStatuses oldStatus, org.smslib.AGateway.GatewayStatuses newStatus)
            {
                Console.WriteLine(">>> Gateway Status change for " + gateway.getGatewayId() + ", OLD: " + oldStatus + " -> NEW: " + newStatus);
            }
        }

        public Conditions GetCurrentWeatherConditions()
        {
            string input;

            // The string that will represent the entered command.
            // Will be a substring of input.
            string command = string.Empty;

            input = "cc lahore";

            command = input.Substring(0, 2);

            Conditions conditions = new Conditions();


            conditions = weatherServiceClient.GetCurrentConditions(input.Substring(2, input.Length - 2));

            return conditions;

        }

    }
}
