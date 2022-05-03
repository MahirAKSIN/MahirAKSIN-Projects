using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EF_FirstCodeLibraryy.Entities;



namespace EF_FirstCodeLibraryy.Concrete.EF.Config
{
    public class CategoryConfig : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);
            builder.Property(c => c.CategoryName).IsRequired();
            builder.HasData(

                new Category
                {
                    CategoryId = 1,
                    CategoryName = "Roman",
                    CategoryDescrition = "Romanlar"

                },
                new Category
                {
                    CategoryId = 2,
                    CategoryName = "Bilgisayar",
                    CategoryDescrition = "Bilgisayar Kitabı"

                },

                new Category
                {
                    CategoryId = 3,
                    CategoryName = "hikaye",
                    CategoryDescrition = "Hikayeler"
                }


                );

        }
    }
}
