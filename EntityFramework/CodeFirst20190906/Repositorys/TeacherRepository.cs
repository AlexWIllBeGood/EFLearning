using CodeFirst20190906.IRepositorys;
using CodeFirst20190906.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst20190906.Repositorys
{
    public class TeacherRepository : BaseRepository<Teacher, int>,ITeacherRepository
    {
        private readonly LocalContext _localContex;
        public TeacherRepository(LocalContext localContext) : base(localContext)
        {
            this._localContex = localContext;
        }
    }
}
