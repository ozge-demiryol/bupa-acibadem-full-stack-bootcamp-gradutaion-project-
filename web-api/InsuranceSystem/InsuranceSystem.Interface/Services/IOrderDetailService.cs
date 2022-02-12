using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using System.Linq;

namespace InsuranceSystem.Interface.Services
{
    public interface IOrderDetailService : IGenericService<OrderDetail, DtoOrderDetail>
    {
    }
}
