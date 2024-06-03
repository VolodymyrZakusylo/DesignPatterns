using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    public class Virus : IPrototype
    {
        public double Weight;
        public int Age;
        public string Name;
        public string Type;
        public List<Virus> Children { get; set; } = new List<Virus>();
        public Virus(double weight, int age, string name, string type, Virus children)
        {
            Weight = weight;
            Age = age;
            Name = name;
            Type = type;
            Children.Add(children);
        }

        public Virus(Virus prototype)
        {
            this.Weight = prototype.Weight;
            this.Age = prototype.Age;
            this.Name = prototype.Name;
            this.Type = prototype.Type;
            this.Children = new List<Virus>(prototype.Children);
        }

        public IPrototype Clone()
        {
            return new Virus(this);
        }
        public void DisplayVirus()
        {
            Console.WriteLine($"Name: {Name}, Weight: {Weight}, Age: {Age}, Type: {Type}");
        }
    }
}
