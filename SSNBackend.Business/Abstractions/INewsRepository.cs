using System;
using System.Collections.Generic;
using System.Linq;
using SSNBackend.Business.Models;

namespace SSNBackend.Business.Abstractions
{
    public interface INewsRepository
    {
        IEnumerable<News> GetAllNews();
        News GetNewsById(Guid id);
        void AddNews(News news);
        void EditNews(News newsModel);
        bool IsNewsExist(Guid id);
        void DeleteNews(Guid id);
    }
}