using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Domain.Repositories
{
    public interface IBaseRepository<T>
    {
        IQueryable<T> FindAll(bool trackChanges);
        IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        Task<T> FindSingleByCondition(Expression<Func<T, bool>> expression, bool trackChanges);
        int Create(T entity);
        void Delete(T entity);
        void Update(T entity);
    }
}
