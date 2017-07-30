using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("Groups", Schema = "Catalog")]
    public class Group:BaseModel
    {
        public string Number { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}