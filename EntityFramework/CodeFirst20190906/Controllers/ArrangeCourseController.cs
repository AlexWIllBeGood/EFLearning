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
    public class ArrangeCourseController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IArrangeCourseRepository _arrangeCourseRepository;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrangeCourseRepository"></param>
        public ArrangeCourseController(IArrangeCourseRepository arrangeCourseRepository)
        {
            this._arrangeCourseRepository = arrangeCourseRepository;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet("GetAll")]
        public ActionResult<List<ArrangeCourse>> GetAllArrangeCourse()
        {
            return _arrangeCourseRepository.GetAll().ToList();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("Get/{id}")]
        public ActionResult<ArrangeCourse> Get(int id)
        {
            return _arrangeCourseRepository.Get(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrangeCourse"></param>
        [HttpPost("Add")]
        public void AddArrangeCourse(ArrangeCourse arrangeCourse)
        {
            _arrangeCourseRepository.Add(arrangeCourse);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        [HttpDelete("Remove")]
        public void RemoveArrangeCourse(int id)
        {
            _arrangeCourseRepository.Remove(id);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="arrangeCourse"></param>
        [HttpPut("Update")]
        public void UpdateArrangeCourse(ArrangeCourse arrangeCourse)
        {
            _arrangeCourseRepository.Update(arrangeCourse);
        }
    }
}