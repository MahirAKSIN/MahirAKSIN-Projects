using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_Core_MVC_Code.Models;

namespace EF_Core_MVC_Code.Controllers
{
    public class YazarlarController:Controller
    {
        private readonly KutuphaneSabahContext _context;
        public YazarlarController(KutuphaneSabahContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Yazarlars.ToList());
        }
        public IActionResult Details(int id)
        {
            var gosterilecek = _context.Yazarlars.Find(id);
            return View(gosterilecek);
        }
    }
}