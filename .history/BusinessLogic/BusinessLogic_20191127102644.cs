using System.Collections.Generic;
using System.Linq;
using Model;
using DatabaseContext;

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
            return _context.Blogs.Where(b => b.Url.Contains(term)).OrderBy(b => b.Url).ToList();
        }
    }

}