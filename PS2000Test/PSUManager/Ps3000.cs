using PSULibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2000
{
    internal class Ps3000 : IPSU
    {


        public string? GetComlink()
        {
            throw new NotImplementedException();
        }

        public double GetVoltage()
        {
            throw new NotImplementedException();
        }

        public string Get_DType(byte three, byte five, int obj)
        {
            throw new NotImplementedException();
        }

        public double Remote_Off(byte five, byte seven)
        {
            throw new NotImplementedException();
        }

        public double Remote_On(byte four, byte five, byte seven)
        {
            throw new NotImplementedException();
        }

        public void SetComlink(string? value)
        {
            throw new NotImplementedException();
        }

        public void SetVoltage(float Value, byte three)
        {
            throw new NotImplementedException();
        }
    }
}
