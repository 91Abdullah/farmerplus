using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarmerPlusDataObjectLayer;
using System.Threading;
using org.smslib;
using org.smslib.modem;


namespace FarmerPlusClient
{
    public partial class SMSWeather : Form
    {


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

        public SMSWeather()
        {
            InitializeComponent();
        }



       
        private void SMSWeather_Load(object sender, EventArgs e)
        {

            string input;

            // The string that will represent the entered command.
            // Will be a substring of input.
           string command = string.Empty;

           input = "cc lahore";

            command = input.Substring(0, 2);

            Conditions conditions = new Conditions();


            WeatherServicesReference.WeatherServicesClient Ws = new FarmerPlusClient.WeatherServicesReference.WeatherServicesClient();


            conditions = Ws.GetCurrentConditions(input.Substring(2, input.Length - 2));

            string messageString="";

            FillTxtDiaplay(ref conditions, ref messageString );

            ThrowSms(messageString);

           
           
        }

       

        private void FillTxtDiaplay(ref Conditions conditions, ref string messageString)
        {

            if (conditions != null)
            {
              // txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes;

                messageString = "موسم:" + conditions.Condition;// +"\r\n"; ;
            //   txtDisplay.Text = txtDisplay.Text + "درجہ حرارت (°F): " + conditions.TempF;
              //  txtDisplay.Text = txtDisplay.Text + "درجہ حرارت " + conditions.TempC + "\r\n"; ; //+ System.Environment.NewLine;
             //  txtDisplay.Text = txtDisplay.Text + conditions.Humidity;// + "\r\n";
            //  txtDisplay.Text = txtDisplay.Text + conditions.Wind;
                //txtDisplay.Text = txtDisplay.Text + "Humidity: " + conditions.Humidity + "\r\n";
                //txtDisplay.Text = txtDisplay.Text + "Wind:" + conditions.Wind;



                ////txtDisplay.Text = "Condition:" + conditions.Condition;
                //txtDisplay.Text = "Condition:" + conditions.Condition + "\r\n";
                //txtDisplay.Text = txtDisplay.Text + "Temperature (°F): " + conditions.TempF + "\r\n";
                //txtDisplay.Text = txtDisplay.Text + "Temperature (°C): " + conditions.TempC + System.Environment.NewLine;
                //txtDisplay.Text = txtDisplay.Text + conditions.Humidity + "\r\n";
                //txtDisplay.Text = txtDisplay.Text + conditions.Wind;
                ////txtDisplay.Text = txtDisplay.Text + "Humidity: " + conditions.Humidity + "\r\n";
                ////txtDisplay.Text = txtDisplay.Text + "Wind:" + conditions.Wind;

                txtDisplay.Text = messageString;
            }
            else
            {
                txtDisplay.Text = "There was an error processing the request." + System.Environment.NewLine;
                txtDisplay.Text = "Please, make sure you are using the correct location or try again later.";

            }
        }

        private void ThrowSms (string SmsMessage)
        {
            Service srv;
            srv = Service.getInstance();

            // *** The tricky part ***
            // *** Comm2IP Driver ***
            // Create (and start!) as many Comm2IP threads as the modems you are using.
            // Be careful about the mappings - use the same mapping in the Gateway definition.
            Comm2IP.Comm2IP com1 = new Comm2IP.Comm2IP(new byte[] { 127, 0, 0, 1 }, 12000, "com7", 115200);


            try
            {
               // Console.WriteLine("Example: Read messages from a serial gsm modem.");
                //Console.WriteLine(Library.getLibraryDescription());
                //Console.WriteLine("Version: " + Library.getLibraryVersion());

                // Start the COM listening thread.
                new Thread(new ThreadStart(com1.Run)).Start();

                // Lets set some callbacks.
                srv.setInboundMessageNotification(new InboundNotification());
                srv.setCallNotification(new CallNotification());
                srv.setGatewayStatusNotification(new GatewayStatusNotification());
                

                // Create the Gateway representing the serial GSM modem.
                // Due to the Comm2IP bridge, in SMSLib for .NET all modems are considered IP modems.
                IPModemGateway gateway = new IPModemGateway("modem.com7", "127.0.0.1", 12000, "Samsung", "SGH-M200");
                gateway.setIpProtocol(ModemGateway.IPProtocols.BINARY);

                // Set the modem protocol to PDU (alternative is TEXT). PDU is the default, anyway...
                gateway.setProtocol(AGateway.Protocols.PDU);

                // Do we want the Gateway to be used for Inbound messages?
                gateway.setInbound(true);

                // Do we want the Gateway to be used for Outbound messages?
                gateway.setOutbound(true);

                // Let SMSLib know which is the SIM PIN.
                gateway.setSimPin("0000");

                // Explicit SMSC address set is required for some modems.
                // Below is for VODAFONE GREECE - be sure to set your own!
                // gateway.setSmscNumber("+306942190000");

                // Add the Gateway to the Service object.
                srv.addGateway(gateway);

                // Similarly, you may define as many Gateway objects, representing
                // various GSM modems, add them in the Service object and control all of them.

                // Start! (i.e. connect to all defined Gateways)
                srv.startService();
              
                // Printout some general information about the modem.
                //Console.WriteLine();
                //Console.WriteLine("Modem Information:");
                //Console.WriteLine("  Manufacturer: " + gateway.getManufacturer());
                //Console.WriteLine("  Model: " + gateway.getModel());
                //Console.WriteLine("  Serial No: " + gateway.getSerialNo());
                //Console.WriteLine("  SIM IMSI: " + gateway.getImsi());
                //Console.WriteLine("  Signal Level: " + gateway.getSignalLevel() + "dBm");
                //Console.WriteLine("  Battery Level: " + gateway.getBatteryLevel() + "%");
                //Console.WriteLine();

   // MessageEncodings.ENCUCS2 
                // Send one message.
                // Remember to change the recipient!
              //  OutboundMessage msg = new OutboundMessage("+923004529366", SmsMessage);

                //Tahir +923334388447
                //Qasim +923004529366
                // Waqar Sb +923458490007
                // Amber +923334706336

                OutboundMessage msg = new OutboundMessage("+923458490007", "لاہور کا موسم  " + SmsMessage + " \n\r (Farmer Plus)");
               // OutboundMessage msg = new OutboundMessage("+923334641538",  SmsMessage );
               //msg.setEncoding(MessageEncodings.ENCUCS2);
                
                msg.setEncoding(org.smslib.Message.MessageEncodings.ENCUCS2);
                srv.sendMessage(msg);
                
               

                txtDisplay.Text = txtDisplay.Text + "\n\r" + "Message Sent";
                //Console.WriteLine(msg);

                // Send more than one message at once.
                //OutboundMessage[] msgArray = new OutboundMessage[2];
                //msgArray[0] = new OutboundMessage("+306948494037", "Hello from SMSLib for .NET (#1)");
                //msgArray[1] = new OutboundMessage("+306948494037", "Hello from SMSLib for .NET (#2)");
                //srv.sendMessages(msgArray);
                //Console.WriteLine(msgArray[0]);
                //Console.WriteLine(msgArray[1]);

               // Console.WriteLine("Press <ENTER> to terminate...");
                //Console.In.ReadLine();
            }
            catch (Exception e)
            {
                //Console.WriteLine(e.Message);
                //Console.WriteLine(e.StackTrace);
            }
            finally
            {
                com1.Stop();
                srv.stopService();
            }
        }


        public void RecieveSms()
        {
            // Create new Service object - the parent of all and the main interface to you.
            Service srv;
            srv = Service.getInstance();

            // *** The tricky part ***
            // *** Comm2IP Driver ***
            // Create (and start!) as many Comm2IP threads as the modems you are using.
            // Be careful about the mappings - use the same mapping in the Gateway definition.
            Comm2IP.Comm2IP com1 = new Comm2IP.Comm2IP(new byte[] { 127, 0, 0, 1 }, 12000, "com7", 115200);

            try
            {
                //Console.WriteLine("Example: Read messages from a serial gsm modem.");
                //Console.WriteLine(Library.getLibraryDescription());
                //Console.WriteLine("Version: " + Library.getLibraryVersion());

                // Start the COM listening thread.
                new Thread(new ThreadStart(com1.Run)).Start();

                // Lets set some callbacks.
                srv.setInboundMessageNotification(new InboundNotification());
                srv.setCallNotification(new CallNotification());
                srv.setGatewayStatusNotification(new GatewayStatusNotification());

                // Create the Gateway representing the serial GSM modem.
                // Due to the Comm2IP bridge, in SMSLib for .NET all modems are considered IP modems.
                IPModemGateway gateway = new IPModemGateway("modem.com7", "127.0.0.1", 12000, "Samsung", "SGH-M200");
                gateway.setIpProtocol(ModemGateway.IPProtocols.BINARY);

                // Set the modem protocol to PDU (alternative is TEXT). PDU is the default, anyway...
                gateway.setProtocol(AGateway.Protocols.PDU);

                // Do we want the Gateway to be used for Inbound messages?
                gateway.setInbound(true);

                // Do we want the Gateway to be used for Outbound messages?
                gateway.setOutbound(true);

                // Let SMSLib know which is the SIM PIN.
                gateway.setSimPin("0000");

                // Add the Gateway to the Service object.
                srv.addGateway(gateway);

                // Similarly, you may define as many Gateway objects, representing
                // various GSM modems, add them in the Service object and control all of them.

                // Start! (i.e. connect to all defined Gateways)
                srv.startService();

                //// Printout some general information about the modem.
                //Console.WriteLine();
                //Console.WriteLine("Modem Information:");
                //Console.WriteLine("  Manufacturer: " + gateway.getManufacturer());
                //Console.WriteLine("  Model: " + gateway.getModel());
                //Console.WriteLine("  Serial No: " + gateway.getSerialNo());
                //Console.WriteLine("  SIM IMSI: " + gateway.getImsi());
                //Console.WriteLine("  Signal Level: " + gateway.getSignalLevel() + "dBm");
                //Console.WriteLine("  Battery Level: " + gateway.getBatteryLevel() + "%");
                //Console.WriteLine();

                // Read Messages. The reading is done via the Service object and
                // affects all Gateway objects defined. This can also be more directed to a specific
                // Gateway - look the JavaDocs for information on the Service method calls.
                InboundMessage[] msgList = srv.readMessages(org.smslib.InboundMessage.MessageClasses.ALL);
                foreach (InboundMessage msg in msgList)
                Console.WriteLine(msg);
               
                //Console.WriteLine("Press <ENTER> to terminate...");
                //Console.In.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            finally
            {
                com1.Stop();
                srv.stopService();
            }
        }
        
    }
}
