using Fashion_e.Base;
using Fashion_e.BL.DTOs.Order;
using Fashion_e.BL.Services.OrderService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class OrderController : BaseController<Order, OrderDTO>
    {
        public OrderController(IOrderService orderService) : base(orderService)
        {
            
        }
    }
}
