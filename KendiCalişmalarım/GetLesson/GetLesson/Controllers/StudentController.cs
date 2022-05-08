using GetLesson.Models.Concrete;
using GetLesson.Models.Entites;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GetLesson.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            var context = new BaseRepository<StudentInfo>();
            return View(context.GetAll());
        }


        public IActionResult Details()
        {
            var context = new BaseRepository<StudentInfo>();
            return View(context.Get(context));

        }


    }
}
