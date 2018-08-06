using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using Sunxsh.Cors.IRespository;
using Sunxsh.Cors.IService;

namespace Sunxsh.Cors.Service
{
    public abstract class BaseService<T> : IBaseService<T> where T : class, new()
    {
        protected BaseService()
        {
            SetService();
        }
        public IBaseRespository<T> Service { get; set; }
        public abstract void SetService();
        public T Add(T entity)
        {
            return Service.Add(entity);
        }
        public T Delete(T entity)
        {
            return Service.Delete(entity);
        }
        public T Delete(object key)
        {
            return Service.Delete(key);
        }
        public void Update(T entity)
        {
            Service.Update(entity);
        }
        public IQueryable<T> Get()
        {
            return Service.Get();
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> whereLambda)
        {
            return Service.Get(whereLambda);
        }
        public IQueryable<T> Get<TType>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, TType>> orderByLambda, Expression<Func<T, bool>> whereLambda)
        {
            return Service.Get(pageSize, pageIndex, isAsc, orderByLambda, whereLambda);
        }
        public T Get(object id)
        {
            return Service.Get(id);
        }
        public bool SaveChanges()
        {
            return Service.SaveChanges();
        }
    }
}
