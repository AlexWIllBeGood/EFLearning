using Microsoft.EntityFrameworkCore;
using StandardEntityFramework.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace StandardEntityFramework.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly LocalDbContext _localDbContext;

        public BaseRepository(LocalDbContext localDbContext)
        {
            this._localDbContext = localDbContext;
        }
        public virtual IQueryable<T> GetIncluding(params Expression<Func<T, object>>[] properties)
        {
            IQueryable<T> query = _localDbContext.Set<T>();
            return properties.Aggregate(query, (current, expression) => current.Include(expression));
        }
        /// <summary>
        /// 获取列表
        /// </summary>
        /// <param name="expression"></param>
        /// <returns></returns>
        public virtual IQueryable<T> GetList(Expression<Func<T, bool>> expression)
        {
            return _localDbContext.Set<T>().Where(expression);
        }
        /// <summary>
        /// 添加单个
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Add(T entity)
        {
            _localDbContext.Set<T>().Add(entity);
        }
        /// <summary>
        /// 删除单个
        /// </summary>
        /// <param name="id"></param>
        public virtual void Delete(int id)
        {
            T entity = Get(id);
            _localDbContext.Set<T>().Remove(entity);
        }
        /// <summary>
        /// 获取单个
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public virtual T Get(int id)
        {
            return Get(id);
        }
        /// <summary>
        /// 更新单个
        /// </summary>
        /// <param name="entity"></param>
        public virtual void Update(T entity)
        {
            _localDbContext.Set<T>().Update(entity);
        }
        private T Get(object key)
        {
            return _localDbContext.Set<T>().Find(key);
        }
    }
}
