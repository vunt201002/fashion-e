using Fashion_e.Base;
using Fashion_e.BL.Base;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.Controllers
{
    public class CategoryController : BaseController<Category>
    {
        public CategoryController(IBaseService<Category> baseService) : base(baseService)
        {
        }
    }
}
