using System.Linq;
using SSNBackend.Business.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface INewsRepository
    {
        IQueryable<News> News { get; }

        void AddNews(News news);
        void EditNews(News news);
    }
}