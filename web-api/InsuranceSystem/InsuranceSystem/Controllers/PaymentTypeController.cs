using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController : ApiBaseController<IPaymentTypeService, PaymentType, DtoPaymentType>
    {
        private readonly IPaymentTypeService paymentTypeService;
        public PaymentTypeController(IPaymentTypeService paymentTypeService) : base(paymentTypeService)
        {
            this.paymentTypeService = paymentTypeService;
        }
    }
}
