using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ApiBaseController<IOrderDetailService, OrderDetail, DtoOrderDetail>
    {
        private readonly IOrderDetailService orderDetailService;
        public OrderDetailController(IOrderDetailService orderDetailService) : base(orderDetailService)
        {
            this.orderDetailService = orderDetailService;
        }
    }
}
