using Microsoft.EntityFrameworkCore;
using Model;

namespace DatabaseContext {
    public class BloggingContext : DbContext {
        public BloggingContext()
        {

        }

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {

        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFProviders.InMemory;Trusted_Connection=True;ConnectRetryCount=0");
            }
        }
    }
}