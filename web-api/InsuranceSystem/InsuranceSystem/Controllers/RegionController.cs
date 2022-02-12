using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : ApiBaseController<IRegionService, Region, DtoRegion>
    {
        private readonly IRegionService regionService;
        public RegionController(IRegionService regionService) : base(regionService)
        {
            this.regionService = regionService;
        }
    }
}
