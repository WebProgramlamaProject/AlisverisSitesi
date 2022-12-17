using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace AlisverisSitesi.Models
{
    public class Category
    {
            public int Id { get; set; }
            public string? Name { get; set; }
            public string? Descrption { get; set; }
            public List<Urun>? Urun { get; set; }
        
    }
}
