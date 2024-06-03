using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Product
    {
        public string Name { get; set; }
        public Money Price { get; set; }
        public int Quantity { get; set; }
        public string Description { get; set; }

        public Product(string name, Money price, string description, int quantity)
        {
            this.Name = name;
            this.Price = price;
            this.Description = description;
            this.Quantity = quantity;
        }

        public void updatePrice(Money price)
        {
            this.Price = price;
        }

        public string getInfo()
        {
            return $"Ім'я продукту: {Name}\nЦіна: {Price}\nКількість: {Quantity}\nОпис: {Description}";
        }
    }
}
