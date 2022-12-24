using Microsoft.AspNetCore.Identity;
using System.Reflection.Metadata.Ecma335;

namespace AlisverisSitesi.Models
{
    public class AppUser : IdentityUser
    {
        public string Occupation { get; set; }
    }
}
