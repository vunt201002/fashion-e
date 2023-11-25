using Fashion_e.Base;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Category;
using Fashion_e.BL.Services.CategoryService;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class CategoryController : BaseController<Category, CategoryDTO>
    {
        public CategoryController(ICategoryService categoryService) : base(categoryService)
        {
        }
    }
}
