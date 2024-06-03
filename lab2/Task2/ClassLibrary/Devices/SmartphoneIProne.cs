using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public class SmartphoneIProne : ISmartphone
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public SmartphoneIProne(string cpu, string gpu)
        {
            CPU = cpu;
            GPU = gpu;
        }
    }
}
