using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_MVC_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace EF_Core_MVC_Code.Controllers
{
    public class TurController : Controller
    {
        private readonly KutuphaneSabahContext _context;
        public TurController(KutuphaneSabahContext context)
        {
            _context = context;
            //Bu aşamadan sonra yani nesne ilk üretildiği andan itibaren
            //_context değişkeni benim modelimi temsil ediyor olacak.
            //Bir daha yani, KutuphaneSabahContext'i temsil edecek.k

        }
        //GET-Kitap türlerini listele
        public IActionResult Index()
        {
            return View(_context.Turlers.ToList());
        }

        public IActionResult Delete(int id)
        {
            var turSilme = _context.Turlers.Find(id);
            return View(turSilme);
        }
        [HttpPost, ActionName("Delete")]

        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekTur = _context.Turlers.Find(id);
            _context.Turlers.Remove(silinecekTur);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        //GET-Kitap türü detayını göster
        public IActionResult Details(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }
        //GET-Düzenlenecek kitabın bilgilerini göster

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var tur = _context.Turlers.Find(id);
            return View(tur);
        }
        [HttpPost]
        public IActionResult Edit(Turler tur)
        {
            if (ModelState.IsValid)
            {
                _context.Update(tur);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tur);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Turler tur)
        {
            if (ModelState.IsValid)
            {
                _context.Turlers.Add(tur);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tur);
        }

    }
}