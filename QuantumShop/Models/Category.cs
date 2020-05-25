using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuantumShop.Models
{
    public class Category
    {
        public int CatId { get; set; }
        [Required]
        public string CatName { get; set; }
    }
}
