using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using System.Linq;

namespace InsuranceSystem.Interface.Services
{
    public interface ICustomerService : IGenericService<Customer, DtoCustomer>
    {
        IQueryable CustomerReport();
    }
}
