using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.BL.Base;
using Fashion_e.BL.DTOs.Category;
using Fashion_e.Common.Entities.Entities;
using Fashion_e.DL.Base;
using Fashion_e.DL.Constracts;

namespace Fashion_e.BL.Services.CategoryService
{
    /// <summary>
    /// service của category
    /// </summary>
    /// created by: ntvu (20/11/2023)
    public class CategoryService : BaseService<Category, CategoryDTO>, ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        public CategoryService(
            ICategoryRepository categoryRepository,
            IMapper mapper
        ) : base(categoryRepository, mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// hàm override hàm add
        /// gọi tới hàm addTree
        /// thêm danh sách theo
        /// dạng cây
        /// </summary>
        /// <param name="item">thông tin thêm</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public override async Task<int> Add(CategoryDTO item)
        {
            Category category = _mapper.Map<Category>( item );

            int res = await _categoryRepository.AddTree(category);

            return res;
        }
    }
}
