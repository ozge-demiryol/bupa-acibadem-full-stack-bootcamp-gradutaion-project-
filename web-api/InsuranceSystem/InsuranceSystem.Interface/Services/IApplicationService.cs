using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsuranceSystem.Interface.Services
{
    public interface IApplicationService : IGenericService<Application, DtoApplication>
    {
    }
}
