using AlisverisSitesi.Data;
using AlisverisSitesi.Models;
using Microsoft.EntityFrameworkCore;

namespace AlisverisSitesi.Infrastructure
{
    
 public class SeedData
 {
     public static void SeedDatabase(UrunContext context)
     {
         context.Database.Migrate();
            Category fruits = new Category { Name = "Fruits", Slug = "fruits" };
            Category shirts = new Category { Name = "Shirts", Slug = "shirts" };
            UrunContext _context = new UrunContext();
            _context.Urunlar.Add(new Urun
            {
                Name = "Apples",
                Slug = "apples",
                Description = "Juicy apples",
                Price = 1.50M,
                Category = fruits,
                Image = "apples.jpg"
            });
            _context.Urunlar.Add(new Urun
            {
                Name = "Bananas",
                Slug = "bananas",
                Description = "Fresh bananas",
                Price = 3M,
                Category = fruits,
                Image = "bananas.jpg"
            });
            if (!context.Urunlar.Any())
         {
            

                context.Urunlar.AddRange(
                        new Urun
                        {
                            Name = "Apples",
                            Slug = "apples",
                            Description = "Juicy apples",
                            Price = 1.50M,
                            Category = fruits,
                            Image = "apples.jpg"
                        },
                        new Urun
                        {
                            Name = "Bananas",
                            Slug = "bananas",
                            Description = "Fresh bananas",
                            Price = 3M,
                            Category = fruits,
                            Image = "bananas.jpg"
                        },
                        new Urun
                        {
                            Name = "Watermelon",
                            Slug = "watermelon",
                            Description = "Juicy watermelon",
                            Price = 0.50M,
                            Category = fruits,
                            Image = "watermelon.jpg"
                        },
                        new Urun
                        {
                            Name = "Grapefruit",
                            Slug = "grapefruit",
                            Description = "Juicy grapefruit",
                            Price = 2M,
                            Category = fruits,
                            Image = "grapefruit.jpg"
                        },
                        new Urun
                        {
                            Name = "White shirt",
                            Slug = "white-shirt",
                            Description = "White shirt",
                            Price = 5.99M,
                            Category = shirts,
                            Image = "white shirt.jpg"
                        },
                        new Urun
                        {
                            Name = "Black shirt",
                            Slug = "black-shirt",
                            Description = "Black shirt",
                            Price = 7.99M,
                            Category = shirts,
                            Image = "black shirt.jpg"
                        },
                        new Urun
                        {
                            Name = "Yellow shirt",
                            Slug = "yellow-shirt",
                            Description = "Yellow shirt",
                            Price = 11.99M,
                            Category = shirts,
                            Image = "yellow shirt.jpg"
                        },
                        new Urun
                        {
                            Name = "Grey shirt",
                            Slug = "grey-shirt",
                            Description = "Grey shirt",
                            Price = 12.99M,
                            Category = shirts,
                            Image = "grey shirt.jpg"
                        }
                );

                context.SaveChanges();
            }
        }

        
    }
}

