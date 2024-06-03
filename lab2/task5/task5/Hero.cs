using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Hero
    {
        public string Height { get; set; }
        public string Clothing { get; set; }
        public string HairColor { get; set; }
        public string Inventory { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Height: {Height}\nClothing: {Clothing}\nHairColor: {HairColor}\nInventory: {Inventory}");
        }
    }
}
