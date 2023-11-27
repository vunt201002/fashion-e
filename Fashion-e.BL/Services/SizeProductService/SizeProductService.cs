using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.SizeProduct;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.SizeProductService
{
    public class SizeProductService : BaseService<SizeProduct, SizeProductDto>, ISizeProductService
    {
        public SizeProductService(
            ISizeProductRepository sizeProductRepository,
            IMapper mapper
        ) : base( sizeProductRepository, mapper )
        {
            
        }
    }
}
