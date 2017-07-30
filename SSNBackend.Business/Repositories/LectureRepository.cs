using System.Collections.Generic;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Repositories
{
    public class LectureRepository : ABaseRepository, ILectureRepository
    {
        public LectureRepository(PostgreSqlContext context) : base(context)
        {
        }

        public IEnumerable<Lecture> Lectures => Context.Lectures;
    }
}