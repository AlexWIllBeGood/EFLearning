using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190731EFCoreProgram_MySql_.Domain.IService
{
    public interface IBaseService<T>
    {
        void Add(T t);
        void Delete(T t);
        void Update(T t);
        void GetAll();
        void Get();
    }
}
