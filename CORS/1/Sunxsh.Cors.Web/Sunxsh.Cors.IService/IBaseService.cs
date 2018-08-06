using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Sunxsh.Cors.IService
{
    public interface IBaseService<T> where T : class, new()
    {
        T Add(T entity);
        T Delete(T entity);
        T Delete(object key);
        void Update(T entity);
        IQueryable<T> Get();
        IQueryable<T> Get(Expression<Func<T, bool>> whereLambda);
        IQueryable<T> Get<TType>(int pageSize, int pageIndex, bool isAsc, Expression<Func<T, TType>> orderByLambda, Expression<Func<T, bool>> whereLambda);
        T Get(object id);
        bool SaveChanges();
    }
}
