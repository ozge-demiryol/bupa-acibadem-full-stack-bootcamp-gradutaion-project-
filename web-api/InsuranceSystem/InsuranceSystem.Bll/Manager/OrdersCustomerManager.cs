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
    public class OrdersCustomerManager : BllBase<OrdersCustomer, DtoOrdersCustomer>, IOrdersCustomerService
    {
        public readonly IOrdersCustomerRepository ordersRepository;
        public OrdersCustomerManager(IServiceProvider service) : base(service)
        {
            ordersRepository = service.GetService<IOrdersCustomerRepository>();
        }

        public IQueryable OrdersCustomerReport()
        {
            return ordersRepository.OrdersCustomerReport();
        }
    }
}
