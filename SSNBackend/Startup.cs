using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;
using SSNBackend.Business.Repositories;

namespace SSNBackend
{
    public class Startup
    {
        private readonly IConfigurationRoot Configuration;

        public Startup(IHostingEnvironment env)
        {
            Configuration = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json")
                .Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            var connectonString = Configuration.GetConnectionString("DataAccessPostgreSqlProvider");

            Console.WriteLine(connectonString);

            services.AddDbContext<PostgreSqlContext>(options =>
                options.UseNpgsql(
                    connectonString,
                    b => b.MigrationsAssembly("SSNBackend")));

            services.AddIdentity<UserBaseModel, IdentityRole>()
                .AddEntityFrameworkStores<PostgreSqlContext>();

            services.AddScoped<IUsersRepository, UsersRepository>();
            services.AddScoped<INewsRepository, NewsRepository>();
            services.AddScoped<IScheduleRepository, ScheduleRepository>();
            services.AddScoped<IGroupRepository, GroupRepository>();
            services.AddScoped<ILectureRepository, LectureRepository>();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            app.UseDeveloperExceptionPage();
            app.UseIdentity();
            app.UseMvc(routes =>
                routes.MapRoute(
                    name: "",
                    template: "{controller=News}/{action=Index}")
            );

            app.Run(async (context) => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}