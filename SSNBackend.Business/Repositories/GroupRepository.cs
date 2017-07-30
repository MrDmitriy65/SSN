using System.Collections.Generic;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Repositories
{
    public class GroupRepository : ABaseRepository, IGroupRepository
    {
        public GroupRepository(PostgreSqlContext context) : base(context)
        {
        }

        public IEnumerable<Group> Groups => Context.Groups;
    }
}