using AlisverisSitesi.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AlisverisSitesi.Data
{
    public class ApplicationDbContext : IdentityDbContext<UserDetails>
    {
        

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {

        }
       

    }
}