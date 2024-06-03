using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Warehouse
    {
        public List<Product> products = new List<Product>();
        public DateTime deliveryTime { get; set; }
        public void AddItem(Product product)
        {
            products.Add(product);
            deliveryTime = DateTime.Now;
        }
        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }
        public List<Product> GetProducts()
        {
            return products;
        }
    }
}
