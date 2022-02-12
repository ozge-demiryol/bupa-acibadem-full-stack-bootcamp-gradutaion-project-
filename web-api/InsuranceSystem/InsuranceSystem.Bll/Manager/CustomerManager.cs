using InsuranceSystem.Bll.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using System;
using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;

namespace InsuranceSystem.Bll.Manager
{
    public class CustomerManager : BllBase<Customer, DtoCustomer>, ICustomerService
    {
        public readonly ICustomerRepository customerRepository;
        public CustomerManager(IServiceProvider service) : base(service)
        {
            customerRepository = service.GetService<ICustomerRepository>();
        }
        public IQueryable CustomerReport()
        {
            return customerRepository.CustomerReport();
        }
    }
}
