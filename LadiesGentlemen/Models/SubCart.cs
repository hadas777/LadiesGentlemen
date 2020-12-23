using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class SubCart
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter quantity")]
        [Range(0, 10, ErrorMessage = "Hey, you can order up to 10 items!")]
        public int Quantity { get; set; }
        public ICollection<Stock> Orders { get; set; }

    }
}