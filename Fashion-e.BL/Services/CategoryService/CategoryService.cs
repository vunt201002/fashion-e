using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;

namespace Fashion_e.BL.Services.CategoryService
{
    public class CategoryService : BaseService<Category>, ICategoryService
    {
        public CategoryService(IBaseRepository<Category> baseRepository) : base(baseRepository)
        {
        }
    }
}
