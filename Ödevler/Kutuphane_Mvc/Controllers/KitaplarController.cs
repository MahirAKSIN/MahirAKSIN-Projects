using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EF_Core_MVC_Code.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EF_Core_MVC_Code.Controllers
{
    public class KitaplarController : Controller
    {
        private readonly KutuphaneSabahContext _context;
   

        public KitaplarController(KutuphaneSabahContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View(_context.Kitaplars.ToList());
        }
        public IActionResult Details(string id)
        {
            var seciliKitap = _context.Kitaplars
                .Include(k => k.Turler)
                .Include(k => k.YayinEvleri)
                .Include(k => k.Yazarlar)
                .First(sk => sk.Isbn == id);
            return View(seciliKitap);
        }

        public IActionResult Edit(string id)
        {
            var seciliKitap = _context.Kitaplars.Find(id);
            ViewData["Tur"] = new SelectList(_context.Turlers, "Id", "TurAd", seciliKitap.TurlerId);
            ViewData["Yazar"] = new SelectList(_context.Yazarlars, "Id", "AdSoyad", seciliKitap.YazarlarId);
            ViewData["YayinEvi"] = new SelectList(_context.Yayinevleris, "Id", "Ad", seciliKitap.YayinEvleriId);
            return View(seciliKitap);
        }

        [HttpPost]
        public IActionResult Edit(Kitaplar kitap)
        {
            _context.Update(kitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(string id)
        {
            var tur = _context.Kitaplars.Find(id);
            return View(tur);

        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(string id)
        {
            var silinecekKitap = _context.Kitaplars.Find(id);
            _context.Remove(silinecekKitap);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();

        }   
        
        [HttpPost]
        public IActionResult Create(Kitaplar kitap)
        {

            if (ModelState.IsValid)
            {
                _context.Add(kitap);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kitap);
        }
    }
}