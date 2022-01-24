using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Cookies
{
    public class Package
    {
        public Guid PackageCode { get; set; }

        public List<Cookie> Cookies { get; set; }

        public Package(List<Cookie> cookies)
        {
            this.PackageCode = Guid.NewGuid();
            this.Cookies = cookies;
        }
    }
}
