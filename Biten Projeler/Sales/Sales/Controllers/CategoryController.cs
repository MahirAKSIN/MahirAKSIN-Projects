using Microsoft.AspNetCore.Mvc;
using Sales.Models.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Controllers
{
    public class CategoryController : Controller
    {

        private readonly SalesDbContext _context;

        public CategoryController(SalesDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {

            var categories = new CategoryDAL();
            return View(categories.GetAll());
        }
    }
}
