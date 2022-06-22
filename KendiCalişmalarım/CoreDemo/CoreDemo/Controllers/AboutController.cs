using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Authorization;
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

            var val = aboutManager.GetList();

            return View(val);
        }

        public PartialViewResult Invoke()
        {
            return PartialView();
        }
    }
}
