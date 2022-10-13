using PSULibrary;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2000
{
    internal class TestPsu : IPSU
    {

        private string? comlink;

        public string? GetComlink()
        {
            return comlink;
        }

        public void SetComlink(string? value)
        {
            comlink = value;
        }


        private double m_Voltage = 0.0;
        

        public double GetVoltage()
        {
            return m_Voltage;
        }

        public List<byte> SendTelegram(string COM, byte[] bytesToSend)
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


        public string Get_DType(byte three, byte five, int obj)
        {


                List<byte> Serialresponse;
                // Remember the dataframe setup, SD, DN,   OBJ, DATA checksum1, checksum2
                // OBJ = 0x01 = 1
                byte[] serialBytesToSend = { 0x7F, 0x00, three, 0x00, five };

                Serialresponse = SendTelegram(GetComlink(), serialBytesToSend);
               

                    string binary = Convert.ToString(Serialresponse[0], 2);
                    string payloadLengtBinaryString = binary.Substring(4);
                    int payloadLength = Convert.ToInt32(payloadLengtBinaryString, 2);

                    string serialNumberString = "";

                    if (Serialresponse[2] == obj) // means that I got a response on obj, which is refers to the object list.
                    {
                        for (var i = 0; i < payloadLength; i++)
                        {
                            serialNumberString += Convert.ToChar(Serialresponse[3 + i]);
                        }
                    }

                    Console.WriteLine(string.Format("serialNumberString:{0}", serialNumberString));
                    return serialNumberString;
                }

            
        

        public double Remote_Off(byte five, byte seven)
        {
            throw new NotImplementedException();
        }

        public double Remote_On(byte four, byte five, byte seven)
        {
            throw new NotImplementedException();
        }

      

        public void SetVoltage(float Value, byte three)
        {
            m_Voltage = Value;
        }
    }
}
