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
        private readonly IOrderRepository _orderRepository;
        private readonly IMapper _mapper;

        public OrderService(
            IOrderRepository orderRepository,
            IMapper mapper
        ) : base(orderRepository, mapper)
        {
            _orderRepository = orderRepository;
            _mapper = mapper;
        }

        public async Task<int> ConfirmOrder(Guid orderId, Guid employeeId)
        {
            int res = await _orderRepository.ConfirmOrder(orderId, employeeId);

            return res;
        }

        public async Task<int> DeliverdOrder(Guid orderId, Guid employeeId, Guid shipId)
        {
            int res = await _orderRepository.DeliverdOrder(orderId, employeeId, shipId);

            return res;
        }

        public async Task<int> PackageOrder(Guid orderId, Guid employeeId)
        {
            int res = await _orderRepository.PackageOrder(orderId, employeeId);

            return res;
        }

        public async Task<int> Received(Guid orderId)
        {
            int res = await _orderRepository.Received(orderId, "Đã nhận");

            return res;
        }

        public async Task<int> Shipped(Guid orderId)
        {
            int res = await _orderRepository.Shipped(orderId, "Đã giao");

            return res;
        }
    }
}
