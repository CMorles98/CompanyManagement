using CompanyManagement.Domain.Entities;
using CompanyManagement.Domain.Repositories;
using CompanyManagement.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagement.Infrastructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : BaseEntity
    {
        private readonly ApplicationDbContext _context;

        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public int Create(T entity)
        {
            _context.Set<T>().Add(entity);
            return entity.Id;
        }
        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public IQueryable<T> FindAll(bool trackChanges)
        {
            if (trackChanges)
                return _context.Set<T>();

            return _context.Set<T>().AsNoTracking();
        }
        public IQueryable<T> FindAll(bool trackChanges, params string[] include)
        {
            if (trackChanges)
                return _context.Set<T>();

            IQueryable<T> query = _context.Set<T>();

            include.ToList().ForEach(includePath => query = query.Include(includePath));

            return query;
        }

        public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            if (trackChanges)
                return _context.Set<T>().Where(expression);

            return _context.Set<T>().Where(expression).AsNoTracking();
        }

        public async Task<T> FindSingleByCondition(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            if (trackChanges)
                return await _context.Set<T>().SingleOrDefaultAsync(expression);

            return await _context.Set<T>().AsNoTracking().SingleOrDefaultAsync(expression);

        }

        public async Task<bool> CheckAnyByCondition(Expression<Func<T, bool>> expression)
        {
            return await _context.Set<T>().AnyAsync(expression);
        }

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }

        public async Task SaveChanges() => await _context.SaveChangesAsync();

    }
}
