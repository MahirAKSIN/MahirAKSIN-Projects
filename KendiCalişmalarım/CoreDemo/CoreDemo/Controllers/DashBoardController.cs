using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class DashBoardController : Controller
    {
        public IActionResult Index()
        {
            Context c = new Context();
            ViewBag.v = c.Blogs.Count().ToString();
            ViewBag.v1 = c.Blogs.Count(x=>x.WriterId==1).ToString();
            ViewBag.v2 = c.Categories.Count().ToString();
            return View();
        }
    }
}
