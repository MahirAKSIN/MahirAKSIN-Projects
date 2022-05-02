using Microsoft.AspNetCore.Mvc;
using SalesProject.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            var product = new ProductDAL();
            return View(product.GetAll());
        }
    }
}
