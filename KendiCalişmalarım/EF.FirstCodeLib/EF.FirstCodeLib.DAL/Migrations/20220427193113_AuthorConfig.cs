using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.FirstCodeLib.DAL.Migrations
{
    public partial class AuthorConfig : Migration
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
                    AuthorCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 4, 27, 22, 31, 12, 853, DateTimeKind.Local).AddTicks(9043))
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Authors", x => x.AuthorId);
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
                    BookCreateDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValue: new DateTime(2022, 4, 27, 22, 31, 12, 866, DateTimeKind.Local).AddTicks(4495)),
                    BookImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookAuthor",
                columns: table => new
                {
                    BookAuthorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookId = table.Column<int>(type: "int", nullable: false),
                    AuthorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookAuthor", x => x.BookAuthorId);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Authors_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Authors",
                        principalColumn: "AuthorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookAuthor_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
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
                    BookDetailYear = table.Column<int>(type: "int", nullable: false, defaultValue: 2022),
                    BookId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookDetails", x => x.BookDetailId);
                    table.ForeignKey(
                        name: "FK_BookDetails_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
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
                    { 2, "Teknik", "Bilgisyar" },
                    { 3, "Kafa", "Dergi" }
                });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookImage", "BookName", "CategoryId" },
                values: new object[] { 1, "https://images-na.ssl-images-amazon.com/images/I/41GKz4PqkNL._SX354_BO1,204,203,200_.jpg", "Yönetim bilişim", 1 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookImage", "BookName", "CategoryId" },
                values: new object[] { 2, "https://productimages.hepsiburada.net/s/6/500/9713616060466.jpg", "A-z React", 2 });

            migrationBuilder.InsertData(
                table: "Books",
                columns: new[] { "BookId", "BookImage", "BookName", "CategoryId" },
                values: new object[] { 3, "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/12/33/b6/87/buyuk-mardin-otelinden.jpg?w=400&h=300&s=1", "Diyar Diyar Mardin", 3 });

            migrationBuilder.InsertData(
                table: "BookAuthor",
                columns: new[] { "BookAuthorId", "AuthorId", "BookId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 2 },
                    { 3, 3, 3 }
                });

            migrationBuilder.InsertData(
                table: "BookDetails",
                columns: new[] { "BookDetailId", "BookDetailCity", "BookDetailCountry", "BookDetailYear", "BookId" },
                values: new object[,]
                {
                    { 1, null, null, 2014, 1 },
                    { 2, null, null, 2022, 2 },
                    { 3, null, null, 2019, 3 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_AuthorId",
                table: "BookAuthor",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_BookAuthor_BookId",
                table: "BookAuthor",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookDetails_BookId",
                table: "BookDetails",
                column: "BookId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Books_CategoryId",
                table: "Books",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookAuthor");

            migrationBuilder.DropTable(
                name: "BookDetails");

            migrationBuilder.DropTable(
                name: "Authors");

            migrationBuilder.DropTable(
                name: "Books");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
