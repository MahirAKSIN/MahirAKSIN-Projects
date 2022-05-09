using Microsoft.EntityFrameworkCore;
using MiniShopApp.Entityy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniShopApp.Data.Concrete.EfCore
{
    public class MiniShopContext : DbContext
    {

        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductCategory> ProductCategories { get; set; }  


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=MiniShopAppDb");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //urunıd ve categoryıd aynı olanları bir kere yazacağız
            modelBuilder.Entity<ProductCategory>().HasKey(pc => new { pc.CategoryId, pc.ProductId });
        }
    }
}
