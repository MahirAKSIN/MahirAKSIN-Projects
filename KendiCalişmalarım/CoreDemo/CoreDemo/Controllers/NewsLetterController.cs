using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class NewsLetterController : Controller
    {
        NewsLetterManager NewsLetter = new NewsLetterManager(new EfNewsLetterRepository());
        public PartialViewResult subscribeMail()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult subscribeMail(NewsLetter p)
        {
            p.Mailstatus = true;
            NewsLetter.AddNewsLetter(p);
            return RedirectToAction("Index","Blog");
        }
    }
}
