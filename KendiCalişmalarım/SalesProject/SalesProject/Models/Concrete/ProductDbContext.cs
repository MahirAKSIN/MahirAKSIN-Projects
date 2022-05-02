using Microsoft.EntityFrameworkCore;
using SalesProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesProject.Models.Concrete
{
    public class ProductDbContext : DbContext
    {
        public ProductDbContext()
        {

        }
        public ProductDbContext(DbContextOptions<ProductDbContext> options):base(options)
        {

        }
        public DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-LOIGVJB;database=SalesProjectDb;Trusted_Connection=true;");
        }

    }
}
