using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Shipper;
using Fashion_e.BL.Services.OrderService;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;
using Fashion_e.DL.Repositories;

namespace Fashion_e.BL.Services.ShipperService
{
    public class ShipperService : BaseService<Shipper, ShipperDTO>, IShipperService
    {
        private readonly IOrderService _orderService;

        public ShipperService(
            IShipperRepository shipperRepository,
            IMapper mapper,
            IOrderService orderService
        ) : base( shipperRepository, mapper )
        {
            _orderService = orderService;
        }

        public async Task<int> Shipped(Guid orderId)
        {
            int res = await _orderService.Shipped( orderId );

            return res;
        }
    }
}
