using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardController : ApiBaseController<ICreditCardService,CreditCard,DtoCreditCard>
    {
        private readonly ICreditCardService creditCardService;
        public CreditCardController(ICreditCardService creditCardService) : base(creditCardService)
        {
            this.creditCardService = creditCardService;
        }
    }
}
