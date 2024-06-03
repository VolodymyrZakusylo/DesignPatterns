using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public class LaptopKiaomi : ILaptop
    {
        public string GPU { get; set; }
        public string CPU { get; set; }
        public LaptopKiaomi(string gpu, string cpu)
        {
            GPU = gpu;
            CPU = cpu;
        }
    }
}
