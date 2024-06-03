using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task5
{
    public class Director
    {
        public Hero Hero(IHeroBuilder builder)
        {
            return builder.SetHeight("Tall")
                .SetHairColor("Black")
                .SetClothing("mail")
                .SetInventory("Sword")
                .Build();
        }

        public Hero Enemy(IHeroBuilder builder)
        {
            return builder.SetHeight("Tall")
                .SetHairColor("White")
                .SetClothing("Black cloak")
                .SetInventory("Magic Wand")
                .Build();
        }
    }
}
