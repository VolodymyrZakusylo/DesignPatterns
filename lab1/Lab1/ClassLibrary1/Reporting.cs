using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Reporting
    {
        public void incomingRegister(List<Product> products, DateTime date)
        {
            Console.WriteLine($"{products.Count} товарів прибуло в {date}");
        }
        public void salesInvoice(List<Product> products, DateTime date)
        {
            Console.WriteLine($"{products.Count} товарів продано в {date}");
        }
        public void WarehouseReport(Warehouse warehouse)
        {
            Console.WriteLine("Товари, що знаходяться на складі:");
            foreach (Product product in warehouse.GetProducts())
            {
                Console.WriteLine($"Назва: {product.Name} - Ціна: {product.Price} - Кількість: {product.Quantity}");
            }
        }
    }
}
