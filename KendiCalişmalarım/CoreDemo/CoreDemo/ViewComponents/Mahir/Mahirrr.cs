using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Mahir
{
    public class Mahirrr:ViewComponent
    {

        BlogManager wM = new BlogManager(new EfBlogRepository());
        

        public IViewComponentResult Invoke()
        {
            var val = wM.ListGetBlog();
            return View(val);
        }


    }
}
