using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Category;
using Fashion_e.Common.Entities.Entities;

namespace Fashion_e.BL.Services.CategoryService
{
    public interface ICategoryService : IBaseService<Category, CategoryDTO>
    {
    }
}
