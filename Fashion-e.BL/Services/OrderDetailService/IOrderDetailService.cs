using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.OrderDetail;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.Services.OrderDetailService
{
    public interface IOrderDetailService : IBaseService<OrderDetail, OrderDetailDTO>
    {
        
    }
}
