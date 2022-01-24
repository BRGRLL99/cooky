using Domain.Cookies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstractions.Persistence
{
    public interface IPackageRepository
    {
        Task<Package>  PersistPackage(Package package);
    }
}
