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
    public partial class CMSWarningManager : Form
    {
        public string recordedVoice = "";
        ServiceReferenceCommonHelper.CommonHelperServiceClient commonServiceClient = new FarmerPlusClient.ServiceReferenceCommonHelper.CommonHelperServiceClient();

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
        //Private ArabicInput As InputLanguage
        private InputLanguage UrduLanguage;
        private InputLanguage EnglishLanguage;

        public CMSWarningManager()
        {
            InitializeComponent();
        }

        private void CMSMarketingManager_Load(object sender, EventArgs e)
        {
            AssignLanguage();
            FillDropDownList();

            this.comboBoxAnnouncementType.SelectedIndex = 0;
            this.comboBoxMessageType.SelectedIndex = 0;

        }

        void FillDropDownList()
        {
            
            DataSet districtsDS = commonServiceClient.GetDistrictsList();

            this.comboBoxDistrict.ValueMember = "ID";
            this.comboBoxDistrict.DisplayMember = "VALUE";           
            this.comboBoxDistrict.DataSource = districtsDS.Tables[0];
            
        }

        private void AssignLanguage()
        {
            int count = InputLanguage.InstalledInputLanguages.Count;
            for (int i = 0; i < count; i++)
            {

                if (InputLanguage.InstalledInputLanguages[i].LayoutName.Contains("Urdu") == true)
                {
                    UrduLanguage = InputLanguage.InstalledInputLanguages[i];

                }
                else if (InputLanguage.InstalledInputLanguages[i].LayoutName.Contains("US") == true)
                {
                    EnglishLanguage = InputLanguage.InstalledInputLanguages[i];

                }
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = UrduLanguage;

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            InputLanguage.CurrentInputLanguage = EnglishLanguage;
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            int dist_id = 0;
            int city_id = 0;
            DataTable dsPhoneNumbers = null;

            dist_id = int.Parse(this.comboBoxDistrict.SelectedValue.ToString());
            city_id = int.Parse(this.comboBoxCity.SelectedValue.ToString());

            if (city_id == 15000)
            {
                dsPhoneNumbers = commonServiceClient.GetCallerOfADistrict(dist_id).Tables[0];
            }

            else
            {
                dsPhoneNumbers = commonServiceClient.GetCallerOfACity(city_id).Tables[0];
            }

            //commonServiceClient
            //string messageString = txtMessage.Text;

            foreach(DataRow rowWalker in dsPhoneNumbers.Rows)
            {
                ThrowSms(txtMessage.Text, rowWalker[0].ToString());
            }
        }


        private void ThrowSms(string SmsMessage, string number)
        {
            
            Service srv;
            srv = Service.getInstance();

            // *** The tricky part ***
            // *** Comm2IP Driver ***
            // Create (and start!) as many Comm2IP threads as the modems you are using.
            // Be careful about the mappings - use the same mapping in the Gateway definition.
            Comm2IP.Comm2IP com1 = new Comm2IP.Comm2IP(new byte[] { 127, 0, 0, 1 }, 12000, "com13", 115200);


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
                IPModemGateway gateway = new IPModemGateway("modem.com13", "127.0.0.1", 12000, "Samsung", "SGH-M200");
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

                OutboundMessage msg = new OutboundMessage(number, SmsMessage + " \n\r (Farmer Plus)");
                // OutboundMessage msg = new OutboundMessage("+923334641538",  SmsMessage );
                //msg.setEncoding(MessageEncodings.ENCUCS2);

                msg.setEncoding(org.smslib.Message.MessageEncodings.ENCUCS2);
                srv.sendMessage(msg);




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

        private void button1_Click(object sender, EventArgs e)
        {
            FarmerPlusRecorder recorder = new FarmerPlusRecorder();
            recorder.ShowDialog();
            recordedVoice = recorder.filePathToReturn;
        }

        private void comboBoxDistrict_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet citiesDS = commonServiceClient.GetCitiesInADistrict(int.Parse(this.comboBoxDistrict.SelectedValue.ToString()));
            DataRow newCityRow = citiesDS.Tables[0].NewRow();

            newCityRow[0] = 150000;
            newCityRow[1] = "--";

            citiesDS.Tables[0].Rows.InsertAt(newCityRow, 0);
            

            this.comboBoxCity.DataSource = citiesDS.Tables[0];
            this.comboBoxCity.ValueMember = "ID";
            this.comboBoxCity.DisplayMember = "VALUE";
        }






    }
}
