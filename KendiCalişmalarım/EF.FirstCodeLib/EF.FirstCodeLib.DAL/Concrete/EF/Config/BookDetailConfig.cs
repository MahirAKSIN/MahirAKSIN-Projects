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
    public class BookDetailConfig : IEntityTypeConfiguration<BookDetail>
    {
        public void Configure(EntityTypeBuilder<BookDetail> builder)
        {
            builder.HasKey(bd => bd.BookDetailId);
            builder.Property(bd => bd.BookDetailIsbn).HasDefaultValue("0000-0000-0000");
            builder.Property(bd => bd.BookDetailYear).HasDefaultValue((DateTime.Now.Year));

            builder.HasOne(bd => bd.Book).WithOne(bd => bd.BookDetail).HasForeignKey<BookDetail>(bd => bd.BookId).OnDelete(DeleteBehavior.Cascade);



            builder.HasData(

           new BookDetail
           {

               BookDetailId = 1,
               BookId = 1,
               BookDetailYear = 2014
           },
            new BookDetail
            {

                BookDetailId = 2,
                BookId = 2,
                BookDetailYear = 2022
            },
             new BookDetail
             {

                 BookDetailId = 3,
                 BookId = 3,
                 BookDetailYear = 2019

             }
             ) ;
        }
    }
}

