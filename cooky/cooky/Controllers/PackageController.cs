using Abstractions.Controllers;
using Abstractions.Services;
using Domain.DTOs;
using Domain.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace cooky.Controllers
{
    [ApiController]
    [Route("api/packages")]
    public class PackageController : IPackageController
    {
        private readonly IPackageService _packageService;

        public PackageController(IPackageService packageService)
        {
            this._packageService = packageService;
        }

        [HttpPost]
        public async Task<ActionResult<PackageDto>> CreatePackage(PackageDto packageDto)
        {
            try
            {
                if (packageDto == null || packageDto?.CookieQuantity <=0)
                {
                    throw new PackageNullOrEmptyException("The package was either null or empty!");
                }

                return await this._packageService.CreatePackage(packageDto); ;
            }
            catch (Exception ex)
            {
                throw new Exception();
            }
        }
    }
}
