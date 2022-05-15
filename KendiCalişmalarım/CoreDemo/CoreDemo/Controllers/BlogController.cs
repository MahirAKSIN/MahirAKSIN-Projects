using Microsoft.AspNetCore.Mvc;
using System;
using BusinessLayer.Concrete;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLayer.Concrete.EntityFramework;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {

        BlogManager blogManager = new BlogManager(new  EfBlogRepository());

        public IActionResult Index()
        {
            var blogVAlues = blogManager.GetBlogListWithCategory();

            return View(blogVAlues);
        }

        public IActionResult BlogDetails(int id)
        {
            return View();
        }
    }
}
