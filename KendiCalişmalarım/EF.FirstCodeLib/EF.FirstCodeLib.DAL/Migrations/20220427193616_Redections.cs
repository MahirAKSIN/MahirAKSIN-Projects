using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF.FirstCodeLib.DAL.Migrations
{
    public partial class Redections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 36, 15, 846, DateTimeKind.Local).AddTicks(2543),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 32, 37, 749, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreateDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 36, 15, 833, DateTimeKind.Local).AddTicks(4914),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 32, 37, 735, DateTimeKind.Local).AddTicks(9966));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "BookCreateDate",
                table: "Books",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 32, 37, 749, DateTimeKind.Local).AddTicks(3255),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 36, 15, 846, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.AlterColumn<DateTime>(
                name: "AuthorCreateDate",
                table: "Authors",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(2022, 4, 27, 22, 32, 37, 735, DateTimeKind.Local).AddTicks(9966),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValue: new DateTime(2022, 4, 27, 22, 36, 15, 833, DateTimeKind.Local).AddTicks(4914));
        }
    }
}
