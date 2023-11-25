using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.DL.Base
{
    public interface IBaseTreeRepository<T> : IBaseRepository<T> where T : class
    {
        /// <summary>
        /// hàm trả về dữ liệu dạng cây
        /// </summary>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public Task<IEnumerable<T>> GetTree();

        public Task<int> AddTree(T entity);
    }
}
