using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Color
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter a color name")]
        [StringLength(300, ErrorMessage = "Hey, you can't enter more than 300 letters!")]
        public string Name { get; set; }
    }
}