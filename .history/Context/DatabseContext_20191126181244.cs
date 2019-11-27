using Microsoft.EntityFrameworkCore;

namespace Context {
    public class DatabaseContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DatabaseContext() {}

        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options){
            
        }
    }
}