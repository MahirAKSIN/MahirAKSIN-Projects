using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class Try:ViewComponent
    {
        BlogManager bM = new BlogManager(new EfBlogRepository());


        public IViewComponentResult Invoke()
        {
            var val = bM.GetByBlogId(1);

            return View(val);
        }
 

    }
}
