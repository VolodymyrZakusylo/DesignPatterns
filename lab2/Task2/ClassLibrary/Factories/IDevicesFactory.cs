using ClassLibrary.Devices;

namespace ClassLibrary.Factories
{
    public interface IDevicesFactory
    {
        ILaptop CreateLaptop();
        INetbook CreateNetbook();
        IEBook CreateEBook();
        ISmartphone CreateSmartphone();
    }
}