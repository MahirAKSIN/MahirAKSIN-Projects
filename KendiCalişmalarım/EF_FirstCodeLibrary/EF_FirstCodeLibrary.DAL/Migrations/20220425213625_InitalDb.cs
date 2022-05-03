using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_FirstCodeLibraryy.DAL.Migrations
{
    public partial class InitalDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Authors",
                columns: table => new
                {
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AuthorCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 4, 26, 0, 36, 24, 431, DateTimeKind.Local).AddTicks(6053))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
                });

            migrationBuilder.CreateTable(
                name: "BookDetails",
                columns: table => new
                {
                    BookDetailId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookDetailIsbn = table.Column<string>(type: "nvarchar(max)", nullable: true, defaultValue: "0000-0000-0000"),
                    BookDetailCity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookDetailCountry = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookDetailYear = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 4, 26, 0, 36, 24, 445, DateTimeKind.Local).AddTicks(3379))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.BookDetailId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryDescrition = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Books",
                columns: table => new
                {
                    BookId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    BookCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 4, 26, 0, 36, 24, 444, DateTimeKind.Local).AddTicks(5626)),
                    CategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Books", x => x.BookId);
                    table.ForeignKey(
                        name: "FK_Books_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Authors",
                columns: new[] { "AuthorId", "AuthorFirstName", "AuthorLastName" },
                values: new object[,]
                {
                    { 1, "Mahir", "Aksin" },
                    { 2, "Ahmet", "Arslan" },
                    { 3, "Hakan", "Derkan" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryDescrition", "CategoryName" },
                values: new object[,]
                {
                    { 1, "Romanlar", "Roman" },
                    { 2, "Bilgisayar Kitabı", "Bilgisayar" },
                    { 3, "Hikayeler", "hikaye" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
