using EF.FirstCodeLib.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF.FirstCodeLib.DAL.Concrete.EF.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName).IsRequired();
            builder.HasData(
                new Category { CategoryId = 1, CategoryName = "Roman", CategoryDescrition = "Romanlar" },
                new Category { CategoryId = 2, CategoryName = "Bilgisyar", CategoryDescrition = "Teknik" },
                new Category { CategoryId = 3, CategoryName = "Dergi", CategoryDescrition = "Kafa" }



                );
        }
    }
}
