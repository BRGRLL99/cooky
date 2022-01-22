using Domain.Cookies;
using Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Creatures
{
    public abstract class Creature
    {
        public String Name { get; set; }
        public Race Race { get; set; }
        public int Happiness { get; set; }

        public Package? Package { get; set; }

        public void GrabPackage(Package package)
        {
            if (package != null && package.Cookies.Count > 0)
            {
                this.Package = package;
            }
            else
            {
                throw new PackageNullOrEmptyException("The package was either null or empty!");
            }

        }

        public abstract void EatCookies();
    }
}
