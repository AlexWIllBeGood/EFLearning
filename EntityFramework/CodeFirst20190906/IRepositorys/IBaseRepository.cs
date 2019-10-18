using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CodeFirst20190906.IRepositorys
{
    public interface IBaseRepository<T, PrimaryKey> where T : class
    {
        IQueryable<T> GetAll();
        T Get(PrimaryKey id);
        void Add(T entity);
        void Remove(PrimaryKey id);
        void Update(T entity);
        IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includes);
    }
}
