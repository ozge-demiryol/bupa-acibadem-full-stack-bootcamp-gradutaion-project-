using InsuranceSystem.Base;
using InsuranceSystem.Entity.Dto;
using InsuranceSystem.Entity.Models;
using InsuranceSystem.Interface.Services;
using Microsoft.AspNetCore.Mvc;


namespace InsuranceSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderStatusController : ApiBaseController<IOrderStatusService, OrderStatus, DtoOrderStatus>
    {
        private readonly IOrderStatusService orderStatusService;
        public OrderStatusController(IOrderStatusService orderStatusService) : base(orderStatusService)
        {
            this.orderStatusService = orderStatusService;
        }
    }
}
