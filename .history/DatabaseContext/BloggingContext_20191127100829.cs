using Microsoft.EntityFrameworkCore;

namespace DatabaseContext {
    public class BloggingContext : DbContext {
        public BloggingContext()
        {

        }

        public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
        {

        }
    }
}