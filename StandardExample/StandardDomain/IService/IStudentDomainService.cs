using StandardEntityFramework.IRepositories;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardDomain.IService
{
    public interface IStudentDomainService:IBaseRepository<Student>
    {
    }
}
