using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Mig11 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AboutDetails1 = table.Column<string>(type: "TEXT", nullable: true),
                    AboutDetails2 = table.Column<string>(type: "TEXT", nullable: true),
                    AboutImage1 = table.Column<string>(type: "TEXT", nullable: true),
                    AboutImage2 = table.Column<string>(type: "TEXT", nullable: true),
                    AboutMapLocation = table.Column<string>(type: "TEXT", nullable: true),
                    AboutStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CategoryName = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryDescription = table.Column<string>(type: "TEXT", nullable: true),
                    CategoryStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    ContactId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ContactUserName = table.Column<string>(type: "TEXT", nullable: true),
                    ContactMail = table.Column<string>(type: "TEXT", nullable: true),
                    ContactSubject = table.Column<string>(type: "TEXT", nullable: true),
                    ContactMessage = table.Column<string>(type: "TEXT", nullable: true),
                    ContactDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ContactStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.ContactId);
                });

            migrationBuilder.CreateTable(
                name: "WriterChefs",
                columns: table => new
                {
                    WriterChefId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    WriterChefName = table.Column<string>(type: "TEXT", nullable: true),
                    WriterChefAbout = table.Column<string>(type: "TEXT", nullable: true),
                    WriterChefImage = table.Column<string>(type: "TEXT", nullable: true),
                    WriterChefMail = table.Column<string>(type: "TEXT", nullable: true),
                    WriterChefPassword = table.Column<string>(type: "TEXT", nullable: true),
                    WriterChefStatus = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WriterChefs", x => x.WriterChefId);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodTitle = table.Column<string>(type: "TEXT", nullable: true),
                    FoodContent = table.Column<string>(type: "TEXT", nullable: true),
                    FoodThumbnailImage = table.Column<string>(type: "TEXT", nullable: true),
                    FoodImage = table.Column<string>(type: "TEXT", nullable: true),
                    FoodCreateDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    FoodStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    CategoryId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.FoodId);
                    table.ForeignKey(
                        name: "FK_Foods_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    CommentId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CommentUserName = table.Column<string>(type: "TEXT", nullable: true),
                    CommentTitle = table.Column<string>(type: "TEXT", nullable: true),
                    CommentContent = table.Column<string>(type: "TEXT", nullable: true),
                    CommentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CommentStatus = table.Column<bool>(type: "INTEGER", nullable: false),
                    FoodID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Foods_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Foods",
                        principalColumn: "FoodId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Comments_FoodID",
                table: "Comments",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "WriterChefs");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "Categories");
        }
    }
}
