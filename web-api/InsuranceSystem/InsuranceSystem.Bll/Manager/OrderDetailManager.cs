using InsuranceSystem.Bll.Base;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceSystem.Bll.Manager
{
    public class OrderDetailManager : BllBase<OrderDetail, DtoOrderDetail>, IOrderDetailService
    {
        public readonly IOrderDetailRepository orderDetailRepository;
        public OrderDetailManager(IServiceProvider service) : base(service)
        {
            orderDetailRepository = service.GetService<IOrderDetailRepository>();
        }
    }
}
