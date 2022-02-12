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
    public class ApplicationController : ApiBaseController<IApplicationService, Application, DtoApplication>
    {
        private readonly IApplicationService applicationService;
        public ApplicationController(IApplicationService applicationService) : base(applicationService)
        {
            this.applicationService = applicationService;
        }
    }
}
