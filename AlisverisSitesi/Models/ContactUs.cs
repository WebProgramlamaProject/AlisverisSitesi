using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace AlisverisSitesi.Models

{
    public class ContactUs 
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ad alanı zorunlu")]
        public string Name { get; set; }
        [Required(ErrorMessage = "mesaj alanı zorunlu")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Mail alanı zorunlu")]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
