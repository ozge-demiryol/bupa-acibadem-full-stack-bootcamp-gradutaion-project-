using InsuranceSystem.Bll.Base;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceSystem.Bll.Manager
{
    public class RegionManager : BllBase<Region, DtoRegion>,IRegionService
    {
        public readonly IRegionRepository regionRepository;
        public RegionManager(IServiceProvider service): base(service)
        {
            regionRepository = service.GetService<IRegionRepository>();
        }
    }
}
