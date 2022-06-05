using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class AboutController : Controller
    {

        AboutManager aboutManager = new AboutManager(new EfAboutRepository());

        public IActionResult Index()
        {

            return View();
        }

        public PartialViewResult Invoke()
        {
            var val = aboutManager.ListGetAbout();

            return PartialView(val);
        }
    }
}
