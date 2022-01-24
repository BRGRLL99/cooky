using Domain.Cookies;
using Domain.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Mappers
{
    public static class PackageMapper
    {

        public static PackageDto MapPackageToDto(Package package)
        {
            return new PackageDto {
                PackageCode = package.PackageCode.ToString(),
                CookieQuantity = package.Cookies.Count
            };
        }
    }
}
