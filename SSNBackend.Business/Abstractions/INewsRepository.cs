using System;
using System.Collections.Generic;
using System.Linq;
using SSNBackend.Business.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface INewsRepository
    {
        IQueryable<DatabaseModel.Models.News> News { get; }

        IEnumerable<News> GetAllNews();
        News GetNewsById(Guid id);
        void AddNews(News news);
        void EditNews(News newsModel);
    }
}