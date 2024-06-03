using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public interface IHeroBuilder
    {
        IHeroBuilder SetHeight(string height);
        IHeroBuilder SetClothing(string clothing);
        IHeroBuilder SetHairColor(string hairColor);
        IHeroBuilder SetInventory(string inventory);
        Hero Build();
    }
}
