using System;
using System.Collections.Generic;
using System.Linq;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.DataAccess;
using SSNBackend.DatabaseModel.Models;
using News = SSNBackend.Business.Models.News;

namespace SSNBackend.Business.Repositories
{
    public class NewsRepository : ABaseRepository, INewsRepository
    {
        public NewsRepository(PostgreSqlContext context) : base(context)
        {
        }

        private IQueryable<DatabaseModel.Models.News> News => Context.News;

        public IEnumerable<News> GetAllNews()
        {
            return News.Select(
                n => new News
                {
                    Id = n.Id,
                    Header = n.Header,
                    Subheader = n.Subheader,
                    Body = n.Body
                });
        }

        public News GetNewsById(Guid id)
        {
            return News.Select(n => new News
                {
                    Id = n.Id,
                    Header = n.Header,
                    Subheader = n.Subheader,
                    Body = n.Body
                })
                .FirstOrDefault(n => n.Id == id);
        }

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

        public void EditNews(News newsModel)
        {
            var dbNews = News.FirstOrDefault(n => n.Id == newsModel.Id);
            if (dbNews == null) return;

            dbNews.Header = newsModel.Header;
            dbNews.Subheader = newsModel.Subheader;
            dbNews.Body = newsModel.Body;

            Context.News.Update(dbNews);
            Context.SaveChanges();
        }
    }
}