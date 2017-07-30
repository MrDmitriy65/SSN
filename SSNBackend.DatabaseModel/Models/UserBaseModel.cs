using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace SSNBackend.DatabaseModel.Models
{
    [Table("Users", Schema = "Catalog")]
    public class UserBaseModel : IdentityUser
    {
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string SecondName { get; set; }
    }
}