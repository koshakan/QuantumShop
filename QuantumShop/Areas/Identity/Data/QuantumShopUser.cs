using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace QuantumShop.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the QuantumShopUser class
    public class QuantumShopUser : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(20)")]
        public string LastName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(50)")]
        public string Email1 { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string Password { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string RePassword { get; set; }

    }
}
