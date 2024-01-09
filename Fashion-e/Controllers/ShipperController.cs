using Fashion_e.Base;
using Fashion_e.BL.DTOs.Shipper;
using Fashion_e.BL.Services.ShipperService;
using Fashion_e.Common.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Controllers
{
    public class ShipperController : BaseController<Shipper, ShipperDTO>
    {
        private readonly IShipperService _shipperService;

        public ShipperController(IShipperService shipperService) : base(shipperService)
        {
            _shipperService = shipperService;
        }

        [HttpPost("shipped/{orderId}")]
        public async Task<IActionResult> Shipped(Guid orderId)
        {
            int res = await _shipperService.Shipped(orderId);

            return Ok(res);
        }
    }
}
