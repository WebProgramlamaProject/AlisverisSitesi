using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AlisverisSitesi.Models
{
    public class Siparis
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime Date { get; set; }

        public string? Description { get; set; }
        public int MusteriId { get; set; }
        [ValidateNever]
        public Musteri? Musteri { get; set; }

    }
}
