using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AlisverisSitesi.Infrastructure.Validation;

namespace AlisverisSitesi.Models
{
    public class Urun 
    {
        public int Id { get; set; }
        [Display(Name = "Ad")]
        [Required(ErrorMessage = "Please enter a value")]
        public string Name { get; set; }
        
        public string Slug { get; set; }

        [Required, MinLength(4, ErrorMessage = "Minimum length is 2")]
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Fiyat")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a value")]
        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }
        [Required,Range(1, int.MaxValue, ErrorMessage = "You must choose a category")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public Category Category { get; set; }
        [Display(Name = "Resim")]
        public string Image { get; set; } = "noimage.png";
        [NotMapped]
        [FileExtension]
        [Display(Name = "Resim Yükleme")]
        public IFormFile ImageUpload { get; set; }

       
    }
}
