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
    public class MusterisController : Controller
    {
        UrunContext _context = new UrunContext();
        //private readonly UrunContext _context;

        //public MusterisController(UrunContext context)
        //{
        //    _context = context;
        //}

        // GET: Musteris
        public async Task<IActionResult> Index()
        {
              return View(await _context.Musteriler.ToListAsync());
        }


        // GET: Musteris/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Musteriler == null)
            {
                return NotFound();
            }

            var musteri = await _context.Musteriler
                .FirstOrDefaultAsync(m => m.Id == id);
            if (musteri == null)
            {
                return NotFound();
            }

            return View(musteri);
        }

        // POST: Musteris/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Musteriler == null)
            {
                return Problem("Entity set 'UrunContext.Musteriler'  is null.");
            }
            var musteri = await _context.Musteriler.FindAsync(id);
            if (musteri != null)
            {
                _context.Musteriler.Remove(musteri);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MusteriExists(int id)
        {
          return _context.Musteriler.Any(e => e.Id == id);
        }
    }
}
