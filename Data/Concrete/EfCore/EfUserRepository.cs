using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MyBlog.Data.Abstract;
using MyBlog.Entity;

namespace MyBlog.Data.Concrete.EfCore
{
    public class EfUserRepository : IUserRepository
    {
        private BlogContext _context;
        public EfUserRepository(BlogContext context)
        { 
            _context = context;
            
        }
        public IQueryable<User> Users => _context.Users;

        public void CreateUser(User User)
        {
           _context.Users.Add(User);
           _context.SaveChanges();
        }
    }
}