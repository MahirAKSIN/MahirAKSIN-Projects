using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Controllers
{
    public class FoodController : Controller
    {

        FoodManager fM = new FoodManager(new EfFoodRepository());

        public IActionResult Index()
        {
            var val = fM.GetAllFood();
            return View(val);
        }
        public IActionResult MainCourse()
        {


            return View();
        }


    }
}
