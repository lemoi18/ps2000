using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;



namespace PSUManager
{
    public class PSUMan: IPSU
    {



        public  List<byte> SendTelegram(string COM, byte[] bytesToSend)
        {
            

            List<byte> responseTelegram;
            using (SerialPort port = new SerialPort(COM, 115200, 0, 8, StopBits.One))
            {
                Thread.Sleep(500);
                port.Open();
                // write to the USB port
                port.Write(bytesToSend, 0, bytesToSend.Length);
                Thread.Sleep(500);

                responseTelegram = new List<byte>();
                int length = port.BytesToRead;
                if (length > 0)
                {
                    byte[] message = new byte[length];
                    port.Read(message, 0, length);
                    foreach (var t in message)
                    {
                        //Console.WriteLine(t);
                        responseTelegram.Add(t);
                    }
                }
                port.Close();
                Thread.Sleep(500);
                return responseTelegram;    
            }
        }

        public List<string> checksum(int sum, byte[] bytesToCheck)
        {
            //SD = MessageType + CastType + Direction + Length
            //int SDHex = (int)0x40 + (int)0x20 + 0x10 + 5; //6-1 ref spec 3.1.1
            //byte SD = Convert.ToByte(SDHex.ToString(), 10);

            //SD, DN, OBJ, DATA, CS
            //byte[] byteWithOutCheckSum = { SD, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status

            int arrayLength = bytesToCheck.Length;

            string hexSum = sum.ToString("X");
            string cs1 = "";
            string cs2 = "";
            if (hexSum.Length == 4)
            {
                cs1 = hexSum.Substring(0, hexSum.Length / 2);
                cs2 = hexSum.Substring(hexSum.Length / 2);
            }
            else if (hexSum.Length == 3)
            {
                cs1 = hexSum.Substring(0, 1);
                cs2 = hexSum.Substring(1);
            }
            else if ((hexSum.Length is 2) || (hexSum.Length is 1))
            {
                cs1 = "0";
                cs2 = hexSum;
            }

            if (cs1 != "")
            {


                bytesToCheck[arrayLength - 2] = Convert.ToByte(cs1, 16);
                bytesToCheck[arrayLength - 1] = Convert.ToByte(cs2, 16);
            }
            List<string> checksum;
            checksum = new List<string> { cs1, cs2 };
            return checksum;
        }

        public double GetVoltage()
        {
            double volt;
            int percentVolt = 0;
            double nominalVoltage = 0;

            int SDHex = (int)0x40 + (int)0x20 + 0x10 + 5; //6-1 ref spec 3.1.1
            byte SD = Convert.ToByte(SDHex.ToString(), 10);
            byte[] byteWithOutCheckSum = { SD, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status
            List<byte> checksum = SendTelegram("com4", byteWithOutCheckSum);
            byte[] bytesToSend = { 0x74, 0x00, 0x02, 0x00, 0x76 };

            List<byte> voltageFromTele = SendTelegram("com4", bytesToSend);

            if (voltageFromTele == null)
            {
                Console.WriteLine("No telegram was read");
                return -1;
            }
            else
            {
                byte[] byteArray = { voltageFromTele[6], voltageFromTele[5], voltageFromTele[4], voltageFromTele[3] };
                nominalVoltage = BitConverter.ToSingle(byteArray, 0);
                volt = (double)percentVolt * nominalVoltage / 25600;
                Console.WriteLine(string.Format("Voltage:{0}", volt));
                return (double)volt;
            }
        }
        public double Get_Nominal(byte three, byte five)
        {
            float nominalVoltage = 0;
            // get nominal voltage
            
            byte[] bytesToSend = { 0x74, 0x00, three, 0x00, five };
            List<byte> response = SendTelegram("com4", bytesToSend);


            if (response == null)
            {
                Console.WriteLine("No telegram was read");
                return -1;
            }
            else
            {
                byte[] byteArray = { response[6], response[5], response[4], response[3] };
                nominalVoltage = BitConverter.ToSingle(byteArray, 0);

                return (double)nominalVoltage;
            }
        }

        public void SetVoltage(float Value, byte three)
        {

            Remote_On(0x10, 0x10, 0x47);
            byte[] byteWithOutCheckSum = { 0xF2, (int)0x00, (int)0x47, 0x0, 0x0 }; // quert status
            int sum = 0;
            int arrayLength = byteWithOutCheckSum.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                sum += byteWithOutCheckSum[i];
            }

            if (Value > 83)
            {
                Value = 84;
            }
            float setVolt = Value;
            int percentSetValue = (int)Math.Round((25600 * setVolt) / 84);
            List<string> listwithcheck = checksum(percentSetValue, byteWithOutCheckSum);
            
            byte[] newbytesWithoutChecksum = { 0xF2, 0x00, three, Convert.ToByte(listwithcheck[0], 16), Convert.ToByte(listwithcheck[1], 16), 0x0, 0x0 };

            List<string> listwithcheckafter = checksum(0, newbytesWithoutChecksum);

           
            List<byte> newResponseTelegram = SendTelegram("com4", newbytesWithoutChecksum);

            if (newResponseTelegram[3] == 0)
            {
                Console.WriteLine("New voltage was set");
               
            }
            else
            {
                Console.WriteLine(newResponseTelegram[3].ToString());
                
            }

        }



        public double Remote_On(byte four, byte five, byte seven)
        {

            byte[] bytesToSendToTurnOnRC = new byte[] { 0xF1, 0x00, 0x36, four, five, 0x01, seven }; // Turn on remote control
            List<byte> RCresponse = SendTelegram("Com4", bytesToSendToTurnOnRC);

            if (RCresponse[3] == 0)
            {
                Console.WriteLine("Remote Control is turned on");
                return Convert.ToDouble(1);
            }
            else
            {
                Console.WriteLine(String.Format("Remote control is not turned on due to error: {0}", RCresponse[3].ToString()));
                return Convert.ToDouble(-1);
            }
        }

        
    }

    



    }