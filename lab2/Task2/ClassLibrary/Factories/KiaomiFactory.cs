using ClassLibrary.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Factories
{
    public class KiaomiFactory : IDevicesFactory
    {
        public ILaptop CreateLaptop() => new LaptopKiaomi("Ryzen 7", "RTX 3050");
        public INetbook CreateNetbook() => new NetbookKiaomi("Intel core i3", "GTX 960");
        public IEBook CreateEBook() => new EBookKiaomi("Intel pentium", "720");
        public ISmartphone CreateSmartphone() => new SmartphoneKiaomi("Snapdragon", "Qualcomm");
    }
}
