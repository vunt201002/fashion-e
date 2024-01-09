using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;

namespace Fashion_e.DL.Constracts
{
    public interface IOrderRepository : IBaseRepository<Order>
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
        public Task<int> Shipped(Guid orderId, string status);

        /// <summary>
        /// hàm đã nhận
        /// </summary>
        /// <param name="orderId"></param>
        /// <param name="status"></param>
        /// <returns></returns>
        public Task<int> Received(Guid orderId, string status);
    }
}
