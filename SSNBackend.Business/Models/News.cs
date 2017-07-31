using System;
using System.ComponentModel.DataAnnotations;

namespace SSNBackend.Business.Models
{
    public class News
    {
        public Guid Id { get; set; }
        
        [Display(Name = "Заголовок")]
        [Required, MaxLength(150)]
        public string Header { get; set; }

        [Display(Name = "Подзаголовок")]
        public string Subheader { get; set; }
        
        [Required, MaxLength(3000)]
        [Display(Name = "Тело новости")]
        public string Body { get; set; }

//        TODO Добавить автора новости после ввода авторизации
//        public User Autor { get; set; }
    }
}