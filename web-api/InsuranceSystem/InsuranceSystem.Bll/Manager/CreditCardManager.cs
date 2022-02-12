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
    public class CreditCardManager : BllBase<CreditCard, DtoCreditCard>, ICreditCardService
    {
        public readonly ICreditCardRepository creditCardRepository;
        public CreditCardManager(IServiceProvider service) : base(service)
        {
            creditCardRepository = service.GetService<ICreditCardRepository>();
        }

        public IQueryable CreditCardReport()
        {
            return creditCardRepository.CreditCardReport();
        }
    }
}
