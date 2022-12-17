using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AlisverisSitesi.Models
{
    public class Musteri
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Soyad { get; set; }
        public List<Siparis>? Siparis { get; set; }


    }
}
