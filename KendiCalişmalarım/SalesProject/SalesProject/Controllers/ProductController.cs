using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SalesProject.Models.Concrete;
using SalesProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Controllers
{
    public class ProductController : Controller
    {
        //    private readonly ProductDbContext 

        public IActionResult Index()
        {
            var product = new ProductDAL();
            return View(product.GetAll());
        }


        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product product, IFormFile file)
        {
            if (file != null && (file.ContentType == "image/png" || file.ContentType == "image/jpg"))
            {
                string imageextansion = Path.GetExtension(file.FileName);
                string imageName = Guid.NewGuid() + imageextansion;
                string path = Path.Combine(Directory.GetCurrentDirectory(), $"wwwroot/images/{imageName}");
                var steram = new FileStream(path, FileMode.Create);
                file.CopyTo(steram);
                product.ProductImage = $"/images/{imageName}";
            }
            ProductDAL products = new ProductDAL();
            products.Add(product);
            return RedirectToAction("Index");
        }

    }


}

