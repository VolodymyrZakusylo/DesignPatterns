using ClassLibrary.Devices;
using ClassLibrary.Factories;

internal class Program
{
    private static void Main(string[] args)
    {
        IDevicesFactory factory = new KiaomiFactory();
        ILaptop laptop = factory.CreateLaptop();
        INetbook netbook = factory.CreateNetbook();
        IEBook ebook = factory.CreateEBook();
        ISmartphone smartphone = factory.CreateSmartphone();
        Console.WriteLine("Kiaomi factoru: ");
        Console.WriteLine($"laptop CPU: {laptop.CPU} - GPU: {laptop.GPU}");
        Console.WriteLine($"netbook CPU: {netbook.CPU} - GPU: {netbook.GPU}");
        Console.WriteLine($"ebook CPU: {ebook.CPU} - Screen resolution: {ebook.ScreenResolution}");
        Console.WriteLine($"smartphone CPU: {smartphone.CPU} - GPU: {smartphone.GPU}");
        IDevicesFactory factory2 = new IProneFactory();
        ILaptop laptop2 = factory2.CreateLaptop();
        INetbook netbook2 = factory2.CreateNetbook();
        IEBook ebook2 = factory2.CreateEBook();
        ISmartphone smartphone2 = factory2.CreateSmartphone();
        Console.WriteLine("IProne factoru: ");
        Console.WriteLine($"laptop CPU: {laptop.CPU} - GPU: {laptop.GPU}");
        Console.WriteLine($"netbook CPU: {netbook.CPU} - GPU: {netbook.GPU}");
        Console.WriteLine($"ebook CPU: {ebook.CPU} - Screen resolution: {ebook.ScreenResolution}");
        Console.WriteLine($"smartphone CPU: {smartphone.CPU} - GPU: {smartphone.GPU}");
    }
}