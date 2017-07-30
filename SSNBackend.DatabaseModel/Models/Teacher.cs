using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("Teachers", Schema = "Catalog")]
    public class Teacher: UserBaseModel
    {
        public string Department { get; set; }
        public ICollection<Lecture> Lectures { get; set; }
    }
}