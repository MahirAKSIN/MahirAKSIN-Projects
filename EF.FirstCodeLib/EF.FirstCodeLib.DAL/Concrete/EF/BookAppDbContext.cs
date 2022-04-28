using EF.FirstCodeLib.DAL.Entities;
using EF.FirstCodeLib.DAL.Concrete.EF.Config;
using Microsoft.EntityFrameworkCore;
using EF.FirstCodeLib.DAL.Concrete.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace EF.FirstCodeLib.DAL.Concrete.EF
{
  public  class BookAppDbContext : DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<BookDetail> BookDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-LOIGVJB;Database=BookAppDb;Trusted_Connection=true;");

            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AuthorConfig).Assembly);
        }

    }


}
