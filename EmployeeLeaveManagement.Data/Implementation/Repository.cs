using EmployeeLeaveManagement.Data.Contracts;
using EmployeeLeaveManagement.Data.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Data.Implementation
{
    public class Repository<T> : IRepositoryBase<T> where T : class, new()
    {
        private readonly EmployeeLeaveManagementContext _context;
        internal DbSet<T> dbSet;
        public Repository(EmployeeLeaveManagementContext context)
        {
            _context = context;
            this.dbSet = _context.Set<T>();
        }
        /// <summary>
        /// Add to T Type entity / Gelen tipte veri kaydeder
        /// </summary>
        /// <param name="Entity"></param>
        public void Add(T entity)
        {
            dbSet.Add(entity);
        }

        /// <summary>
        /// Get Entity T by Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public T Get(int id)
        {
            return dbSet.Find(id);
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> filter = null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string includeProperties = null)//IEnumerable da olabilirde Taste projesinde öyle
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            //include properties will be comma seperated
            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }
            if (orderBy != null)
            {
                return orderBy(query);
            }

            return query;
        }

        public T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null)
        {
            IQueryable<T> query = dbSet;
            if (filter != null)
            {
                query = query.Where(filter);
            }

            if (includeProperties != null)
            {
                foreach (var item in includeProperties.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                {
                    query = query.Include(item);
                }
            }

            return query.FirstOrDefault();
        }

        public void Remove(int id)
        {
            T entityToRemove = dbSet.Find(id);
            Remove(entityToRemove);
        }

        public void Remove(T entity)
        {
            dbSet.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entity)
        {
            dbSet.RemoveRange(entity);
        }

        public void Update(T entity)
        {

            dbSet.Update(entity);
        }
    }
}
