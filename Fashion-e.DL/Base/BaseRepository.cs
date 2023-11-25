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
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseTreeEntity<T>
    {
        protected readonly DataContext _context;

        public BaseRepository(DataContext context)
        {
            _context = context;
        }

        /// <summary>
        /// hàm thêm
        /// </summary>
        /// <param name="entity">bản ghi mới</param>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public virtual async Task<int> Add(T entity)
        {
            _context.Set<T>().Add(entity);
            int res = await _context.SaveChangesAsync();

            return res;
        }

        /// <summary>
        /// hàm xóa
        /// </summary>
        /// <param name="id">id cần xóa</param>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public virtual async Task<int> Delete(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            if (entity != null)
            {
                _context.Entry(entity).Property("IsDelete").CurrentValue = 1;
                _context.Entry(entity).Property("IsDelete").IsModified = true;

            }

            int res = await _context.SaveChangesAsync();

            return res;
        }

        /// <summary>
        /// hàm lấy bản ghi theo id
        /// </summary>
        /// <param name="id">id bản ghi</param>
        /// <returns>Task<T></returns>
        /// created by: ntvu (21/11/2023)
        public virtual async Task<T> GetById(Guid id)
        {
            var entity = await _context.Set<T>().FindAsync(id);

            return entity;
        }

        /// <summary>
        /// hàm lấy danh sách
        /// </summary>
        /// <returns>Task<IEnumerable<T>></returns>
        /// created by: ntvu (21/11/2023)
        public virtual async Task<IEnumerable<T>> GetList()
        {
            var entities = await _context.Set<T>()
                .Where(e => EF.Property<int>(e, "IsDelete") == 0)
                .ToListAsync();

            return entities;
        }

        /// <summary>
        /// hàm sửa
        /// </summary>
        /// <param name="id">id bản ghi cần sửa</param>
        /// <param name="entity">thông tin mới</param>
        /// <returns>Task<int></returns>
        /// created by: ntvu (21/11/2023)
        public virtual async Task<int> Update(Guid id, T entity)
        {
            _context.Set<T>().Update(entity);
            int res = await _context.SaveChangesAsync();

            return res;
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

            foreach(var entity in topLevelEntities)
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

            foreach(var entity in childrenEntities)
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
