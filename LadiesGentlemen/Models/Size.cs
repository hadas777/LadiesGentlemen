using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Size
    {
        
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a size")]
        [StringLength(5, ErrorMessage = "Hey, you can't enter more than 5 letters!")]
        public string Name { get; set; }
    }
}