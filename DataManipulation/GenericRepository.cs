using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace DataManipulation
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private readonly ArsNovaDbContext _context;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(ArsNovaDbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public T Get(Expression<Func<T, bool>> expression, 
            List<string> includes = null)
        {
            IQueryable<T> query = _dbSet;
            if (includes != null)
            {
                foreach(var include in includes)
                {
                    query = query.Include(include);
                }
                
            }
            return query.AsNoTracking().FirstOrDefault(expression);
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression = null, 
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, List<string> includes = null)
        {

            IQueryable<T> query = _dbSet;

            if (expression != null)
            {
                query = query.Where(expression);
            }
            if (includes!= null)
            {
                foreach (var include in includes)
                {
                    query = query.Include(include);
                }

            }
            if (orderBy != null)
            {
                query = orderBy(query);
            }
            
            return query.AsNoTracking().ToList();
        }
        public void Add(T entity)
        {
            _dbSet.Add(entity);
        }

        public void Remove(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void Upddate(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
