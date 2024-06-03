using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public class NetbookKiaomi : INetbook
    {
        public string CPU { get; set; }
        public string GPU { get; set; }
        public NetbookKiaomi(string cpu, string gpu)
        {
            CPU = cpu;
            GPU = gpu;
        }
    }
}
