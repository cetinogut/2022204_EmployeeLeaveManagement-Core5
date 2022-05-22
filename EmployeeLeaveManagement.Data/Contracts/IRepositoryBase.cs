using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeLeaveManagement.Data.Contracts
{
    public interface IRepositoryBase<T> where T : class, new() //no abstract classess or interfaces here
    {
        IQueryable<T> GetAll(Expression<Func<T, bool>> filter= null, Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, string icludeProperties = null );

        T Get(int id);
        T GetFirstOrDefault(Expression<Func<T, bool>> filter = null, string includeProperties = null);

        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);

    }
}
