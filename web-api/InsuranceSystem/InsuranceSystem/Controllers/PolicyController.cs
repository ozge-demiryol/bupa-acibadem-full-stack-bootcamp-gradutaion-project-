using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PolicyController : ApiBaseController<IPolicyService, Policy, DtoPolicy>
    {
        private readonly IPolicyService policyService;
        public PolicyController(IPolicyService policyService) : base(policyService)
        {
            this.policyService = policyService;
        }
    }
}
