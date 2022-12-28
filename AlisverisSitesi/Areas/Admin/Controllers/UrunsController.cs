using AlisverisSitesi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace AlisverisSitesi.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize]
    public class UrunsController : Controller
    {
        private readonly UrunContext _context;

       
        private readonly IWebHostEnvironment _webHostEnvironment;


        public UrunsController(UrunContext context, IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            this._webHostEnvironment = webHostEnvironment;
        }

        public async Task<IActionResult> Index(int p = 1)
        {
            int pageSize = 3;
            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Urunlar.Count() / pageSize);

            return View(await _context.Urunlar.OrderByDescending(p => p.Id).Include(p => p.Category).Skip((p - 1) * pageSize).Take(pageSize).ToListAsync());
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name");

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Urun urun)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", urun.CategoryId);

            if (ModelState.IsValid)
            {
                urun.Slug = urun.Name.ToLower().Replace(" ", "-");

                var slug = await _context.Urunlar.FirstOrDefaultAsync(p => p.Slug == urun.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The product already exists.");
                    return View(urun);
                }

                if (urun.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/Urunlar");
                    string imageName = Guid.NewGuid().ToString() + "_" + urun.ImageUpload.FileName;

                    string filePath = Path.Combine(uploadsDir, imageName);

                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await urun.ImageUpload.CopyToAsync(fs);
                    fs.Close();

                    urun.Image = imageName;
                }

                _context.Add(urun);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The product has been created!";

                return RedirectToAction("Index");
            }

            return View(urun);
        }

        public async Task<IActionResult> Edit(int id)
        {
            Urun urun = await _context.Urunlar.FindAsync(id);

            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", urun.CategoryId);

            return View(urun);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Urun urun)
        {
            ViewBag.Categories = new SelectList(_context.Categories, "Id", "Name", urun.CategoryId);

            if (ModelState.IsValid)
            {
                urun.Slug = urun.Name.ToLower().Replace(" ", "-");

                var slug = await _context.Urunlar.FirstOrDefaultAsync(p => p.Slug == urun.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "The product already exists.");
                    return View(urun);
                }

                if (urun.ImageUpload != null)
                {
                    string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/Urunlar");
                    string imageName = Guid.NewGuid().ToString() + "_" + urun.ImageUpload.FileName;

                    string filePath = Path.Combine(uploadsDir, imageName);

                    FileStream fs = new FileStream(filePath, FileMode.Create);
                    await urun.ImageUpload.CopyToAsync(fs);
                    fs.Close();

                    urun.Image = imageName;
                }

                _context.Update(urun);
                await _context.SaveChangesAsync();

                TempData["Success"] = "The product has been edited!";
            }

            return View(urun);
        }

        public async Task<IActionResult> Delete(int id)
        {
            Urun urun = await _context.Urunlar.FindAsync(id);

            if (!string.Equals(urun.Image, "noimage.png"))
            {
                string uploadsDir = Path.Combine(_webHostEnvironment.WebRootPath, "media/products");
                string oldImagePath = Path.Combine(uploadsDir, urun.Image);
                if (System.IO.File.Exists(oldImagePath))
                {
                    System.IO.File.Delete(oldImagePath);
                }
            }

            _context.Urunlar.Remove(urun);
            await _context.SaveChangesAsync();

            TempData["Success"] = "The product has been deleted!";

            return RedirectToAction("Index");
        }
    }
}


