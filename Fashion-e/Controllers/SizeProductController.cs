using Fashion_e.Base;
using Fashion_e.BL.DTOs.SizeProduct;
using Fashion_e.BL.Services.SizeProductService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class SizeProductController : BaseController<SizeProduct, SizeProductDto>
    {
        public SizeProductController(ISizeProductService sizeProductService) : base(sizeProductService)
        {
            
        }
    }
}
