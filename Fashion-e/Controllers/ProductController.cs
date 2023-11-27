using Fashion_e.Base;
using Fashion_e.BL.DTOs.Product;
using Fashion_e.BL.Services.ProductService;
using Fashion_e.Common.Entities.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Fashion_e.Controllers
{
    public class ProductController : BaseController<Product, ProductDto>
    {
        private readonly IProductService _productService;

        public ProductController(
            IProductService productService
        ) : base(productService)
        {
            _productService = productService;
        }

        [HttpGet("thumb")]
        public async Task<IActionResult> GetListWithThumbnail()
        {
            var list = await _productService.GetListWithThumbnail();

            return Ok(list);
        }
    }
}
