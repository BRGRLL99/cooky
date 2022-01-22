using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Creatures
{
    public class Troll : Creature
    {
        public Troll()
        {
            //Empty Constructor
        }

        public Troll(string Name)
        {
            this.Name = Name;
        }

        public override void EatCookies()
        {

        }
    }
}
