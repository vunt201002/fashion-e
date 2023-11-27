using Fashion_e.Base;
using Fashion_e.BL.DTOs.SizeColorProduct;
using Fashion_e.BL.Services.SizeColorProductService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class SizeColorProductController : BaseController<SizeColorProduct, SizeColorProductDTO>
    {
        public SizeColorProductController(ISizeColorProductService sizeColorProductService) : base(sizeColorProductService)
        {
            
        }
    }
}
