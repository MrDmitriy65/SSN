using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using SSNBackend.Business.Abstractions;
using SSNBackend.DatabaseModel.Models;

namespace SSNBackend.Controllers
{
    public class NewsController : Controller
    {
        private INewsRepository _repository;

        public NewsController(INewsRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Стартовая страница.
        /// Выводит все новости
        /// </summary>
        /// <returns>Страница с новостями</returns>
        [HttpGet]
        public IActionResult Index()
        {
//            var allNews = _repository.News;
            var fake = new List<News>()
            {
                new News()
                {
                    Id = Guid.NewGuid(),
                    Header = "Header1",
                    Subheader = "Subheader1",
                    Body = "Body1"
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Header = "Header2",
                    Subheader = "Subheader2",
                    Body = "Body2"
                },
                new News()
                {
                    Id = Guid.NewGuid(),
                    Header = "Header3",
                    Subheader = "Subheader3",
                    Body = "Body3"
                }
            };
            return View(fake);
        }

        /// <summary>
        /// Выводит форму для добавления новости
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }

        /// <summary>
        /// Валидирует и добавляет новость
        /// </summary>
        /// <returns>
        /// При успешной валидации редиректит на Index.
        /// Если валидация не прошла, возвращает форму
        /// </returns>
        [HttpPost]
        public IActionResult AddNews(News model)
        {
            return View();
        }
    }
}