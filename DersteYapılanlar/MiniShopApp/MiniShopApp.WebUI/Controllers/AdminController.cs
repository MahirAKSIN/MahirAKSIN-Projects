using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class AdminController : Controller
    {
        private IProductService _productService;
        private ICategoryService _categoryService;
        public AdminController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View(_productService.GetAll());
        }
        public IActionResult ProductCreate()
        {
            ViewBag.Categories = _categoryService.GetAll();
            return View();
        }
        [HttpPost]
        public IActionResult ProductCreate(ProductModel model, int[] categoryIds)
        {
            //Buraya validation işlemleri ile ilgili bir kontrol gelecek.
            var product = new Product()
            {
                Name=model.Name,
                Url=model.Url,
                Price=model.Price,
                Description=model.Description,
                ImageUrl=model.ImageUrl,
                IsApproved=model.IsApproved,
                IsHome=model.IsHome
            };
            _productService.Create(product, categoryIds);

            return RedirectToAction("ProductList");
        }
    }
}
