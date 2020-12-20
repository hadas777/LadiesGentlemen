using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlemen.Models
{
    public class Sale
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Percentage { get; set; }

        public ICollection<ProductSale> Products { get; set; }
    }
}
