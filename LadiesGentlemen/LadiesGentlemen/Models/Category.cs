using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Category
    {
       
        public int Id { get; set; }

        [Required(ErrorMessage = "You must enter a category name")]
        [StringLength(100, ErrorMessage = "Hey, you can't enter more than 100 letters!")]
        public string Name { get; set; }

    }
}