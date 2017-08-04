using System;
using System.Collections.Generic;
using System.Linq;
using SSNBackend.Business.Abstractions;
using SSNBackend.Business.Models;

namespace SSNBackend.Test.FakeRepositories
{
    public class NewsRepositoryFake : INewsRepository
    {
        List<News> AllNewses = new List<News>()
        {
            new News
            {
                Id = new Guid("ae8d4af5-fe8b-49b8-855f-fb9bf6a66351"),
                Header = "TestHeader1",
                Subheader = "TestSubheader1",
                Body = "TestBody1"
            },
            new News
            {
                Id = new Guid("ae8d4af5-fe8b-49b8-855f-fb9bf6a66352"),
                Header = "TestHeader2",
                Subheader = "TestSubheader2",
                Body = "TestBody2"
            },
            new News
            {
                Id = new Guid("ae8d4af5-fe8b-49b8-855f-fb9bf6a66353"),
                Header = "TestHeader3",
                Subheader = "TestSubheader3",
                Body = "TestBody3"
            },
            new News
            {
                Id = new Guid("ae8d4af5-fe8b-49b8-855f-fb9bf6a66354"),
                Header = "TestHeader4",
                Subheader = "TestSubheader4",
                Body = "TestBody4"
            }
        };

        public IEnumerable<News> GetAllNews()
        {
            return AllNewses;
        }

        public News GetNewsById(Guid id)
        {
            return AllNewses.FirstOrDefault(n => n.Id == id);
        }

        public void AddNews(News news)
        {
            AllNewses.Add(news);
        }

        public void EditNews(News newsModel)
        {
            var storageNews = AllNewses.FirstOrDefault(n=>n.Id == newsModel.Id);
            
            if (storageNews == null) return;
            
            storageNews.Header = newsModel.Header;
            storageNews.Subheader = newsModel.Subheader;
            storageNews.Body = newsModel.Body;
        }
    }
}