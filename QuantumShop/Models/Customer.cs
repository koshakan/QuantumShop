using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace QuantumShop.Models
{
    public class Customer
    { 
        public int Id { get; set; }
        [Required] 
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
