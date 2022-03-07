using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JWTTokenAuthInAspNet6_DAL.Models
{
    public class AppUser: IdentityUser
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? AccountType { get; set; }
        public string? PhoneNo { get; set; }
        public string? Password { get; set; }
        public string? ShopName { get; set; }
        public string? BusinessType { get; set; }
        public string? UserRole { get; set; }
        public bool? IsDeleted { get; set; }
    }
}
