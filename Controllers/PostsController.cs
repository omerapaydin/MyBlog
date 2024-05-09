using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MyBlog.Data.Abstract;
using MyBlog.Entity;

namespace MyBlog.Controllers
{
    public class PostsController: Controller
    {
        private readonly IPostRepository _postRepository;
        private readonly ICommentRepository _commentRepository;
      

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

       public IActionResult AddComment(string Url,string Text,string UserName,int PostId){
        var entity = new Comment {
            Text = Text,
            PublishedOn = DateTime.Now,
            PostId = PostId,
            User = new User {UserName = UserName,Image = "avatar.jpg"}
        };
           _commentRepository.CreateComment(entity);
            return Redirect("/posts/details/" + Url);
       }
    }
}