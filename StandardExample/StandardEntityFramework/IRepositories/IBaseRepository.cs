using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StandardEntityFramework.IRepositories
{
    public interface IBaseRepository<T> where T:class
    {
        IQueryable<T> GetIncluding(params Expression<Func<T, object>>[] properties);
        IQueryable<T> GetList(Expression<Func<T, bool>> expression);
        void Add(T entity);
        void Delete(int id);
        T Get(int id);
        void Update(T entity);
    }
}
