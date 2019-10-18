using _20190731EFCoreProgram_MySql_.Domain.IService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190731EFCoreProgram_MySql_.Domain.Service
{
    public class BaseService<T> : IBaseService<T> where T:class
    {
        private readonly DbContext _dbContext;
        public BaseService(DbContext dbContext)
        {
            this._dbContext = dbContext;
        }

        public void Add(T t)
        {
            _dbContext.Set<T>().Add(t);
            _dbContext.SaveChanges();
        }

        public void Delete(T t)
        {
            _dbContext.Set<T>().Remove(t);
            _dbContext.SaveChanges();
        }

        public void Get()
        {
            throw new NotImplementedException();
        }

        public List<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(T t)
        {
            throw new NotImplementedException();
        }

        void IBaseService<T>.GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
