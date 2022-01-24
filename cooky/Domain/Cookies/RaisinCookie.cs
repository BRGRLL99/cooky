using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public class RaisinCookie : Cookie
    {
        public bool ActuallyHasRaisins { get; set; }

        public RaisinCookie() : base()
        {
            var r = new Random();

            this.Flavour = Flavour.Raisin;
            this.ActuallyHasRaisins = r.NextDouble() > 0.5;
        }
    }
}
