using System;
using System.ComponentModel.DataAnnotations;

namespace SSNBackend.Business.Models
{
    public class News
    {
        public Guid Id { get; set; }
        
        [Required, MaxLength(150)]
        public string Header { get; set; }
        
        public string Subheader { get; set; }
        
        [Required, MaxLength(3000)]
        public string Body { get; set; }
    }
}