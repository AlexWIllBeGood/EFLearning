using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeFirst20190906.IRepositorys;
using CodeFirst20190906.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CodeFirst20190906.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IStudentRepository _studentRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="studentRepository"></param>
        public StudentController(IStudentRepository studentRepository)
        {
            this._studentRepository = studentRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public ActionResult<List<Student>> GetAllStudents()
        {
            return _studentRepository.GetAllIncluding(e => e.ArrangeCourses).ToList();
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id}")]
        public ActionResult<Student> Get(int id)
        {
            return _studentRepository.Get(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        [HttpPost("Add")]
        public void AddStudent([FromBody]Student student)
        {
            _studentRepository.Add(student);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Remove/{id}")]
        public void RemoveStudent(int id)
        {
            _studentRepository.Remove(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="student"></param>
        [HttpPut("Update")]
        public void UpdateStudent([FromBody]Student student)
        {
            _studentRepository.Update(student);
        }
    }
}