using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF_Core_MVC_Code.Migrations
{
    public partial class Mig_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Turler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TurAd = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Turler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Uyeler",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Cinsiyet = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    Tel = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Mail = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    UyelikTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    UyelikTipi = table.Column<int>(type: "int", nullable: true),
                    TcNo = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Meslek = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    EgitimDurumu = table.Column<int>(type: "int", nullable: true),
                    CezaDurumu = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Uyeler", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yayinevleri",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ad = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Adres = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    Tel = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yayinevleri", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Yazarlar",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AdSoyad = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: true),
                    Cinsiyet = table.Column<string>(type: "varchar(1)", unicode: false, maxLength: 1, nullable: true),
                    DogumTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    Tel = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true),
                    Mail = table.Column<string>(type: "varchar(40)", unicode: false, maxLength: 40, nullable: true),
                    TurID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Yazarlar", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Yazarlar__Turler__3A81B327",
                        column: x => x.TurID,
                        principalTable: "Turler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Kitaplar",
                columns: table => new
                {
                    ISBN = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: false),
                    Ad = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    SayfaSayisi = table.Column<int>(type: "int", nullable: true),
                    Stok = table.Column<int>(type: "int", nullable: true),
                    TurID = table.Column<int>(type: "int", nullable: true),
                    YazarID = table.Column<int>(type: "int", nullable: true),
                    YayinEviID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Kitaplar__447D36EBC8C9DD62", x => x.ISBN);
                    table.ForeignKey(
                        name: "FK__Kitaplar__Turler__4222D4EF",
                        column: x => x.TurID,
                        principalTable: "Turler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__Kitaplar__YayinE__440B1D61",
                        column: x => x.YayinEviID,
                        principalTable: "Yayinevleri",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK__Kitaplar__Yazarl__4316F928",
                        column: x => x.YazarID,
                        principalTable: "Yazarlar",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Odunc",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UyeID = table.Column<int>(type: "int", nullable: true),
                    KitaplarISBN = table.Column<string>(type: "varchar(13)", unicode: false, maxLength: 13, nullable: true),
                    VerilisTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    TeslimTarihi = table.Column<DateTime>(type: "date", nullable: true),
                    Iptal = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Odunc", x => x.ID);
                    table.ForeignKey(
                        name: "FK__Odunc__KitaplarI__47DBAE45",
                        column: x => x.KitaplarISBN,
                        principalTable: "Kitaplar",
                        principalColumn: "ISBN",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK__Odunc__UyeID__46E78A0C",
                        column: x => x.UyeID,
                        principalTable: "Uyeler",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_TurID",
                table: "Kitaplar",
                column: "TurID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YayinEviID",
                table: "Kitaplar",
                column: "YayinEviID");

            migrationBuilder.CreateIndex(
                name: "IX_Kitaplar_YazarID",
                table: "Kitaplar",
                column: "YazarID");

            migrationBuilder.CreateIndex(
                name: "IX_Odunc_KitaplarISBN",
                table: "Odunc",
                column: "KitaplarISBN");

            migrationBuilder.CreateIndex(
                name: "IX_Odunc_UyeID",
                table: "Odunc",
                column: "UyeID");

            migrationBuilder.CreateIndex(
                name: "UQ__Turler__A1D0193D816FCF10",
                table: "Turler",
                column: "TurAd",
                unique: true,
                filter: "[TurAd] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "UQ__Yayinevl__3214AD00DD60C7E3",
                table: "Yayinevleri",
                column: "Ad",
                unique: true,
                filter: "[Ad] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Yazarlar_TurID",
                table: "Yazarlar",
                column: "TurID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Odunc");

            migrationBuilder.DropTable(
                name: "Kitaplar");

            migrationBuilder.DropTable(
                name: "Uyeler");

            migrationBuilder.DropTable(
                name: "Yayinevleri");

            migrationBuilder.DropTable(
                name: "Yazarlar");

            migrationBuilder.DropTable(
                name: "Turler");
        }
    }
}
