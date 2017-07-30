using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [NotMapped]
    public class BaseModel
    {
        [Key]
        public Guid Id { get; set; }
    }
}