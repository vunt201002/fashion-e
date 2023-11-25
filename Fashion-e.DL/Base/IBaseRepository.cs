using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.DL.Base
{
    public interface IBaseRepository<T>
    {
        /// <summary>
        /// hàm lấy danh sách
        /// </summary>
        /// <returns>Task<IEnumerable<T>></returns>
        /// created by: ntvu (21/11/2023)
        public Task<IEnumerable<T>> GetList();

        /// <summary>
        /// hàm lấy bản ghi theo id
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>Task<T></returns>
        /// created by: ntvu (21/11/2023)
        public Task<T> GetById(Guid id);

        /// <summary>
        /// hàm thêm
        /// </summary>
        /// <param name="entity">bản ghi mới</param>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public Task<int> Add(T entity);

        /// <summary>
        /// hàm sửa
        /// </summary>
        /// <param name="id">id bản ghi cần sửa</param>
        /// <param name="entity">thông tin mới</param>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public Task<int> Update(Guid id, T entity);


        /// <summary>
        /// hàm xóa
        /// </summary>
        /// <param name="id">id cần xóa</param>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public Task<int> Delete(Guid id);

        /// <summary>
        /// hàm trả về dữ liệu dạng cây
        /// </summary>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public Task<IEnumerable<T>> GetTree();

        public Task<int> AddTree(T entity);
    }
}
