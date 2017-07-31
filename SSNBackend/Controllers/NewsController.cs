using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using SSNBackend.Business.Abstractions;
using SSNBackend.Business.Models;

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
            var allNews = _repository.News.Select(
                dbNews => new News
                {
                    Id = dbNews.Id,
                    Header = dbNews.Header,
                    Subheader = dbNews.Subheader,
                    Body = dbNews.Body
                });
            return View(allNews);
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
        /// При успешной валидации перенаправляет на Index.
        /// Если валидация не прошла, возвращает форму
        /// </returns>
        [HttpPost]
        public IActionResult AddNews(News model)
        {
            if (!ModelState.IsValid) return View();
            
            _repository.AddNews(model);
            return RedirectToAction(nameof(Index));
        }
    }
}