using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Fashion_e.DL.Base;

namespace Fashion_e.BL.Base
{
    public class BaseService<T, TDto> : IBaseService<T, TDto>
        where T : class
        where TDto : class
    {
        protected readonly IBaseRepository<T> _baseRepository;
        protected readonly IMapper _mapper;

        public BaseService(
            IBaseRepository<T> baseRepository,
            IMapper mapper
        )
        {
            _baseRepository = baseRepository;
            _mapper = mapper;
        }

        /// <summary>
        /// hàm thêm bản ghi
        /// </summary>
        /// <param name="item">thông tin thêm</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public virtual async Task<int> Add(TDto item)
        {
            T entity = _mapper.Map<T>( item );

            typeof(T).GetProperty("Id").SetValue(entity, Guid.NewGuid());

            int res = await _baseRepository.Add(entity);

            return res;
        }

        /// <summary>
        /// hàm xóa bản ghi
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public virtual async Task<int> Delete(Guid id)
        {
            int res = await _baseRepository.Delete(id);

            if (res == 0)
            {
                throw new Exception("Xóa không thành công");
            }

            return res;
        }

        /// <summary>
        /// hàm lấy bản ghi theo id
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>bản ghi</returns>
        /// created by: ntvu (20/11/2023)
        public virtual async Task<T> GetById(Guid id)
        {
            T entity = await _baseRepository.GetById(id);

            if (entity == null)
            {
                throw new Exception("Không tìm thấy bản ghi");
            }

            return entity;
        }

        /// <summary>
        /// hàm lấy danh sách
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        /// created by: ntvu (20/11/2023)
        public virtual async Task<IEnumerable<T>> GetList()
        {
            IEnumerable<T> entities = await _baseRepository.GetList();

            if (entities == null)
            {
                throw new Exception("Không tìm thấy danh sách");
            }

            return entities;
        }

        /// <summary>
        /// hàm sửa thông tin
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <param name="item">thông tin sửa</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public virtual async Task<int> Update(Guid id, TDto item)
        {
            T entity = _mapper.Map<T>(item);

            int res = await _baseRepository.Update(id, entity);

            return res;
        }

    }
}
