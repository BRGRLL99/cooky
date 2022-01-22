using Domain.Cookies;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Creatures
{
    public class Ogre : Creature
    {
        public Ogre()
        {
            //Empty Constructor
        }

        public Ogre(string Name)
        {
            this.Name = Name;
        }

        public override void EatCookies()
        {

        }
    }
}
