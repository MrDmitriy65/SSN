using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("Lectures", Schema = "Catalog")]
    public class Lecture : BaseModel
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
    }
}