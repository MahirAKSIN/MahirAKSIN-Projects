using EF_FirstCodeLibraryy.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_FirstCodeLibraryy.Concrete.EF.Config
{
    public class AuthorConfig : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.AuthorId);
            builder.Property(a => a.AuthorFirstName).IsRequired();
            builder.Property(a => a.AuthorLastName).IsRequired();
            builder.Ignore(a => a.AuthorFullName);
            builder.Property(a => a.AuthorCreateDate).HasDefaultValue(DateTime.Now);

            builder.HasData(

                new Author
                {
                    AuthorId = 1,
                    AuthorFirstName = "Mahir",
                    AuthorLastName = "Aksin",
                },
                new Author
                {
                    AuthorId = 2,
                    AuthorFirstName = "Ahmet",
                    AuthorLastName = "Arslan",

                },
                new Author
                {
                    AuthorId = 3,
                    AuthorFirstName = "Hakan",
                    AuthorLastName = "Derkan"
                }

                );
        }
    }
}

