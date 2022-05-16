using DataAccessLayer.Concrete.EntityFramework;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinessLayer.Concrete;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {

        CommentManager cm = new CommentManager (new EfCommentRepository());

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult PartialAddComment() {

            return PartialView();
        
        }

        public IActionResult CommentListByBlog(int id)
        {

            var val = cm.GetList(id);
           
            return PartialView(val);
        }
    }
}
