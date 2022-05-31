using DataAccessLayer.Concrete.EntityFramework;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;
using EntityLayer;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {

        CommentManager cm = new CommentManager (new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddComment() {

            return PartialView();
        
        }

        [HttpPost]
        public IActionResult PartialAddComment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.BlogID = 2;
            p.CommentStatus = true;
            cm.CommentAdd(p);

            return RedirectToAction("Index","Blog");

        }

        public IActionResult CommentListByBlog(int id)
        {

            var val = cm.GetList(id);
           
            return PartialView(val);
        }
    }
}
