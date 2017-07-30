using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.DatabaseModel.DataAccess
{
    public class PostgreSqlContext :IdentityDbContext<UserBaseModel>
    {
        public PostgreSqlContext(DbContextOptions<PostgreSqlContext> options)
        :base(options)
        {
        }
        
        public DbSet<News> News { get; set; }
        public DbSet<UserBaseModel> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Lecture> Lectures { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
    }
}