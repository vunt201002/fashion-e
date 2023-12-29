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
    public class ShipperRepository : BaseRepository<Shipper>, IShipperRepository
    {
        public ShipperRepository(DataContext context) : base(context)
        {
            
        }
    }
}
