using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlisverisSitesi.Models
{
    public class Urun
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public double Price { get; set; }
        [ValidateNever]
        public string? Image { get; set; }
        public int CategoryId { get; set; }
        [ValidateNever]
        public Category? Category { get; set; }
    }
}
