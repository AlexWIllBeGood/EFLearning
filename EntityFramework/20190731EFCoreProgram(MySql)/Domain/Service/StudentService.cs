using _20190731EFCoreProgram_MySql_.Domain.IService;
using _20190731EFCoreProgram_MySql_.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _20190731EFCoreProgram_MySql_.Domain.Service
{
    public class StudentService : BaseService<Student>,IStudentService
    {
        private readonly TestContext _testContex;
        public StudentService(TestContext testContext):base(testContext)
        {
            this._testContex = testContext;
        }
        public List<Student> GetAllStudent()
        {
            return _testContex.Students.Where(e => e.IsDeleted == false).ToList();
        }
        public Student GetStudentById(int id)
        {
            return _testContex.Students.FirstOrDefault(e => e.Id == id);
        }
        public async void SaveStudentAsync(Student student)
        {
            await _testContex.Students.AddAsync(student);
            _testContex.SaveChanges();
        }
        public void SaveStudent(Student student)
        {
            Add(student);
        }
    }
}
