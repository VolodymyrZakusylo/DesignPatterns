using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class EnemyBuilder : IHeroBuilder
    {
        private Hero enemy = new Hero();
        public IHeroBuilder SetHeight(string height)
        {
            enemy.Height = height;
            return this;
        }

        public IHeroBuilder SetClothing(string clothing)
        {
            enemy.Clothing = clothing;
            return this;
        }

        public IHeroBuilder SetHairColor(string hairColor)
        {
            enemy.HairColor = hairColor;
            return this;
        }

        public IHeroBuilder SetInventory(string inventory)
        {
            enemy.Inventory = inventory;
            return this;
        }

        public Hero Build()
        {
            return enemy;
        }
    }
}
