using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public abstract class Cookie
    {
        public Guid CookieId { get; set; }
        public Flavour Flavour { get; set; }

        public Cookie()
        {
            this.CookieId = Guid.NewGuid();
        }
    }
}
