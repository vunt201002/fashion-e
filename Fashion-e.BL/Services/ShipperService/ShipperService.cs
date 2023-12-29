using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Shipper;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.ShipperService
{
    public class ShipperService : BaseService<Shipper, ShipperDTO>, IShipperService
    {
        public ShipperService(
            IShipperRepository shipperRepository,
            IMapper mapper
        ) : base( shipperRepository, mapper )
        {
            
        }
    }
}
