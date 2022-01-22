using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Exceptions
{
    public class PackageNullOrEmptyException : Exception
    {
        public PackageNullOrEmptyException(string message) : base(message)
        {
        }
    }
}
