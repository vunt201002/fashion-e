using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fashion_e.DL.Base
{
    public interface IBaseRepository<T>
    {
        public Task<IEnumerable<T>> GetList();
        public Task<T> GetById(Guid id);
        public Task<int> Add(T entity);
        public Task<int> Update(Guid id, T entity);
        public Task<int> Delete(Guid id);
    }
}
