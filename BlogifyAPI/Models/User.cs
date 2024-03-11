using System.ComponentModel.DataAnnotations;

namespace BlogifyAPI.Models
{
    public class User
    {
        [Key]
        public Guid UserID { get; set; }
        public string? Username { get; set; }
        public string? Password { get; set; }
        public long Contact { get; set; }
    }
}
