using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Context;

namespace Fashion_e.DL.Repositories
{
    public class OrderRepository : BaseRepository<Order>, IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> ConfirmOrder(Guid orderId, Guid employeeId)
        {
            Order? order = await _context.Order.FindAsync(orderId);

            order.ConfirmId = employeeId;
            order.Status = "Đã xác nhận";

            int res = await _context.SaveChangesAsync();

            return res;
        }

        public async Task<int> DeliverdOrder(Guid orderId, Guid employeeId, Guid shipId)
        {
            Order? order = await _context.Order.FindAsync(orderId);

            order.DeliverdId = employeeId;
            order.ShipId = shipId;
            order.Status = "Đã giao cho đơn vị vận chuyển";

            int res = await _context.SaveChangesAsync();

            return res;
        }

        public async Task<int> PackageOrder(Guid orderId, Guid employeeId)
        {
            Order? order = await _context.Order.FindAsync(orderId);

            order.PackagedId = employeeId;
            order.Status = "Đã chuẩn bị hàng";

            int res = await _context.SaveChangesAsync();

            return res;
        }

        public async Task<int> Received(Guid orderId, string status)
        {
            Order? order = await _context.Order.FindAsync(orderId);

            order.Status = status;

            int res = await _context.SaveChangesAsync();

            return res;
        }

        public async Task<int> Shipped(Guid orderId, string status)
        {
            Order? order = await _context.Order.FindAsync(orderId);

            order.Status = status;
            order.Paid = 1;
            

            int res = await _context.SaveChangesAsync();

            return res;
        }
    }
}
