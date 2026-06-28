using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
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
        public IActionResult Index()
        {
            var projects = _context.Projects.ToList();
            return View(projects);
        }
        public IActionResult ProjectDetails()
        {
            return View();
        }
    }
}