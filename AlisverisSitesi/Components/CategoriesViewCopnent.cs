using AlisverisSitesi.Data;
using AlisverisSitesi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AlisverisSitesi.Components
{
    public class CategoriesViewCopnent : ViewComponent
    {
        UrunContext _context  = new UrunContext();
        public async Task<IViewComponentResult> InvokeAsync() => View(await _context.Categories.ToListAsync());
    }
}
