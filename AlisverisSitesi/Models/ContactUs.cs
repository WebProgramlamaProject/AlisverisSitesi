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
        [Required(ErrorMessage = "bu alan zorunlu")]
        public string Name { get; set; }
        [Required(ErrorMessage = "bu alan zorunlu")]
        public string Message { get; set; }
        [Required(ErrorMessage = "bu alan zorunlu")]
        [EmailAddress]
        public string Email { get; set; }
        public string Subject { get; set; }
    }
}
