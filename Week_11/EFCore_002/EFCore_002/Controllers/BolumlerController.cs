using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore_002.Controllers
{
    public class BolumlerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
