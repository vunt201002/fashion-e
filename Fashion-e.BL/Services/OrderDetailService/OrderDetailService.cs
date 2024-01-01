using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.OrderDetail;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.OrderDetailService
{
    public class OrderDetailService : BaseService<OrderDetail, OrderDetailDTO>, IOrderDetailService
    {
        public OrderDetailService(
            IOrderDetailRepository orderDetailRepository,
            IMapper mapper
        ) : base( orderDetailRepository, mapper )
        {
            
        }
    }
}
