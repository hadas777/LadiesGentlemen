using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Stock
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter quantity")]
        [Range(0, 99999999, ErrorMessage = "Hey, you must enter quantity between 0 to 99999999!")]
        public int QuantityInStock { get; set; }
        public Color Color { get; set; }
        public Size Size { get; set; }
        public Product Product { get; set; }
        public int ProdactId { get; set; }

    }
}