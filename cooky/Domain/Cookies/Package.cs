using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public class Package
    {
        public int PackageCode { get; set; }

        public List<Cookie> Cookies { get; set; }
    }
}
