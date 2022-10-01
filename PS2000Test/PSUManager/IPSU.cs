using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PSUManager
{
    public interface IPSU
    {

        public string? Comlink { get; set; }    
        public double GetVoltage();
        public void SetVoltage(float Value, byte three);
    }
}
