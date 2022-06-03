using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using MasterChef.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Core;
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
        private readonly IFoodService foodService;
        private readonly ICategoryService categoryService;
        public IActionResult Index()
        {
            var val = fM.GetFoodListWithCategory();
            return View(val);
        }
        public IActionResult FoodList()
        {
            return View(foodService.GetAllFood());
        }
        public IActionResult Fastfood()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = categoryService.GetAllCategory();
            return View();
        }
        [HttpPost]
        public IActionResult Create(FoodModel model, int[] categoryIds, IFormFile file)
        {
            if (ModelState.IsValid && categoryIds.Length > 0 && file != null)
            {
                var url = JobManager.MakeUrl(model.FoodTitle);
                model.FoodImage = JobManager.UploadImage(file, url);
                var product = new Food()
                {
                    FoodTitle = model.FoodTitle,
                    FoodImage = url,
                    FoodContent = model.FoodContent,

                };
                foodService.Create(product, categoryIds);

                TempData["Message"] = JobManager.CreateMessage("Ürün Ekleme", "Ürün ekleme işlemi başarıyla tamamlanmıştır.", "success");

                return RedirectToAction("ProductList");
            }
            if (categoryIds.Length > 0)
            {
                model.Category = categoryIds.Select(catId => new Category()
                {
                    CategoryId = catId
                }).ToList();
            }
            else
            {
                ViewBag.CategoryMessage = "Lütfen en az bir kategori seçiniz!";
            }

            if (file == null)
            {
                ViewBag.ImageMessage = "Lütfen bir resim seçiniz!";
            }
            ViewBag.Categories = categoryService.GetAllCategory();
            return View(model);
        }


        public IActionResult GetFoodDetail(int id)
        {
            ViewBag.i = id;

            var val = fM.GetById(id);
            return View(val);
        }




    }



}

