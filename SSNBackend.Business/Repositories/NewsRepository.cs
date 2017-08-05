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

        /// <summary>
        /// Возвращает все новости из БД
        /// </summary>
        /// <returns>Все новости из БД</returns>
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

        /// <summary>
        /// Возвращает новость по ее Id
        /// </summary>
        /// <param name="id">Id новости</param>
        /// <returns>Новость</returns>
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

        /// <summary>
        /// Добавляет в БД новость и задает ей новый Id
        /// </summary>
        /// <param name="news">Новость</param>
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

        /// <summary>
        /// Изменяет все поля новости
        /// </summary>
        /// <param name="newsModel">Новость</param>
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

        /// <summary>
        /// Проверяет существование новости по ее Id
        /// </summary>
        /// <param name="id">Id новости</param>
        /// <returns>True, если новость существует</returns>
        public bool IsNewsExist(Guid id)
        {
            var news = Context.News.FirstOrDefault(n => n.Id == id);
            return news != null;
        }

        /// <summary>
        /// Удаляет существующую новость из БД
        /// </summary>
        /// <param name="id">Id новости, которую нужно удалить</param>
        public void DeleteNews(Guid id)
        {
            var news = Context.News.First(n => n.Id == id);
            Context.News.Remove(news);
            Context.SaveChanges();
        }
    }
}