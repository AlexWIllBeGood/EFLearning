using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using StandardDomain.IService;
using StandardDomain.Services;
using StandardEntityFramework;
using StandardEntityFramework.IRepositories;
using StandardEntityFramework.Repositories;
using StandardModels.Models;

namespace WebApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<LocalDbContext>(options => {
                options.UseMySQL(Configuration.GetConnectionString("local"), (b) => {
                    b.MigrationsAssembly("StandardEntityFramework.Migrations");
                });
            });
            ////依赖注入
            services.AddScoped<IStudentDomainService, StudentDomainService>();
            services.AddScoped<IBaseRepository<Student>, BaseRepository<Student>>();
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
