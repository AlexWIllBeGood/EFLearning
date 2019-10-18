using _20190731EFCoreProgram_MySql_.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190731EFCoreProgram_MySql_.Domain.IService
{
    public interface IStudentService:IBaseService<Student>
    {
        List<Student> GetAllStudent();
        Student GetStudentById(int id);
        void SaveStudentAsync(Student student);
        void SaveStudent(Student student);
    }
}
