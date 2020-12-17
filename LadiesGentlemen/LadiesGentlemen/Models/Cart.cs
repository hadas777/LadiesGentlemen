using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlmen.Models
{
    public class Cart
    {
        
        public int Id { get; set; }
        public ICollection<SubCart> SubCarts { get; set; }

    }
}