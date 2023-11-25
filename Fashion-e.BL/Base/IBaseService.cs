using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.Base
{
    public interface IBaseService<T, TDto>
        where T : class
        where TDto : class
    {
        /// <summary>
        /// hàm lấy danh sách
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        /// created by: ntvu (20/11/2023)
        public Task<IEnumerable<T>> GetList();

        /// <summary>
        /// hàm lấy bản ghi theo id
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>bản ghi</returns>
        /// created by: ntvu (20/11/2023)
        public Task<T> GetById(Guid id);

        /// <summary>
        /// hàm thêm bản ghi
        /// </summary>
        /// <param name="item">thông tin thêm</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public Task<int> Add(TDto item);

        /// <summary>
        /// hàm sửa thông tin
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <param name="item">thông tin sửa</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public Task<int> Update(Guid id, TDto item);

        /// <summary>
        /// hàm xóa bản ghi
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>số dòng bị ảnh hưởng</returns>
        /// created by: ntvu (20/11/2023)
        public Task<int> Delete(Guid id);
    }
}
