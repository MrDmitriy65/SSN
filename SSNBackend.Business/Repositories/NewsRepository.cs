using System;
using System.Collections.Generic;
using System.Linq;
using SSNBackend.Business.Abstractions;
using SSNBackend.Business.Models;
using SSNBackend.DatabaseModel.DataAccess;

namespace SSNBackend.Business.Repositories
{
    public class NewsRepository:ABaseRepository, INewsRepository
    {
        public NewsRepository(PostgreSqlContext context) : base(context)
        {
        }
        
        public IQueryable<News> News => Context.News.Select(n => new News
        {
            Id = n.Id,
            Header = n.Header,
            Subheader = n.Subheader,
            Body = n.Body
        });

        public void AddNews(News news)
        {
            Context.News.Add(new DatabaseModel.Models.News
            {
                Id = Guid.NewGuid(),
                Header = news.Header,
                Subheader = news.Subheader,
                Body = news.Body
            });

            Context.SaveChanges();
        }

        public void EditNews(News news)
        {
            News theNews = News.FirstOrDefault(n => n.Id == news.Id);
            if(theNews == null) return;
            var dbNews  = Context.News.FirstOrDefault(n => n.Id == news.Id);

            dbNews.Header = news.Header;
            dbNews.Subheader = news.Subheader;
            dbNews.Body = news.Body;
            Context.News.Update(dbNews);
            Context.SaveChanges();
        }
    }
}