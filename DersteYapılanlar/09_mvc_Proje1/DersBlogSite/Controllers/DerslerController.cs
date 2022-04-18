using DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class DerslerController : Controller
    {
        public IActionResult Index()
        {
           


            var lessons = new List<Lessson>
            {
                new Lessson
                {
                    ID=1,LessontName="HTML", Category="Fronted"
                },
                 new Lessson
                {
                    ID=2,LessontName="CSS", Category="Fronted"
                }, new Lessson
                {
                    ID=3,LessontName="BOOSTRAP", Category="Fronted"
                }, new Lessson
                {
                    ID=4,LessontName="JQUERY", Category="BACKEDD"
                }, new Lessson
                {
                    ID=5,LessontName="C#", Category="BACKEDD"
                }, new Lessson
                {
                    ID=6,LessontName="JAVASCRİPT", Category="Fronted"
                }


            };


            return View(lessons);
        }
    }
}
