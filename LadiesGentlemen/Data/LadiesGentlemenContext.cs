using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LadiesGentlmen.Models;

namespace LadiesGentlemen.Data
{
    public class LadiesGentlemenContext : DbContext
    {
        public LadiesGentlemenContext (DbContextOptions<LadiesGentlemenContext> options)
            : base(options)
        {
        }

        public DbSet<LadiesGentlmen.Models.Address> Address { get; set; }

        public DbSet<LadiesGentlmen.Models.Cart> Cart { get; set; }

        public DbSet<LadiesGentlmen.Models.Category> Category { get; set; }

        public DbSet<LadiesGentlmen.Models.Client> Client { get; set; }

        public DbSet<LadiesGentlmen.Models.Color> Color { get; set; }

        public DbSet<LadiesGentlmen.Models.Order> Order { get; set; }

        public DbSet<LadiesGentlmen.Models.Product> Product { get; set; }

        public DbSet<LadiesGentlmen.Models.Size> Size { get; set; }

        public DbSet<LadiesGentlmen.Models.Stock> Stock { get; set; }

        public DbSet<LadiesGentlmen.Models.SubCart> SubCart { get; set; }

        public DbSet<LadiesGentlmen.Models.SubCategory> SubCategory { get; set; }
    }
}
