using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.ColorProduct;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.ColorProductService
{
    public class ColorProductService : BaseService<ColorProduct, ColorProductDto>, IColorProductService
    {
        public ColorProductService(
            IColorProductRepository colorProductRepository,
            IMapper mapper
        ) : base( colorProductRepository, mapper )
        {
            
        }
    }
}
