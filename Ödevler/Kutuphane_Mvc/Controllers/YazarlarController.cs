using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_Core_MVC_Code.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace EF_Core_MVC_Code.Controllers
{
    public class YazarlarController : Controller
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
        [HttpGet]
        public IActionResult Details(int id)
        {
            var gosterilecek = _context.Yazarlars.Find(id);
            return View(gosterilecek);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var seciliYazar = _context.Yazarlars.Find(id);
            ViewData["Tur"] = new SelectList(_context.Turlers, "Id", "TurAd", seciliYazar.TurlerId);
            return View(seciliYazar);
        }
        [HttpPost]
        public IActionResult Edit(Yazarlar yazar)
        {
            _context.Yazarlars.Update(yazar);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }


        public IActionResult Delete(int id)
        {
            var yazarSilme = _context.Yazarlars.Find(id);
            return View(yazarSilme);
        }
        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekYazar = _context.Yazarlars.Find(id);
            _context.Yazarlars.Remove(silinecekYazar);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Yazarlar yazar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(yazar);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yazar);
        }


    }
}