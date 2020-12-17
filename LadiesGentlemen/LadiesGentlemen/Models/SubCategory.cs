using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class SubCategory
    {
        
        public int Id { get; set; }
        [Required(ErrorMessage = "You must enter a sub category name")]
        [StringLength(300, ErrorMessage = "Hey, you can't enter more than 300 letters!")]
        public string Name { get; set; }
        public ICollection<Category> Categories { get; set; }
    }
}