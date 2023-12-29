using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Shipper;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.Services.ShipperService
{
    public interface IShipperService : IBaseService<Shipper, ShipperDTO>
    {
    }
}
