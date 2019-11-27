using Microsoft.EntityFrameworkCore;

namespace DatabaseContext {
    public class TestDatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public TestDatabaseContext()
        {

        }

        public TestDatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
    }

    public class User {
        public int Id { get; set; }
        public string Email { get; set; }
    }
}