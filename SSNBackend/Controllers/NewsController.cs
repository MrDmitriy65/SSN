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
        public ViewResult Index()
        {
            var allNews = _repository.GetAllNews();
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
            //TODO добавить нормальную валидацию
            if (!ModelState.IsValid) return View();

            _repository.AddNews(model);
            return RedirectToAction(nameof(Index));
        }

        /// <summary>
        /// Выводит форму для редактирования новости
        /// </summary>
        /// <param name="modelId">Id новости</param>
        /// <returns></returns>
        [HttpGet]
        public IActionResult EditNews(Guid modelId)
        {
            //TODO добавить проверку на существование
            News news = _repository.GetNewsById(modelId);
            return View(news);
        }

        /// <summary>
        /// Валидирует модель. Если модель прошла валидацию
        /// изменяет новость
        /// </summary>
        /// <param name="news">Модель новости</param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult EditNews(News news)
        {
            //TODO добавить нормальную валидацию
            if (!ModelState.IsValid) return View();

            _repository.EditNews(news);
            return RedirectToAction(nameof(Index));
        }

        //TODO Добавить удаление
        [HttpPost]
        public RedirectToActionResult DeleteNews(Guid newsId)
        {
            if(_repository.IsNewsExist(newsId))
                _repository.DeleteNews(newsId);
            return RedirectToAction(nameof(Index));
        }
    }
}