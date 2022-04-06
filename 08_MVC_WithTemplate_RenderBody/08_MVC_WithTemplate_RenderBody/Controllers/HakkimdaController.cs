using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _08_MVC_WithTemplate_RenderBody.Controllers
{
    public class HakkimdaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
