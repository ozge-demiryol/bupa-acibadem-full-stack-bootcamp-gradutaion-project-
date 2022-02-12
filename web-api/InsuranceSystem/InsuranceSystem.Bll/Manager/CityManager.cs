using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Interface.Services;
using InsuranceSystem.Bll.Base;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;

namespace InsuranceSystem.Bll.Manager
{
    public class CityManager : BllBase<City, DtoCity>, ICityService
    {
        public readonly ICityRepository cityRepository;
        public CityManager(IServiceProvider service) : base(service)
        {
            cityRepository = service.GetService<ICityRepository>();
        }

        public IQueryable CityReport()
        {
            return cityRepository.CityReport();
        }
    }
}
