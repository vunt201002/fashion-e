using Fashion_e.Base;
using Fashion_e.BL.DTOs.OrderDetail;
using Fashion_e.BL.Services.OrderDetailService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class OrderDetailController : BaseController<OrderDetail, OrderDetailDTO>
    {
        public OrderDetailController(IOrderDetailService orderDetailService) : base(orderDetailService)
        {
            
        }
    }
}
