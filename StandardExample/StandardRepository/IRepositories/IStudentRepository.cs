using StandardEntityFramework.IRepositories;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardRepository.IRepositories
{
    /// <summary>
    /// 普通仓储结构中接口写法
    /// </summary>
    public interface IStudentRepository : IBaseRepository<Student>
    {
    }
}
