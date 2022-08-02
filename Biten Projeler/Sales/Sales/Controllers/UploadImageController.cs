using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class UploadImageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
