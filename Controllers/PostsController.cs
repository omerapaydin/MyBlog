using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entity;

namespace MyBlog.Controllers
{
    public class PostsController: Controller
    {
        private  IPostRepository _postRepository;
        private ICommentRepository _commentRepository;

      

        public PostsController(IPostRepository postRepository, ICommentRepository commentRepository)
        {
            _postRepository = postRepository;
            _commentRepository = commentRepository;

        }
        public IActionResult Index()
        {
            return View(_postRepository.Posts.ToList());
        }

        public async Task<IActionResult> Details(string Url)
        {
          
            return View(await  _postRepository.Posts.Include(x=>x.Comments).ThenInclude(x=>x.User).FirstOrDefaultAsync(x => x.Url == Url));
        }
        [HttpPost]

       public IActionResult AddComment(string Url,string Text,int PostId){
            
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier); 
            var userName = User.FindFirstValue(ClaimTypes.Name);
            var avatar = User.FindFirstValue(ClaimTypes.UserData);

            var entity = new Comment {
                PostId = PostId,
                Text = Text,
                PublishedOn = DateTime.Now,
                UserId= int.Parse(userId ?? ""),
                User = new User{UserName = userName,Image = avatar}
            };
            _commentRepository.CreateComment(entity);
            return Redirect("/posts/details/" + Url);
       }
    }
}