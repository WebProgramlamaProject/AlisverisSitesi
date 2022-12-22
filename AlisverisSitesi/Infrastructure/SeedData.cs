using AlisverisSitesi.Data;
using AlisverisSitesi.Models;
using Microsoft.EntityFrameworkCore;
using System.Xml.Linq;

namespace AlisverisSitesi.Infrastructure
{
    
 public class SeedData
 {
     public static void SeedDatabase()
     {  
            UrunContext context= new UrunContext();
            context.Database.Migrate();
            Category fruits = new Category { Name = "Fruits", Slug = "fruits" };
            Category shirts = new Category { Name = "Shirts", Slug = "shirts" };
            
            context.Urunlar.Add(new Urun
            {
                Name = "Apples",
                Slug = "apples",
                Description = "Juicy apples",
                Price = 1.50M,
                Category = fruits,
                Image = "apples.jpg"
            });
            context.Urunlar.Add(new Urun
            {
                Name = "Bananas",
                Slug = "bananas",
                Description = "Fresh bananas",
                Price = 3M,
                Category = fruits,
                Image = "bananas.jpg"
            });
            context.Urunlar.Add(new Urun
            {
                Name = "Watermelon",
                Slug = "watermelon",
                Description = "Juicy watermelon",
                Price = 0.50M,
                Category = fruits,
                Image = "watermelon.jpg"
            });
            context.Urunlar.Add(new Urun
            {
                Name = "Grapefruit",
                Slug = "grapefruit",
                Description = "Juicy grapefruit",
                Price = 2M,
                Category = fruits,
                Image = "grapefruit.jpg"
            });
            context.Urunlar.Add(new Urun
            {
                Name = "White shirt",
                Slug = "white-shirt",
                Description = "White shirt",
                Price = 5.99M,
                Category = shirts,
                Image = "white shirt.jpg"
            });
            context.Urunlar.Add(new Urun
            {
                Name = "Black shirt",
                Slug = "black-shirt",
                Description = "Black shirt",
                Price = 7.99M,
                Category = shirts,
                Image = "black shirt.jpg"
            });
            context.Urunlar.Add(new Urun
            {
                Name = "Yellow shirt",
                Slug = "yellow-shirt",
                Description = "Yellow shirt",
                Price = 11.99M,
                Category = shirts,
                Image = "yellow shirt.jpg"
            });
            
            context.Urunlar.Add(new Urun
            {
                Name = "Grey shirt",
                Slug = "grey-shirt",
                Description = "Grey shirt",
                Price = 12.99M,
                Category = shirts,
                Image = "grey shirt.jpg"
            });

              context.SaveChanges();
            
        }


    }
}


//context.Urunlar.AddRange(
//        new Urun
//        {
//            Name = "Apples",
//            Slug = "apples",
//            Description = "Juicy apples",
//            Price = 1.50M,
//            Category = fruits,
//            Image = "apples.jpg"
//        },
//        new Urun
//        {
//            Name = "Bananas",
//            Slug = "bananas",
//            Description = "Fresh bananas",
//            Price = 3M,
//            Category = fruits,
//            Image = "bananas.jpg"
//        },
//        new Urun
//        {
//            Name = "Watermelon",
//            Slug = "watermelon",
//            Description = "Juicy watermelon",
//            Price = 0.50M,
//            Category = fruits,
//            Image = "watermelon.jpg"
//        },
//        new Urun
//        {
//            Name = "Grapefruit",
//            Slug = "grapefruit",
//            Description = "Juicy grapefruit",
//            Price = 2M,
//            Category = fruits,
//            Image = "grapefruit.jpg"
//        },
//        new Urun
//        {
//            Name = "White shirt",
//            Slug = "white-shirt",
//            Description = "White shirt",
//            Price = 5.99M,
//            Category = shirts,
//            Image = "white shirt.jpg"
//        },
//        new Urun
//        {
//            Name = "Black shirt",
//            Slug = "black-shirt",
//            Description = "Black shirt",
//            Price = 7.99M,
//            Category = shirts,
//            Image = "black shirt.jpg"
//        },
//        new Urun
//        {
//            Name = "Yellow shirt",
//            Slug = "yellow-shirt",
//            Description = "Yellow shirt",
//            Price = 11.99M,
//            Category = shirts,
//            Image = "yellow shirt.jpg"
//        },
//        new Urun
//        {
//            Name = "Grey shirt",
//            Slug = "grey-shirt",
//            Description = "Grey shirt",
//            Price = 12.99M,
//            Category = shirts,
//            Image = "grey shirt.jpg"
//        }
//);


