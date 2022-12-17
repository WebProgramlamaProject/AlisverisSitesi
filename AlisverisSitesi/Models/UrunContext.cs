using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSitesi.Models
{
    public class UrunContext : DbContext
    {
        public DbSet<Urun>? Urunlar { get; set; }
        public DbSet<Category>? Categories { get; set; }
        public DbSet<ContactUs>? Contacts { get; set; }
        public DbSet<Teammember>? Teammembers { get; set; }
        public DbSet<Siparis>? Siparisler { get; set; }

        public DbSet<Musteri>? Musteriler { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=Alisveris;Trusted_Connection=True;");
        }
    }
}
