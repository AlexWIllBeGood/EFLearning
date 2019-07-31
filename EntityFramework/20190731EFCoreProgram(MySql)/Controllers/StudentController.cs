using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _20190731EFCoreProgram_MySql_.Domain.IService;
using _20190731EFCoreProgram_MySql_.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _20190731EFCoreProgram_MySql_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {   
            _studentService = studentService;
        }
        [HttpGet]
        public JsonResult GetStudent()
        {
            var studentList = _studentService.GetAllStudent();
            return new JsonResult(studentList);
        }
        [HttpPost]
        public void SaveStudent(Student Student)
        {
            //_studentService.SaveStudentAsync(Student);
            //_studentService.SaveStudent(Student);
            _studentService.Add(Student);
        }
        [HttpDelete]
        public void Delete(Student student)
        {
            _studentService.Delete(student);
        }
       
    }
}
