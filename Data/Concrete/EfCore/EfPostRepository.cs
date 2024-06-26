using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Data.Abstract;
using MyBlog.Entity;

namespace MyBlog.Data.Concrete.EfCore
{
    public class EfPostRepository : IPostRepository
    {
        private BlogContext _context;
        public EfPostRepository(BlogContext context)
        { 
            _context = context;
            
        }
        public IQueryable<Post> Posts => _context.Posts;

        public void CreatePost(Post post)
        {
           _context.Posts.Add(post);
           _context.SaveChanges();
        }
    }
}