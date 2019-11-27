using System.Collections.Generic;
using System.Linq;

namespace BusinessLogic {
    public class BlogService{
        private BloggingContext _context;

        public BlogService(BloggingContext context)
        {
            _context = context;
        }

        public void Add(string url){
            var blog = new Blog { Url = url };
            
        }
    }

}