using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.SizeColorProduct;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.SizeColorProductService
{
    public class SizeColorProductService : BaseService<SizeColorProduct, SizeColorProductDTO>, ISizeColorProductService
    {
        public SizeColorProductService(
            ISizeColorProductRepository sizeColorProductRepository,
            IMapper mapper
        ) : base(sizeColorProductRepository, mapper)
        {
            
        }
    }
}
