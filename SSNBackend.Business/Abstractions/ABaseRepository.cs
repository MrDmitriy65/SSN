using System;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Business.Abstractions
{
    public abstract class ABaseRepository
    {
        protected readonly PostgreSqlContext Context;

        protected ABaseRepository(PostgreSqlContext context)
        {
            Context = context;
        }
    }
}