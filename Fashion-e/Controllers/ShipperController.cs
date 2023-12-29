using Fashion_e.Base;
using Fashion_e.BL.DTOs.Shipper;
using Fashion_e.BL.Services.ShipperService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class ShipperController : BaseController<Shipper, ShipperDTO>
    {
        public ShipperController(IShipperService shipperService) : base(shipperService)
        {
            
        }
    }
}
