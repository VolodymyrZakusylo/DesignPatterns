using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public interface ISmartphone
    {
        string CPU { get; set; }
        string GPU { get; set; }
    }
}
