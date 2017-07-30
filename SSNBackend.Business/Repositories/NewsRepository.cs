using System.Collections.Generic;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Repositories
{
    public class NewsRepository:ABaseRepository, INewsRepository
    {
        public NewsRepository(PostgreSqlContext context) : base(context)
        {
        }
        
        public IEnumerable<News> News => Context.News;
    }
}