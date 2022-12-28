using AlisverisSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlisverisSitesi.Components
{
    public class CategoriesViewCopnent : ViewComponent
    {
        private readonly UrunContext _context;

        public CategoriesViewCopnent(UrunContext context)
        {
            _context = context;
        }
        public async Task<IViewComponentResult> InvokeAsync() => View(await _context.Categories.ToListAsync());
    }
}
