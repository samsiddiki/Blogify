using Microsoft.EntityFrameworkCore;
using BlogifyAPI.Models;

namespace BlogifyAPI.Data
{
    public class DBHelper : DbContext
    {
        public DBHelper(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Blog> Blog { get; set; }
        public DbSet<User> User { get; set; }
    }
}
