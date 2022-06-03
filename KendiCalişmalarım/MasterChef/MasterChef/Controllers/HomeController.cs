using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using MasterChef.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Controllers
{
    public class HomeController : Controller
    {
        FoodManager fM = new FoodManager(new EfFoodRepository());

        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult Soup()
        //{

        //    return View();

        //}
        //public IActionResult MainCourse()
        //{
        //    var val = fM.GetAllFood();
        //    return View(val);
        //}
        //public IActionResult Dessert()
        //{
        //    return View();
        //}
        //public IActionResult Drink()
        //{
        //    return View();

        //}
        //public IActionResult FastFood()
        //{

        //    return View();
        //}
        public IActionResult Contact()
        {
            return View();
        }
       public IActionResult About()
        {
            return View();
        }
    }
}
