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
    public class BolumlerController : Controller
    {
        private readonly HastaneSabahContext _context;

        public BolumlerController(HastaneSabahContext context)
        {
            _context = context;
        }

        // GET: Bolumlers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Bolumlers.ToListAsync());
        }

        // GET: Bolumlers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolumler = await _context.Bolumlers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bolumler == null)
            {
                return NotFound();
            }

            return View(bolumler);
        }

        // GET: Bolumlers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Bolumlers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,BolumAd")] Bolumler bolumler)
        {
            if (ModelState.IsValid)
            {
                _context.Add(bolumler);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(bolumler);
        }

        // GET: Bolumlers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolumler = await _context.Bolumlers.FindAsync(id);
            if (bolumler == null)
            {
                return NotFound();
            }
            return View(bolumler);
        }

        // POST: Bolumlers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,BolumAd")] Bolumler bolumler)
        {
            if (id != bolumler.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bolumler);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BolumlerExists(bolumler.Id))
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
            return View(bolumler);
        }

        // GET: Bolumlers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bolumler = await _context.Bolumlers
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bolumler == null)
            {
                return NotFound();
            }

            return View(bolumler);
        }

        // POST: Bolumlers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bolumler = await _context.Bolumlers.FindAsync(id);
            _context.Bolumlers.Remove(bolumler);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BolumlerExists(int id)
        {
            return _context.Bolumlers.Any(e => e.Id == id);
        }
    }
}
