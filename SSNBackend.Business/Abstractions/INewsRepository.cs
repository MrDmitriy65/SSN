using System.Collections.Generic;
using SSNBackend.Business.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface INewsRepository
    {
        IEnumerable<DatabaseModel.Models.News> News { get; }

        void AddNews(News news);
    }
}