using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.Base
{
    public interface IBaseTreeService<T, TDto> : IBaseService<T, TDto>
        where T : class
        where TDto : class
    {
        /// <summary>
        /// hàm trả về danh sách
        /// dạng cây
        /// </summary>
        /// <returns>danh sách bản ghi</returns>
        /// created by: ntvu (20/11/2023)
        public Task<IEnumerable<T>> GetTree();
    }
}
