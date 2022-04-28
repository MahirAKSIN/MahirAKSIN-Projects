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
    public class BookConfig : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.BookId);
            builder.Property(b => b.BookName).IsRequired();
            builder.Property(b => b.BookPrice).HasDefaultValue(0);
            builder.Property(b => b.BookCreateDate).HasDefaultValue(DateTime.Now);

            builder.HasOne(b => b.Category).WithMany(c => c.Books).HasForeignKey(b => b.CategoryId).OnDelete(DeleteBehavior.Cascade);
            builder.HasData(

               new Book
               {
                   BookId = 1,
                   BookName = "Yönetim bilişim",
                   BookImage = "https://images-na.ssl-images-amazon.com/images/I/41GKz4PqkNL._SX354_BO1,204,203,200_.jpg",
                   CategoryId = 1

               },
                 new Book
                 {
                     BookId = 2,
                     BookName = "A-z React",
                     BookImage = "https://productimages.hepsiburada.net/s/6/500/9713616060466.jpg",
                     CategoryId = 2

                 },
                   new Book
                   {
                       BookId = 3,
                       BookName = "Diyar Diyar Mardin",
                       BookImage = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/12/33/b6/87/buyuk-mardin-otelinden.jpg?w=400&h=300&s=1",
                       CategoryId = 3

                   }


               );


        }
    }
}
