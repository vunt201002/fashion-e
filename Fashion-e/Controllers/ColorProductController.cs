using Fashion_e.Base;
using Fashion_e.BL.DTOs.ColorProduct;
using Fashion_e.BL.Services.ColorProductService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class ColorProductController : BaseController<ColorProduct, ColorProductDto>
    {
        public ColorProductController(IColorProductService colorProductService) : base(colorProductService)
        {
            
        }
    }
}
