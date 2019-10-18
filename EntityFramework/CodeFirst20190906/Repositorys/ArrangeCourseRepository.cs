using CodeFirst20190906.IRepositorys;
using CodeFirst20190906.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst20190906.Repositorys
{
    public class ArrangeCourseRepository : BaseRepository<ArrangeCourse, int>,IArrangeCourseRepository
    {
        private readonly LocalContext _localContext;
        public ArrangeCourseRepository(LocalContext localContext) : base(localContext)
        {
            this._localContext = localContext;
        }
    }
}
