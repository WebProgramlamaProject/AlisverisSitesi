﻿using Microsoft.AspNetCore.Identity;

namespace AlisverisSitesi.Models
{
    public class UserDetails : IdentityUser
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }


       

    }
}
