using PSULibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PS2000
{
    public static class Factory
    {

        public static PSULibrary.IPSU CreatePSU(string name)
        {


            IPSU psu = null;

            if (name.ToUpper() == "PS2000")
                psu = new Ps2000();
            else if (name == "Ps3000")
                psu = new Ps3000();
            else if (name == "Test")
                psu = new TestPsu();
            return psu;
        }
        public static PSULibrary.IPSU CreatePSU()
        {
            IPSU psu = null;

                psu = new Ps2000();
           
            return psu;
        }
    }
}
