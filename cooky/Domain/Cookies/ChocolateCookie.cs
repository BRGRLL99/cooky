using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public class ChocolateCookie : Cookie
    {
        public int ChocolateChips { get; set; }

        public ChocolateCookie()
        {
            var r = new Random();

            this.Flavour = Flavour.Chocolate;
            this.ChocolateChips = r.Next(1, 11);

        }
    }
}
