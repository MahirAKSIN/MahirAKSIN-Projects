using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class AllBlog:ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            BlogManager bM = new BlogManager(new EfBlogRepository());

            var val = bM.ListGetBlog();


            return View(val);


        }


    }
}
