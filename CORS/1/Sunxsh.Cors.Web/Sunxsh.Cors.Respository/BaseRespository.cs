using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Sunxsh.Cors.IRespository;
using Sunxsh.Cors.Models;

namespace Sunxsh.Cors.Respository
{
    public class BaseRespository<T> : IBaseRespository<T> where T : class, new()
    {
        private DbContext _dbContext;

        public DbContext DbContext => _dbContext ?? (_dbContext = DbContextFactory.Create());

        public T Add(T entity)
        {
            return DbContext.Set<T>().Add(entity);
        }
        
        public T Delete(T entity)
        {
            return DbContext.Set<T>().Remove(entity);
        }

        public T Delete(object key)
        {
            var entity = DbContext.Set<T>().Find(key);
            return Delete(entity);
        }
        public IQueryable<T> Get()
        {
            return DbContext.Set<T>().AsQueryable();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
        {
            return DbContext.Set<T>().Where(whereLambda);
        }

        public IQueryable<T> Get<TType>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, TType>> orderByLambda, Expression<Func<T, bool>> whereLambda)
        {
            if (isAsc)
            {
                return DbContext.Set<T>()
                    .Where(whereLambda)
                    .OrderBy(orderByLambda)
                    .Skip((pageIndex - 1) * pageSize)
                    .Take(pageSize);
            }
            return DbContext.Set<T>()
                .Where(whereLambda)
                .OrderByDescending(orderByLambda)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize);
        }

        public T Get(object id)
        {
            return DbContext.Set<T>().Find(id);
        }

        public bool SaveChanges()
        {
            return DbContext.SaveChanges() > 0;
        }

        public void Update(T entity)
        {
            DbContext.Set<T>().AddOrUpdate(entity);
        }
    }
    
}
