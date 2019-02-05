using Core.Data.Repository.Interfaces;
using System;

using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.Data.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        private FactuContext _context;
        private DbSet<T> _dbSet;

        public GenericRepository(FactuContext context)
        {
            _context = context;
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            try
            {
                _dbSet.Add(entity);
                _context.SaveChanges();
            }catch(DbUpdateException xc)
            {
                throw xc;
            }
        }

        public void Delete(T entity)
        {
            
            if(_context.Entry(entity).State == EntityState.Detached)
            {
                _dbSet.Attach(entity);
            }
            _dbSet.Remove(entity);
        }

        public void Delete(object id)
        {
            var entityToDelete = _dbSet.Find(id);
            Delete(entityToDelete);
        }

        public IQueryable<T> FindBy(Expression<Func<T, bool>> filter)
        {
            IQueryable<T> query = _dbSet;
            if(filter != null)
            {
                query = query.Where(filter);
            }
            return query;
        }

        public IQueryable<T> GetAll()
        {
            return (IQueryable<T>)_dbSet;
        }

        public void Update(T entity)
        {
            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

        }
    }
}
