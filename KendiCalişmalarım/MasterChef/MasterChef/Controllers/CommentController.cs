using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Controllers
{
    public class CommentController : Controller
    {

        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult PartialAddCooment()
        {

            return PartialView();
        }
        [HttpPost]
        public IActionResult PartialAddCooment(Comment p)
        {
            p.CommentDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.CommentStatus = true;
            p.FoodID = 2;
            cm.CommentAdd(p);

            return RedirectToAction("Index", "Food");
        }

        public IActionResult CommentListByFood(int id)
        {

            var val = cm.GetById(id);

            return PartialView(val);
        }

    }
}
