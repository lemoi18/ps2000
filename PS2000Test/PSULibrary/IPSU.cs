using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace PSULibrary
{
     public interface IPSU
    {
        string? GetComlink();
        void SetComlink(string? value);
        public double GetVoltage();

        public void SetVoltage(float Value, byte three);

        public double Remote_On(byte four, byte five, byte seven);

        public double Remote_Off(byte five, byte seven);

        public string Get_DType(byte three, byte five, int obj);



    }



}
