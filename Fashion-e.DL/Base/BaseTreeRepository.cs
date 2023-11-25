using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fashion_e.Common.Entities.Base;
using Fashion_e.DL.Context;
using Microsoft.EntityFrameworkCore;

namespace Fashion_e.DL.Base
{
    public class BaseTreeRepository<T> : BaseRepository<T>, IBaseTreeRepository<T>
        where T : BaseTreeEntity<T>
    {
        protected readonly DataContext _context;

        public BaseTreeRepository(DataContext context) : base(context)
        {
            _context = context;
        }

        /// <summary>
        /// hàm trả về dữ liệu dạng cây
        /// </summary>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public virtual async Task<IEnumerable<T>> GetTree()
        {
            var entities = await _context.Set<T>()
                .Include(e => e.Parent)
                .Include(e => e.Children)
                .ToListAsync();

            var topLevelEntities = entities
                .Where(e => e.ParentId == default)
                .ToList();

            foreach (var entity in topLevelEntities)
            {
                entity.Children = BuildTree(entities, entity.Id);
            }

            return topLevelEntities;
        }

        /// <summary>
        /// hàm xây dựng cây
        /// </summary>
        /// <param name="allEntities"></param>
        /// <param name="parentId"></param>
        /// <returns></returns>
        /// created by: ntvu (21/11/2023)
        private List<T> BuildTree(List<T> allEntities, Guid parentId)
        {
            var childrenEntities = allEntities
                .Where(e => e.ParentId == parentId)
                .ToList();

            foreach (var entity in childrenEntities)
            {
                entity.Children = BuildTree(allEntities, entity.Id);
            }

            return childrenEntities;
        }

        public virtual async Task<int> AddTree(T entity)
        {
            _context.Set<T>().Add(entity);
            int res = await _context.SaveChangesAsync();

            if (entity.ParentId != default)
            {
                T? parent = await _context.Set<T>().FindAsync(entity.ParentId);

                if (parent != null)
                {
                    ((List<T>)parent.Children).Add(entity);
                    entity.Parent = parent;

                    int isSave = await _context.SaveChangesAsync();

                    res += isSave;
                }
            }

            return res;
        }
    }
}
