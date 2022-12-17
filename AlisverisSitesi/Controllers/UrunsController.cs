using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using AlisverisSitesi.Models;

namespace AlisverisSitesi.Controllers
{
    public class UrunsController : Controller
    {
        UrunContext _context = new UrunContext();
    

        // GET: Uruns
        public async Task<IActionResult> Index()
        {
            var urunContext = _context.Urunlar.Include(u => u.Category);
            return View(await urunContext.ToListAsync());
        }

        // GET: Uruns/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Urunlar == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunlar
                .Include(u => u.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // GET: Uruns/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            return View();
        }

        // POST: Uruns/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Description,Price,Image,CategoryId")] Urun urun)
        {
            if (ModelState.IsValid)
            {
                _context.Add(urun);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", urun.CategoryId);
            return View(urun);
        }

        // GET: Uruns/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Urunlar == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunlar.FindAsync(id);
            if (urun == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", urun.CategoryId);
            return View(urun);
        }

        // POST: Uruns/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Description,Price,Image,CategoryId")] Urun urun)
        {
            if (id != urun.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(urun);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UrunExists(urun.Id))
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
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", urun.CategoryId);
            return View(urun);
        }

        // GET: Uruns/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Urunlar == null)
            {
                return NotFound();
            }

            var urun = await _context.Urunlar
                .Include(u => u.Category)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (urun == null)
            {
                return NotFound();
            }

            return View(urun);
        }

        // POST: Uruns/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Urunlar == null)
            {
                return Problem("Entity set 'UrunContext.Urunlar'  is null.");
            }
            var urun = await _context.Urunlar.FindAsync(id);
            if (urun != null)
            {
                _context.Urunlar.Remove(urun);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UrunExists(int id)
        {
          return _context.Urunlar.Any(e => e.Id == id);
        }
    }
}
