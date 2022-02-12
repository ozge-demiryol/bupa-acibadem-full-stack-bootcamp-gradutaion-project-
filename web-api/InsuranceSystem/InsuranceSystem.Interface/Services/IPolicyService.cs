using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;

namespace InsuranceSystem.Interface.Services
{
    public interface IPolicyService: IGenericService<Policy, DtoPolicy>
    {
    }
}
