using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;

namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ApiBaseController<IOrderService, Order, DtoOrder>
    {
        private readonly IOrderService orderService;
        public OrderController(IOrderService orderService) : base(orderService)
        {
            this.orderService = orderService;
        }
    }
}
