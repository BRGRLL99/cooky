using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public class CreamCookie : Cookie
    {
        public double TotalCream { get; set; }

        public CreamCookie()
        {
            var r = new Random();

            this.Flavour = Flavour.Cream;
            this.TotalCream = r.NextDouble()*100;
        }
    }
}
