using Microsoft.Extensions.DependencyInjection;
using StandardEntityFramework;
using StandardEntityFramework.Repositories;
using StandardInfrastructure.Util;
using StandardModels.Models;
using StandardRepository.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace StandardRepository.Repositories
{
    /// <summary>
    /// 普通仓储结构的写法
    /// EF实际上已经封装数据库操作 这一层可以不存在
    /// </summary>
    [UseDI(ServiceLifetime.Scoped,typeof(IStudentRepository))]
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        private readonly LocalDbContext _localDbContext;
        public StudentRepository(LocalDbContext localDbContext) : base(localDbContext)
        {
            this._localDbContext = localDbContext;
        }
    }
}
