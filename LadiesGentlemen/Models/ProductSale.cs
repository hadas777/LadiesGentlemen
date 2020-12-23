using LadiesGentlmen.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LadiesGentlemen.Models
{
    public class ProductSale
    {

        [Display(Name = "Product")]
        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int SaleId { get; set; }

        public Sale Sale { get; set; }
    }
}
