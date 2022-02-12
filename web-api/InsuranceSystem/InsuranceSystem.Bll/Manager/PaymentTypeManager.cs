using InsuranceSystem.Bll.Base;
using InsuranceSystem.Dal.Abstract.AbstractRepositories;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using System;
using Microsoft.Extensions.DependencyInjection;

namespace InsuranceSystem.Bll.Manager
{
    public class PaymentTypeManager : BllBase<PaymentType, DtoPaymentType>,IPaymentTypeService
    {
        public readonly IPaymentTypeRepository paymentTypeRepository;
        public PaymentTypeManager(IServiceProvider service):base(service)
        {
            paymentTypeRepository = service.GetService<IPaymentTypeRepository>();
        }
    }
}
