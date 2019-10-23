using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StandardDomain.IService;
using StandardEntityFramework.IRepositories;
using StandardModels.Dtos;
using StandardModels.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IStudentDomainService _studentDomainService;
        public ValuesController(IStudentDomainService studentDomainService)
        {
            this._studentDomainService = studentDomainService;
        }

        /// <summary>
        /// 获取所有信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAll")]
        public dynamic GetAll()
        {
            return _studentDomainService.GetAll();
        }

        /// <summary>
        /// 获取单个信息
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFirst")]
        public dynamic GetFirst()
        {
            return _studentDomainService.GetFirst();
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        /// <param name="input"></param>
        [HttpPost]
        [Route("AddStudent")]
        /// <summary>
        /// 添加学生
        /// </summary>
        public void AddStudent(CreateStudentDto input)
        {
            _studentDomainService.AddStudent(input.name);
        }
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
