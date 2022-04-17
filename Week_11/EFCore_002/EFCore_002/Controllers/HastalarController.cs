using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCore_002.Models;

namespace EFCore_002.Controllers
{
    public class HastalarController : Controller
    {
        private readonly HastaneSabahContext _context;

        public HastalarController(HastaneSabahContext context)
        {
            _context = context;
        }

        // GET: Hastalar
        public async Task<IActionResult> Index()
        {
            return View(await _context.Hastalars.ToListAsync());
        }

        // GET: Hastalar/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hastalar = await _context.Hastalars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hastalar == null)
            {
                return NotFound();
            }

            return View(hastalar);
        }

        // GET: Hastalar/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Hastalar/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TcNo,Ad,Soyad,Cinsiyet,Adres,Telefon,Mail")] Hastalar hastalar)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hastalar);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(hastalar);
        }

        // GET: Hastalar/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hastalar = await _context.Hastalars.FindAsync(id);
            if (hastalar == null)
            {
                return NotFound();
            }
            return View(hastalar);
        }

        // POST: Hastalar/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TcNo,Ad,Soyad,Cinsiyet,Adres,Telefon,Mail")] Hastalar hastalar)
        {
            if (id != hastalar.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hastalar);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HastalarExists(hastalar.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(hastalar);
        }

        // GET: Hastalar/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hastalar = await _context.Hastalars
                .FirstOrDefaultAsync(m => m.Id == id);
            if (hastalar == null)
            {
                return NotFound();
            }

            return View(hastalar);
        }

        // POST: Hastalar/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hastalar = await _context.Hastalars.FindAsync(id);
            _context.Hastalars.Remove(hastalar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HastalarExists(int id)
        {
            return _context.Hastalars.Any(e => e.Id == id);
        }
    }
}
