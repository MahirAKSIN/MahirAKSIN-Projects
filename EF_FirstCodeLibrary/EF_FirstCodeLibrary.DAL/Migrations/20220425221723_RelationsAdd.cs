using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_FirstCodeLibraryy.DAL.Migrations
{
    public partial class RelationsAdd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 1, 17, 23, 40, DateTimeKind.Local).AddTicks(6182),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 0, 37, 11, 81, DateTimeKind.Local).AddTicks(5505));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookDetailYear",
                table: "BookDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 1, 17, 23, 42, DateTimeKind.Local).AddTicks(3748),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 0, 37, 11, 84, DateTimeKind.Local).AddTicks(5307));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreateDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 1, 17, 23, 15, DateTimeKind.Local).AddTicks(2228),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 0, 37, 11, 53, DateTimeKind.Local).AddTicks(3101));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 0, 37, 11, 81, DateTimeKind.Local).AddTicks(5505),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 1, 17, 23, 40, DateTimeKind.Local).AddTicks(6182));

            migrationBuilder.AlterColumn<DateTime>(
                name: "BookDetailYear",
                table: "BookDetails",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 0, 37, 11, 84, DateTimeKind.Local).AddTicks(5307),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 1, 17, 23, 42, DateTimeKind.Local).AddTicks(3748));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreateDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 26, 0, 37, 11, 53, DateTimeKind.Local).AddTicks(3101),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 26, 1, 17, 23, 15, DateTimeKind.Local).AddTicks(2228));
        }
    }
}
