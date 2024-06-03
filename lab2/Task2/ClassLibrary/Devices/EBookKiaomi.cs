using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public class EBookKiaomi : IEBook
    {
        public string CPU { get; set; }
        public string ScreenResolution { get; set; }
        public EBookKiaomi(string cpu, string screenResolution)
        {
            CPU = cpu;
            ScreenResolution = screenResolution;
        }
    }
}
