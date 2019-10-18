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
    public class TeacherController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly ITeacherRepository _teacherRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacherRepository"></param>
        public TeacherController(ITeacherRepository teacherRepository)
        {
            this._teacherRepository = teacherRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public ActionResult<List<Teacher>> GetAllTeachers()
        {
            return _teacherRepository.GetAll().ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id}")]
        public ActionResult<Teacher> GetTeacher(int id)
        {
            return _teacherRepository.Get(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacher"></param>
        [HttpPost("Add")]
        public void AddTeacher(Teacher teacher)
        {
            _teacherRepository.Add(teacher);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Remove/{id}")]
        public void RemoveTeacher(int id)
        {
            _teacherRepository.Remove(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="teacher"></param>
        [HttpPut("Update")]
        public void UpdateTeacher(Teacher teacher)
        {
            _teacherRepository.Update(teacher);
        }
        
    }
}