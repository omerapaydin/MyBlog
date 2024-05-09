using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyBlog.Data.Abstract;
using Microsoft.EntityFrameworkCore;


namespace MyBlog.ViewComponents
{
    public class UsersMenu:ViewComponent
    {
         private IUserRepository _userRepository;

        public UsersMenu(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

         public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _userRepository.Users.ToListAsync());
        }
    }
}