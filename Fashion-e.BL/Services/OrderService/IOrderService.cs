using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Order;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.Services.OrderService
{
    public interface IOrderService : IBaseService<Order, OrderDTO>
    {
        /// <summary>
        /// hàm xác nhận đơn hàng
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Task<int> ConfirmOrder(Guid orderId, Guid employeeId);

        /// <summary>
        /// hàm đóng gói hàng
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="employeeId"></param>
        /// <returns></returns>
        public Task<int> PackageOrder(Guid orderId, Guid employeeId);


        /// <summary>
        /// hàm giao hàng cho
        /// shipper
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="employeeId"></param>
        /// <param name="shipId"></param>
        /// <returns></returns>
        public Task<int> DeliverdOrder(Guid orderId, Guid employeeId, Guid shipId);

        /// <summary>
        /// hàm đã giao
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Task<int> Shipped(Guid orderId);

        /// <summary>
        /// hàm đã nhận
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Task<int> Received(Guid orderId);
    }
}
