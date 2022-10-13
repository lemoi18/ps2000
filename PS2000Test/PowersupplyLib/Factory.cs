using PSUManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowersupplyLib
{
    public static class Factory
    {


        public static IPSU CreatePSU()
        {
            return new PSUMan();
        }
    }
}
