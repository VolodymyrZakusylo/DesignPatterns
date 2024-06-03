using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public class SmartphoneKiaomi : ISmartphone
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public SmartphoneKiaomi(string cpu, string gpu)
        {
            CPU = cpu;
            GPU = gpu;
        }
    }
}
