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
    public class MiniShopController : Controller
    {
        private IProductService _productService;
        public MiniShopController(IProductService productService)
        {
            _productService=productService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List(string category)
        {
            return View(_productService.GetProductsByCategory(category));
        }

        public IActionResult Details(string url)
        {
            if (url==null)
            {
                return NotFound();
            }
            Product product = _productService.GetProductDetails(url);
            if (product==null)
            {
                return NotFound();
            }
            ProductDetailModel productDetail = new ProductDetailModel()
            {
                Product = product,
                Categories = product.ProductCategories.Select(i => i.Category).ToList() 
            };
            return View(productDetail);  
        }

        public IActionResult Search(string q)
        {
            //Bize arama kriterinin (q) uygun olduğu, eşleştiği TÜM ÜRÜNLERİ
            //döndürecek bir METOT lazım.
            return View(_productService.GetSearchResult(q)); 
        }
    }
}
