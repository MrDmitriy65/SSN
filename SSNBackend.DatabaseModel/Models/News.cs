using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("News", Schema = "Document")]
    public class News : BaseModel
    {
        [Required, MaxLength(150)]
        public string Header { get; set; }
        public string Subheader { get; set; }
        [Required, MaxLength(3000)]
        public string Body { get; set; }
    }
}