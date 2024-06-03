using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Devices
{
    public interface ILaptop
    {
        string GPU { get; set; }
        string CPU { get; set; }
    }
}
