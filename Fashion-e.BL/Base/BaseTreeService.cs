using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.DL.Base;

namespace Fashion_e.BL.Base
{
    public class BaseTreeService<T, TDto> : BaseService<T, TDto>, IBaseTreeService<T, TDto>
        where TDto : class
        where T : class
    {
        protected readonly IBaseTreeRepository<T> _baseTreeRepository;
        protected readonly IMapper _mapper;

        public BaseTreeService(
            IBaseTreeRepository<T> baseTreeRepository,
            IMapper mapper
        ) : base( baseTreeRepository, mapper )
        {
            _baseTreeRepository = baseTreeRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// hàm trả về danh sách
        /// dạng cây
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        /// created by: ntvu (20/11/2023)
        public virtual async Task<IEnumerable<T>> GetTree()
        {
            var entites = await _baseTreeRepository.GetTree();

            return entites;
        }
    }
}
