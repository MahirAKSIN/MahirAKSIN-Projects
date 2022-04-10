using DersBlogSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersBlogSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var makale = new List<Makale>
            {
                new Makale
                {
                    ID=1,Header="HTML", Content="  Lorem ipsum dolor, sit amet consectetur adipisicing elit.asdsaQuas reiciendis quam et voluptatem eveniet repellat labore alias ipsum dolore veritatis, "
                    
                },
                 new Makale
                {
                    ID=2,Header="CSS",Content="  Lorem ipsum dolor, sit amet consectetur adipisicing elit.asdsaQuas reiciendis quam et voluptatem eveniet repellat labore alias ipsum dolore veritatis, "
                }, new Makale
                {
                    ID=3,Header="BOOSTRAP", Content="  Lorem ipsum dolor, sit amet consectetur adipisicing elit.asdsaQuas reiciendis quam et voluptatem eveniet repellat labore alias ipsum dolore veritatis, "
                }, new Makale
                {
                    ID=4,Header="JQUERY", Content="  Lorem ipsum dolor, sit amet consectetur adipisicing elit.asdsaQuas reiciendis quam et voluptatem eveniet repellat labore alias ipsum dolore veritatis, "
                }, new Makale
                {
                    ID=5,Header="C#",Content="  Lorem ipsum dolor, sit amet consectetur adipisicing elit.asdsaQuas reiciendis quam et voluptatem eveniet repellat labore alias ipsum dolore veritatis, "
                }, new Makale
                {
                    ID=6,Header="JAVASCRİPT", Content="  Lorem ipsum dolor, sit amet consectetur adipisicing elit.asdsaQuas reiciendis quam et voluptatem eveniet repellat labore alias ipsum dolore veritatis, "
                }


            };
            ViewBag.mahir =makale;

            return View(makale);
        }
    }
}
