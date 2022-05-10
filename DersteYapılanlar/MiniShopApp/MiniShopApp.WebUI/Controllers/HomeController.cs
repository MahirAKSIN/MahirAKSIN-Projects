using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MiniShopApp.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MiniShopApp.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IProductService _productServices;
        public HomeController(IProductService productService)
        {
            _productServices = productService;
        }
       
        public IActionResult Index()
        {
            return View(_productServices.GetAll());
        }

   //katamnlardaki butun yapıyı servis ile confugration altına altık oradk getall çağırdık
    }
}
