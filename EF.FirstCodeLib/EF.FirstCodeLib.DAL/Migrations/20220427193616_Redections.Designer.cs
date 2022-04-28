﻿// <auto-generated />
using System;
using EF.FirstCodeLib.DAL.Concrete.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace EF.FirstCodeLib.DAL.Migrations
{
    [DbContext(typeof(BookAppDbContext))]
    [Migration("20220427193616_Redections")]
    partial class Redections
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.16")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Author", b =>
                {
                    b.Property<int>("AuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AuthorCreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 27, 22, 36, 15, 833, DateTimeKind.Local).AddTicks(4914));

                    b.Property<string>("AuthorFirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AuthorLastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AuthorId");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            AuthorId = 1,
                            AuthorCreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Mahir",
                            AuthorLastName = "Aksin"
                        },
                        new
                        {
                            AuthorId = 2,
                            AuthorCreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Ahmet",
                            AuthorLastName = "Arslan"
                        },
                        new
                        {
                            AuthorId = 3,
                            AuthorCreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            AuthorFirstName = "Hakan",
                            AuthorLastName = "Derkan"
                        });
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("BookCreateDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValue(new DateTime(2022, 4, 27, 22, 36, 15, 846, DateTimeKind.Local).AddTicks(2543));

                    b.Property<string>("BookImage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BookPrice")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(0m);

                    b.Property<int?>("CategoryId")
                        .HasColumnType("int");

                    b.HasKey("BookId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookCreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImage = "https://images-na.ssl-images-amazon.com/images/I/41GKz4PqkNL._SX354_BO1,204,203,200_.jpg",
                            BookName = "Yönetim bilişim",
                            BookPrice = 0m,
                            CategoryId = 1
                        },
                        new
                        {
                            BookId = 2,
                            BookCreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImage = "https://productimages.hepsiburada.net/s/6/500/9713616060466.jpg",
                            BookName = "A-z React",
                            BookPrice = 0m,
                            CategoryId = 2
                        },
                        new
                        {
                            BookId = 3,
                            BookCreateDate = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            BookImage = "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/12/33/b6/87/buyuk-mardin-otelinden.jpg?w=400&h=300&s=1",
                            BookName = "Diyar Diyar Mardin",
                            BookPrice = 0m,
                            CategoryId = 3
                        });
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.BookAuthor", b =>
                {
                    b.Property<int>("BookAuthorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookAuthorId");

                    b.HasIndex("AuthorId");

                    b.HasIndex("BookId");

                    b.ToTable("BookAuthor");

                    b.HasData(
                        new
                        {
                            BookAuthorId = 1,
                            AuthorId = 1,
                            BookId = 1
                        },
                        new
                        {
                            BookAuthorId = 2,
                            AuthorId = 2,
                            BookId = 2
                        },
                        new
                        {
                            BookAuthorId = 3,
                            AuthorId = 3,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.BookDetail", b =>
                {
                    b.Property<int>("BookDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BookDetailCity")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDetailCountry")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BookDetailIsbn")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("nvarchar(max)")
                        .HasDefaultValue("0000-0000-0000");

                    b.Property<int>("BookDetailYear")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(2022);

                    b.Property<int>("BookId")
                        .HasColumnType("int");

                    b.HasKey("BookDetailId");

                    b.HasIndex("BookId")
                        .IsUnique();

                    b.ToTable("BookDetails");

                    b.HasData(
                        new
                        {
                            BookDetailId = 1,
                            BookDetailYear = 2014,
                            BookId = 1
                        },
                        new
                        {
                            BookDetailId = 2,
                            BookDetailYear = 2022,
                            BookId = 2
                        },
                        new
                        {
                            BookDetailId = 3,
                            BookDetailYear = 2019,
                            BookId = 3
                        });
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryDescrition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryDescrition = "Romanlar",
                            CategoryName = "Roman"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryDescrition = "Teknik",
                            CategoryName = "Bilgisyar"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryDescrition = "Kafa",
                            CategoryName = "Dergi"
                        });
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Book", b =>
                {
                    b.HasOne("EF.FirstCodeLib.DAL.Entities.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.BookAuthor", b =>
                {
                    b.HasOne("EF.FirstCodeLib.DAL.Entities.Author", "Author")
                        .WithMany("BookAuthors")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.FirstCodeLib.DAL.Entities.Book", "Book")
                        .WithMany("BookAuthors")
                        .HasForeignKey("BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");

                    b.Navigation("Book");
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.BookDetail", b =>
                {
                    b.HasOne("EF.FirstCodeLib.DAL.Entities.Book", "Book")
                        .WithOne("BookDetail")
                        .HasForeignKey("EF.FirstCodeLib.DAL.Entities.BookDetail", "BookId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Author", b =>
                {
                    b.Navigation("BookAuthors");
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Book", b =>
                {
                    b.Navigation("BookAuthors");

                    b.Navigation("BookDetail");
                });

            modelBuilder.Entity("EF.FirstCodeLib.DAL.Entities.Category", b =>
                {
                    b.Navigation("Books");
                });
#pragma warning restore 612, 618
        }
    }
}
