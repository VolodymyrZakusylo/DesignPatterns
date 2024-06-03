using ClassLibrary1;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        Product sausages = new Product("Ковбаски", new Hryvnya(170, 80), "Ковбаски зі свинини", 50);
        Product bread = new Product("Хліб", new Hryvnya(30, 50), "Чорний хліб", 20);
        Product milk = new Product("Молоко", new Euro(1, 50), "Молоко рудь, 1л", 40);
        Reporting reporting = new Reporting();
        Warehouse warehouse = new Warehouse();
        warehouse.AddItem(sausages);
        warehouse.AddItem(milk);
        reporting.WarehouseReport(warehouse);
        reporting.incomingRegister(new List<Product> { sausages, bread, milk }, DateTime.Now);
        reporting.salesInvoice(new List<Product> { sausages }, DateTime.Now);
    }
}