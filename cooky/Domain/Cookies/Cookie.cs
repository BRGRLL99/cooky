using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public abstract class Cookie
    {
        public int CookieId { get; set; }
        public Flavour Flavour { get; set; }
    }
}
