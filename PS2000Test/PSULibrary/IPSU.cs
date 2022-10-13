using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSULibrary
{
     public interface IPSU
    {
        string? GetComlink();
        void SetComlink(string? value);
        public double GetVoltage()
        {
            
        }
        public void SetVoltage(float Value, byte three);
    }

    
}
