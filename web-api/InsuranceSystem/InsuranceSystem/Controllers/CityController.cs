using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ApiBaseController<ICityService, City, DtoCity>
    {
        private readonly ICityService cityService;
        public CityController(ICityService cityService): base(cityService)
        {
            this.cityService = cityService;
        }
    }
}
