using Microsoft.EntityFrameworkCore;

namespace Context {
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DatabaseContext()
        {

        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }

    public class User {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}