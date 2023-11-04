using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "emlakDetays",
                columns: table => new
                {
                    DetayID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cephe = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IcOzellik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DisOzellik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Muhit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ulasim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manzara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KonutTipi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emlakDetays", x => x.DetayID);
                });

            migrationBuilder.CreateTable(
                name: "emlakIlans",
                columns: table => new
                {
                    IlanID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Baslik = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fiyat = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gorsel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Il = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ilce = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adres = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tanım = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IlanTarih = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emlakIlans", x => x.IlanID);
                });

            migrationBuilder.CreateTable(
                name: "emlakTipis",
                columns: table => new
                {
                    TipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipIsim = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipDurum = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_emlakTipis", x => x.TipID);
                });

            migrationBuilder.CreateTable(
                name: "ilanArazis",
                columns: table => new
                {
                    ArazıID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImarDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    m2 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    m2Price = table.Column<int>(type: "int", nullable: false),
                    AdaNo = table.Column<int>(type: "int", nullable: false),
                    ParselNo = table.Column<int>(type: "int", nullable: false),
                    PaftaNo = table.Column<int>(type: "int", nullable: false),
                    Kaks = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Gabari = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TapuDurumu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KatKarsiligi = table.Column<bool>(type: "bit", nullable: false),
                    KrediyeUygunluk = table.Column<bool>(type: "bit", nullable: false),
                    Takas = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilanArazis", x => x.ArazıID);
                });

            migrationBuilder.CreateTable(
                name: "ilanKonuts",
                columns: table => new
                {
                    KonutID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrütM2 = table.Column<int>(type: "int", nullable: false),
                    NetM2 = table.Column<int>(type: "int", nullable: false),
                    OdaSayısı = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BinaYasi = table.Column<int>(type: "int", nullable: false),
                    KatSayisi = table.Column<int>(type: "int", nullable: false),
                    Isıtma = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BanyoSayisi = table.Column<int>(type: "int", nullable: false),
                    EsyaliMi = table.Column<bool>(type: "bit", nullable: false),
                    KullanımDurumu = table.Column<bool>(type: "bit", nullable: false),
                    SiteIciMi = table.Column<bool>(type: "bit", nullable: false),
                    SiteAdi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Aidat = table.Column<int>(type: "int", nullable: false),
                    KrediyeUygunMu = table.Column<bool>(type: "bit", nullable: false),
                    TapuDurumu = table.Column<bool>(type: "bit", nullable: false),
                    Takas = table.Column<bool>(type: "bit", nullable: false),
                    IslendiMi = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ilanKonuts", x => x.KonutID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "emlakDetays");

            migrationBuilder.DropTable(
                name: "emlakIlans");

            migrationBuilder.DropTable(
                name: "emlakTipis");

            migrationBuilder.DropTable(
                name: "ilanArazis");

            migrationBuilder.DropTable(
                name: "ilanKonuts");
        }
    }
}
