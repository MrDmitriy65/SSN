using System.Collections.Generic;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Repositories
{
    public class UsersRepository: ABaseRepository, IUsersRepository
    {
        public UsersRepository(PostgreSqlContext context) : base(context)
        {
        }

        public IEnumerable<UserBaseModel> Users => Context.Users;
        public IEnumerable<Student> Students => Context.Students;
        public IEnumerable<Teacher> Teachers => Context.Teachers;
    }
}