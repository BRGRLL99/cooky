using Abstractions.Persistence;
using Abstractions.Services;
using Domain.Cookies;
using Domain.DTOs;
using Domain.Mappers;

namespace Services
{
    public class PackageService : IPackageService
    {
        private IPackageRepository _packageRepository;

        public PackageService(IPackageRepository packageRepository)
        {
            this._packageRepository = packageRepository;
        }

        public async Task<PackageDto> CreatePackage(PackageDto packageDto)
        {
            List<Cookie> cookies = GenerateCookies(packageDto.CookieQuantity);
            
            Package package = new Package(cookies);

            return PackageMapper.MapPackageToDto(await this._packageRepository.PersistPackage(package));

        }

        private List<Cookie> GenerateCookies(int cookieQuantity)
        {
            List<Cookie> cookies = new List<Cookie>();

            for (int i = 0; i < cookieQuantity; i++)
            {
                cookies.Add(GenerateCookie());
            }

            return cookies;
        }

        private Cookie GenerateCookie()
        {
            var r = new Random();
            int flag = r.Next(1, 4);
            return flag switch
            {
                1 => new ChocolateCookie(),
                2 => new CreamCookie(),
                3 => new RaisinCookie(),
            };
        }



    }
}