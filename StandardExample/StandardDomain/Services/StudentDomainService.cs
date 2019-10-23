using StandardDomain.IService;
using StandardEntityFramework;
using StandardEntityFramework.IRepositories;
using StandardEntityFramework.Repositories;
using StandardModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StandardDomain.Services
{
    public class StudentDomainService:IStudentDomainService
    {
        //构造器注入（被推荐的注入方式）
        private readonly IBaseRepository<Student> _studentRepository;
        private readonly IBaseRepository<Teacher> _teacherRepository;
        private readonly IBaseRepository<ArrangeCourse> _arrangeCourseRepository;
        //属性注入（只能使用第三方IOC容器）
        //public IBaseRepository<ArrangeCourse> ArrangeCourseRepository { get; set; }
        public StudentDomainService(IBaseRepository<Student> studentRepository, IBaseRepository<Teacher> teacherRepository, IBaseRepository<ArrangeCourse> arrangeCourseRepository)
        {
            this._studentRepository = studentRepository;
            this._teacherRepository = teacherRepository;
            this._arrangeCourseRepository = arrangeCourseRepository;
        }

        /// <summary>
        /// 获取第一个对象
        /// </summary>
        public dynamic GetFirst()
        {
            var student = _studentRepository.GetList(null).FirstOrDefault();
            var teacher = _teacherRepository.GetList(null).FirstOrDefault();
            var arrangeCourse = _arrangeCourseRepository.GetList(null).FirstOrDefault();
            return new {
                Student=student,
                Teacher=teacher,
                ArrangeCourse=arrangeCourse
            };
        }

        /// <summary>
        /// 获取所有对象
        /// </summary>
        public dynamic GetAll()
        {
            var students = _studentRepository.GetList(null);
            var teachers = _teacherRepository.GetList(null);
            var arrangeCourses = _arrangeCourseRepository.GetIncluding(e => e.Student, e => e.Teacher);
            return new
            {
                Student = students,
                Teacher = teachers,
                ArrangeCourse = arrangeCourses
            };
        }

        /// <summary>
        /// 添加学生
        /// </summary>
        public void AddStudent(string name)
        {
            _studentRepository.Add(new Student() { Name = name });
            
        }
    }
}
