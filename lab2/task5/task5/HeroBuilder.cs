using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class HeroBuilder : IHeroBuilder
    {
        private Hero hero = new Hero();

        public IHeroBuilder SetHeight(string height)
        {
            hero.Height = height;
            return this;
        }

        public IHeroBuilder SetClothing(string clothing)
        {
            hero.Clothing = clothing;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
            hero.HairColor = hairColor;
            return this;
        }


        public IHeroBuilder SetInventory(string inventory)
        {
            hero.Inventory = inventory;
            return this;
        }

        public Hero Build()
        {
            return hero;
        }
    }
}
