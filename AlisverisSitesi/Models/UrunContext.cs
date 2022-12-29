using AlisverisSitesi.Infrastructure;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace AlisverisSitesi.Models
{
    public class UrunContext : IdentityDbContext<UserDetails>
    {

        public UrunContext(DbContextOptions<UrunContext> options) : base(options)
        { }
        public DbSet<Urun> Urunlar { get; set; }
        [Display(Name = "Kategoriler")]
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }
        public DbSet<UserDetails> UserDetailsi { get; set; }


        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AlisverisSitesimodel;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //}
    }
}
