using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            BlogManager blogManager = new BlogManager(new EfBlogRepository());

           var val= blogManager.GetBlogListByWriter(1);

            return View(val);
        }



    }
}
