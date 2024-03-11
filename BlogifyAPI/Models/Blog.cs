using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogifyAPI.Models
{
    public class Blog
    {
        [Key]
        public Guid BlogID { get; set; }
        public string? Title { get; set; } //Blog Title
        public string? Description { get; set; } //Blog Description
        public string? ImageURL { get; set; } //Image url of relevant which is to be saved on Google Cloud
        public DateTime CreatedAt { get; set; } //Time and date of blog's creation
        [ForeignKey("UserID")]
        public Guid UserID { get; set; }
        public User User { get; set; }
    }
}
