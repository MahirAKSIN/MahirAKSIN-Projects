using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MobilyaShowDetails.Models;

namespace MobilyaShowDetails.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var products = Respository.AllProduct();
            return View(products);
        }
        public IActionResult getProductDetail()
        {
            var products = Respository.AllProduct();
            Product resultProduct = null;
            int id = Convert.ToInt32(ControllerContext.RouteData.Values["ID"]);
            foreach (var item in products)
            {
                if (item.ID == id)
                {
                    resultProduct = item;
                    break;

                }
            }
            ViewBag.Product = resultProduct;
            return View();
        }

    }
}
