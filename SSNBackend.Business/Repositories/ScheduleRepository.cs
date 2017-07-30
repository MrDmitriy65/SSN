using System.Collections.Generic;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Repositories
{
    public class ScheduleRepository : ABaseRepository, IScheduleRepository
    {
        public ScheduleRepository(PostgreSqlContext context) : base(context)
        {
        }

        public IEnumerable<Schedule> Schedules => Context.Schedules;
    }
}