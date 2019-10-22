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
    public class StudentDomainService:BaseRepository<Student>, IStudentDomainService
    {
        private readonly IBaseRepository<Student> _studentRepository;
        public StudentDomainService(IBaseRepository<Student> studentRepository,LocalDbContext dbc):base(dbc)
        {
            this._studentRepository = studentRepository;
        }
        public IQueryable<Student> GetAllStudent()
        {
            return _studentRepository.GetList(null);
        }
    }
}
