using InsuranceSystem.Bll.Base;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceSystem.Bll.Manager
{
    public class OrderStatusManager : BllBase<OrderStatus,DtoOrderStatus>,IOrderStatusService
    {
        public readonly IOrderStatusRepository orderStatusRepository;
        public OrderStatusManager(IServiceProvider service) : base(service)
        {
            orderStatusRepository = service.GetService<IOrderStatusRepository>();
        }
    }
}
