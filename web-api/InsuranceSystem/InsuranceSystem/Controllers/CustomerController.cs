using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;


namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ApiBaseController<ICustomerService,Customer, DtoCustomer>
    {
        private readonly ICustomerService customerService;

        public CustomerController(ICustomerService customerService) : base(customerService)
        {
            this.customerService = customerService;
        }
    }
}
