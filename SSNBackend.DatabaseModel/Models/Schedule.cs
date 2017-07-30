using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("Schedules", Schema = "Document")]
    public class Schedule : BaseModel
    {
        public Group Group { get; set; }
        public Lecture Lecture { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Address { get; set; }
    }
}