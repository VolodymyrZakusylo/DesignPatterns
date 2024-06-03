using ClassLibrary.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Factories
{
    public class IProneFactory : IDevicesFactory
    {
        public ILaptop CreateLaptop() => new LaptopIProne("Ryzen 5", "RTX 3070");
        public INetbook CreateNetbook() => new NetbookIProne("Intel core i7", "GTX 980");
        public IEBook CreateEBook() => new EBookIProne("AMD", "1080");
        public ISmartphone CreateSmartphone() => new SmartphoneIProne("Snapdragon", "Qualcomm");
    }
}
