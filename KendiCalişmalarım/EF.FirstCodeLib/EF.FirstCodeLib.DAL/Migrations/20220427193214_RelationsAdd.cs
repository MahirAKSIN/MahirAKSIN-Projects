using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.FirstCodeLib.DAL.Migrations
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
                defaultValue: new DateTime(2022, 4, 27, 22, 32, 13, 900, DateTimeKind.Local).AddTicks(863),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 31, 12, 866, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreateDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 32, 13, 887, DateTimeKind.Local).AddTicks(6314),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 31, 12, 853, DateTimeKind.Local).AddTicks(9043));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 31, 12, 866, DateTimeKind.Local).AddTicks(4495),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 32, 13, 900, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreateDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 31, 12, 853, DateTimeKind.Local).AddTicks(9043),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 32, 13, 887, DateTimeKind.Local).AddTicks(6314));
        }
    }
}
