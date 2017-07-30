using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("Student", Schema = "Catalog")]
    public class Student : UserBaseModel
    {
        [ForeignKey("GroupId")]
        public Group Group { get; set; }
        public bool IsPraerpostor { get; set; }
    }
}