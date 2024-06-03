using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public class LaptopIProne : ILaptop
    {
        public string GPU { get; set; }
        public string CPU { get; set; }
        public LaptopIProne(string gpu, string cpu)
        {
            GPU = gpu;
            CPU = cpu;
        }
    }
}
