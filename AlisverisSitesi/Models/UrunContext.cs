using Microsoft.EntityFrameworkCore;

namespace AlisverisSitesi.Models
{
    public class UrunContext :DbContext
    {
        public DbSet<Urun> Urunlar { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ContactUs> Contacts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AlisverisSitesi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }
}
