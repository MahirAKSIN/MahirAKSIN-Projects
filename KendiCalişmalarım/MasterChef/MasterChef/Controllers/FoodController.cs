using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MasterChef.Controllers
{
    public class FoodController : Controller
    {

        FoodManager fM = new FoodManager(new EfFoodRepository());

        public IActionResult Index()
        {
            var val = fM.GetFoodListWithCategory();
            return View(val);
        }

        public IActionResult Fastfood()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult Create(Food food, IFormFile file)
        {
            if (file != null && (file.ContentType == "image/png" || file.ContentType == "image/jpg"))
            {
                string imageextansion = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageextansion;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
                var steram = new FileStream(path, FileMode.Create);
                file.CopyTo(steram);
                food.FoodImage = $"/images/{imageName}";
            }
            fM.FoddAdd(food);
          
            return RedirectToAction("Index");
        }
        public IActionResult GetFoodDetail(int id)
        {
            ViewBag.i = id;

            var val = fM.GetById(id);
            return View(val);
        }




    }



}

