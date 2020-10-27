using ExploreCalifornia.Entities;
using ExploreCalifornia.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace ExploreCalifornia.Controllers
{
    [Route("blog")]
    public class BlogController : Controller
    {
        public BlogController(BlogDataContext dataContext)
        {
            this.dataContext = dataContext;
        }
        public IActionResult Index()
        {
            var blogPosts = dataContext.Posts.OrderByDescending(post => post.Posted).Take(5).ToList();
            return View(blogPosts);
        }

        [Route("{year:min(2000)}/{month:range(1,12)}/{key}")]
        public IActionResult Post(int year, int month, string key)
        {
            var model = dataContext.Posts
                                   .Where(post => post.Key.Equals(key))
                                   .FirstOrDefault();
            return View(model);
        }

        [HttpGet, Route("Create")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost, Route("Create")]
        public IActionResult Create(BlogPost model)
        {
            model.Author = User.Identity.Name;
            model.Posted = DateTime.Now;

            dataContext.Posts.Add(model);
            dataContext.SaveChanges();
            return RedirectToAction(
                "Post",
                "Blog",
                new
                {
                    year = model.Posted.Year,
                    month = model.Posted.Month,
                    key = model.Key
                });
        }

        //

        private readonly BlogDataContext dataContext;
    }
}
