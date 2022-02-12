using InsuranceSystem.Bll.Base;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace InsuranceSystem.Bll.Manager
{
    public class ApplicationManager : BllBase<Application, DtoApplication>, IApplicationService
    {
        public readonly IApplicationRepository applicationRepository;
        public ApplicationManager(IServiceProvider service) : base(service)
        {
            applicationRepository = service.GetService<IApplicationRepository>();
        }

        public IQueryable ApplicationReport()
        {
            return applicationRepository.ApplicationReport();
        }
    }
}
