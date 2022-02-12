using InsuranceSystem.Bll.Base;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceSystem.Bll.Manager
{
    public class PolicyManager : BllBase<Policy, DtoPolicy>, IPolicyService
    {
        public readonly IPolicyRepository policyRepository;
        public PolicyManager(IServiceProvider service):base(service)
        {
            policyRepository = service.GetService<IPolicyRepository>();
        }
    }
}
