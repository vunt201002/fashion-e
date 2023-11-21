using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.DL.Base;

namespace Fashion_e.BL.Base
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        protected readonly IBaseRepository<T> _baseRepository;

        public BaseService(IBaseRepository<T> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public virtual async Task<int> Add(T item)
        {
            int res = await _baseRepository.Add(item);

            return res;
        }

        public virtual async Task<int> Delete(Guid id)
        {
            int res = await _baseRepository.Delete(id);

            if (res == 0)
            {
                throw new Exception("Xóa không thành công");
            }

            return res;
        }

        public virtual async Task<T> GetById(Guid id)
        {
            T entity = await _baseRepository.GetById(id);

            if (entity == null)
            {
                throw new Exception("Không tìm thấy bản ghi");
            }

            return entity;
        }

        public virtual async Task<IEnumerable<T>> GetList()
        {
            IEnumerable<T> entities = await _baseRepository.GetList();

            if (entities == null)
            {
                throw new Exception("Không tìm thấy danh sách");
            }

            return entities;
        }

        public virtual async Task<int> Update(Guid id, T item)
        {
            int res = await _baseRepository.Update(id, item);

            return res;
        }

        public virtual async Task<IEnumerable<T>> GetTree()
        {
            var entites = await _baseRepository.GetTree();

            return entites;
        }
    }
}
