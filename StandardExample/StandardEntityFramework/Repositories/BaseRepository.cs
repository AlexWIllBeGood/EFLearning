using StandardEntityFramework.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardEntityFramework.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly LocalDbContext _localDbContext;

        public BaseRepository(LocalDbContext localDbContext)
        {
            this._localDbContext = localDbContext;
        }

        public GetAllAsync()
        {
            return _localDbContext.Set<T>().Remove
        }
    }
}
