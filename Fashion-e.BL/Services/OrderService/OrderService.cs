using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Order;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.OrderService
{
    public class OrderService : BaseService<Order, OrderDTO>, IOrderService
    {
        public OrderService(
            IOrderRepository orderRepository,
            IMapper mapper
        ) : base(orderRepository, mapper)
        {
            
        }
    }
}
