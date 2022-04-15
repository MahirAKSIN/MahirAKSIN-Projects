using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Kutuphane.Models;

namespace Kutuphane.Controllers
{
    public class OduncController : Controller
    {
        private readonly KutuphaneSabahContext _context;

        public OduncController(KutuphaneSabahContext context)
        {
            _context = context;
        }

        // GET: Odunc
        public async Task<IActionResult> Index()
        {
            var kutuphaneSabahContext = _context.Oduncs.Include(o => o.KitapIsbnNavigation).Include(o => o.Uye);
            return View(await kutuphaneSabahContext.ToListAsync());
        }

        // GET: Odunc/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odunc = await _context.Oduncs
                .Include(o => o.KitapIsbnNavigation)
                .Include(o => o.Uye)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odunc == null)
            {
                return NotFound();
            }

            return View(odunc);
        }

        // GET: Odunc/Create
        public IActionResult Create()
        {
            ViewData["KitapIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn");
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id");
            return View();
        }

        // POST: Odunc/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,UyeId,KitapIsbn,VerilisTarihi,TeslimTarihi,Iptal")] Odunc odunc)
        {
            if (ModelState.IsValid)
            {
                _context.Add(odunc);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["KitapIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn", odunc.KitapIsbn);
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id", odunc.UyeId);
            return View(odunc);
        }

        // GET: Odunc/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odunc = await _context.Oduncs.FindAsync(id);
            if (odunc == null)
            {
                return NotFound();
            }
            ViewData["KitapIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn", odunc.KitapIsbn);
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id", odunc.UyeId);
            return View(odunc);
        }

        // POST: Odunc/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,UyeId,KitapIsbn,VerilisTarihi,TeslimTarihi,Iptal")] Odunc odunc)
        {
            if (id != odunc.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(odunc);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OduncExists(odunc.Id))
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
            ViewData["KitapIsbn"] = new SelectList(_context.Kitaplars, "Isbn", "Isbn", odunc.KitapIsbn);
            ViewData["UyeId"] = new SelectList(_context.Uyelers, "Id", "Id", odunc.UyeId);
            return View(odunc);
        }

        // GET: Odunc/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var odunc = await _context.Oduncs
                .Include(o => o.KitapIsbnNavigation)
                .Include(o => o.Uye)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (odunc == null)
            {
                return NotFound();
            }

            return View(odunc);
        }

        // POST: Odunc/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var odunc = await _context.Oduncs.FindAsync(id);
            _context.Oduncs.Remove(odunc);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OduncExists(int id)
        {
            return _context.Oduncs.Any(e => e.Id == id);
        }
    }
}
