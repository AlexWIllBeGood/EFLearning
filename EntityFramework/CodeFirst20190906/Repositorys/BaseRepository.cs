using CodeFirst20190906.IRepositorys;
using CodeFirst20190906.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace CodeFirst20190906.Repositorys
{
    public class BaseRepository<T,PrimaryKey>:IBaseRepository<T,PrimaryKey> where T:class
    {
        private readonly LocalContext _localContext;
        public BaseRepository(LocalContext localContext)
        {
            this._localContext = localContext;
        }

        public IQueryable<T> GetAll()
        {
            return _localContext.Set<T>();
        }

        public T Get(PrimaryKey id)
        {
            return _localContext.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
           var temp=_localContext.Set<T>().Add(entity);
            _localContext.SaveChanges();
        }

        public void Remove(PrimaryKey id)
        {
            var entity = _localContext.Set<T>().Find(id);
            _localContext.Set<T>().Remove(entity);
            _localContext.SaveChanges();
        }

        public void Update(T entity)
        {
            _localContext.Set<T>().Update(entity);
            _localContext.SaveChanges();
        }

        public IQueryable<T> GetAllIncluding(params Expression<Func<T, object>>[] includes)
        {
            var query = _localContext.Set<T>().AsNoTracking();

            //聚合函数 
            query = includes.Aggregate(query, (current, includeProperty) => current.Include(includeProperty));
            return query;
        }
    }
}
