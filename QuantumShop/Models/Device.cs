using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace QuantumShop.Models
{
    public class Device
    {
        [Required]
        public int DevId { get; set; }
        [Required]
        public string DevName { get; set; }
        [Required]
        public int Price { get; set; }
        public string Description { get; set; }
    }
}
