using SSNBackend.DatabaseModel.DataAccess;

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