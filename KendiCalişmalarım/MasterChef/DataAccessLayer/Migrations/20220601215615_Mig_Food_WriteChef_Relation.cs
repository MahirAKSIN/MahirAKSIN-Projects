using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccessLayer.Migrations
{
    public partial class Mig_Food_WriteChef_Relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Foods",
                type: "INTEGER",
                nullable: true ,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.AddColumn<int>(
                name: "WriterChefId",
                table: "Foods",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Foods_WriterChefId",
                table: "Foods",
                column: "WriterChefId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_WriterChefs_WriterChefId",
                table: "Foods",
                column: "WriterChefId",
                principalTable: "WriterChefs",
                principalColumn: "WriterChefId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.DropForeignKey(
                name: "FK_Foods_WriterChefs_WriterChefId",
                table: "Foods");
            

            migrationBuilder.DropIndex(
                name: "IX_Foods_WriterChefId",
                table: "Foods");

            migrationBuilder.DropColumn(
                name: "WriterChefId",
                table: "Foods");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Foods",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
