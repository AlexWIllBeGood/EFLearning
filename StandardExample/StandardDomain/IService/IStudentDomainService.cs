using StandardEntityFramework.IRepositories;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardDomain.IService
{
    public interface IStudentDomainService
    {
        dynamic GetFirst();
        dynamic GetAll();
        void AddStudent(string name);
    }
}
