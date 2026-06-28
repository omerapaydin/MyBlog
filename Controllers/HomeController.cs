using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data;

namespace MyBlog.Controllers
{
    public class HomeController : Controller
    {
        private IdentityContex _context;
        public HomeController(IdentityContex contex)
        {
            _context = contex;
        }
        public async Task<IActionResult> Index()
        {
            var projects = await _context.Projects
                .Include(x => x.Category)
                .OrderBy(x => x.PublishedOn)
                .ToListAsync();

            return View(projects);
        }
        public IActionResult ByRootDetay()
        {
            return View();
        }
        public IActionResult ProjectDetails()
        {
            return View();
        }
    }
}