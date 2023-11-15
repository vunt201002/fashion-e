using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.BL.Base
{
    public interface IBaseService<T> where T : class
    {
        public Task<IEnumerable<T>> GetList();
        public Task<T> GetById(Guid id);
        public Task<int> Add(T item);
        public Task<int> Update(Guid id, T item);
        public Task<int> Delete(Guid id);
    }
}
