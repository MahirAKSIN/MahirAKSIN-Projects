using Microsoft.AspNetCore.Mvc;
using System;
using BusinessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class BlogController : Controller
    {

        BlogManager blogManager = new BlogManager(new  EfBlogRepository());
        CommentManager CommentManager = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            var blogVAlues = blogManager.GetBlogListWithCategory();

            return View(blogVAlues);
        }

        public IActionResult BlogReadAll(int id)
        {
            ViewBag.i =id;
            var val = blogManager.GetByBlogId(id);
            return View(val);
        }
        public IActionResult GetCommentId(int id)
       {

            //var val = blogManager.GetBlogListWithComment();
            //return View(val);

            var val = CommentManager.GetList(id);

            return View(val);

        }
    }
}
