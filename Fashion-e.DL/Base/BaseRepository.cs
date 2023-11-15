using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.DL.Context;
using Microsoft.EntityFrameworkCore;

namespace Fashion_e.DL.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        public virtual async Task<int> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            int res = await _context.SaveChangesAsync();

            return res;
        }

        public virtual async Task<int> Delete(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Entry(entity).Property("Deleted").CurrentValue = 1;
                _context.Entry(entity).Property("Deleted").IsModified = true;

            }

            int res = await _context.SaveChangesAsync();

            return res;
        }

        public virtual async Task<T> GetById(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            return entity;
        }

        public virtual async Task<IEnumerable<T>> GetList()
        {
            var entities = await _context.Set<T>()
                .Where(e => EF.Property<int>(e, "Deleted") == 0)
                .ToListAsync();

            return entities;
        }

        public virtual async Task<int> Update(Guid id, T entity)
        {
            _context.Set<T>().Update(entity);
            int res = await _context.SaveChangesAsync();

            return res;
        }
    }
}
