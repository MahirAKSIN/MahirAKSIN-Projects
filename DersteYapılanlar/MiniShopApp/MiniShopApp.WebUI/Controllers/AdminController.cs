using Microsoft.AspNetCore.Mvc;
using MiniShopApp.Business.Abstract;
using MiniShopApp.Entity;
using MiniShopApp.WebUI.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
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
            if (ModelState.IsValid)
            {
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
                if (_productService.Create(product, categoryIds))
                {
                    CreateMessage("Ürün eklenmiştir", "success");
                    return RedirectToAction("ProductList");
                }
                CreateMessage(_productService.ErrorMessage, "danger");
                
            }
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);

        }
        public IActionResult ProductEdit(int? id)
        {
            var entity = _productService.GetByIdWithCategories((int)id);
            var model = new ProductModel()
            {
                ProductId = entity.ProductId,
                Name = entity.Name,
                Url = entity.Url,
                Price = entity.Price,
                Description = entity.Description,
                ImageUrl = entity.ImageUrl,
                IsApproved = entity.IsApproved,
                IsHome = entity.IsHome,
                SelectedCategories = entity
                    .ProductCategories
                    .Select(i => i.Category)
                    .ToList()
            };
            ViewBag.Categories = _categoryService.GetAll();
            return View(model);
        }
        [HttpPost]
        public IActionResult ProductEdit(ProductModel model, int[] categoryIds)
        {
            //Aslında üçüncü bir parametremiz de olacak. (Create'te de olacak)
            //IFormFile tipinde resim.
            var entity = _productService.GetById(model.ProductId);
            entity.Name = model.Name;
            entity.Price = model.Price;
            entity.Url = model.Url;
            entity.Description = model.Description;
            entity.IsApproved = model.IsApproved;
            entity.IsHome = model.IsHome;
            entity.ImageUrl = model.ImageUrl;
            _productService.Update(entity, categoryIds);
            return RedirectToAction("ProductList");
        }

        public IActionResult ProductDelete(int productId)
        {
            var entity = _productService.GetById(productId);
            _productService.Delete(entity);
            return RedirectToAction("ProductList");
        }

        private void CreateMessage(string message, string alertType)
        {
            var msg = new AlertMessage()
            {
                Message = message,
                AlertType = alertType
            };
            TempData["Message"] = JsonConvert.SerializeObject(msg);
        }
    }
}
