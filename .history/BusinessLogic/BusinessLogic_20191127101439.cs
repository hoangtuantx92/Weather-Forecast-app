using System.Collections.Generic;
using System.Linq;
using Model;

namespace BusinessLogic {
    public class BlogService{
        private BloggingContext _context;

        public BlogService(BloggingContext context)
        {
            _context = context;
        }

        public void Add(string url){
            var blog = new Blog { Url = url };
            _context.Blogs.Add(blog);
            _context.SaveChanges();
        }

        public void Find(string term)
        {
            
        }
    }

}