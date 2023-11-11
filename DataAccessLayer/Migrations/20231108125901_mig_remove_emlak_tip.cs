using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_remove_emlak_tip : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EMLAKİLAN_EMLAKTİP_TypeeTipID",
                table: "EMLAKİLAN");

            migrationBuilder.DropTable(
                name: "EMLAKTİP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ILANARAZİ",
                table: "ILANARAZİ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMLAKİLAN",
                table: "EMLAKİLAN");

            migrationBuilder.DropIndex(
                name: "IX_EMLAKİLAN_TypeeTipID",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "Gorsel",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "IlanTarih",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "TipID",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "TypeeTipID",
                table: "EMLAKİLAN");

            migrationBuilder.RenameTable(
                name: "ILANARAZİ",
                newName: "ILANARAZI");

            migrationBuilder.RenameTable(
                name: "EMLAKİLAN",
                newName: "EMLAKILAN");

            migrationBuilder.RenameColumn(
                name: "Tanım",
                table: "EMLAKILAN",
                newName: "TipDetay");

            migrationBuilder.RenameColumn(
                name: "Ilce",
                table: "EMLAKILAN",
                newName: "Tip");

            migrationBuilder.RenameColumn(
                name: "Il",
                table: "EMLAKILAN",
                newName: "KiralikSatilik");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fiyat",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gorsel",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IlanTarih",
                table: "ILANKONUT",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tanım",
                table: "ILANKONUT",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fiyat",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gorsel",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Il",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IlanTarih",
                table: "ILANARAZI",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Ilce",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Tanım",
                table: "ILANARAZI",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ILANARAZI",
                table: "ILANARAZI",
                column: "ArazıID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMLAKILAN",
                table: "EMLAKILAN",
                column: "IlanID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ILANARAZI",
                table: "ILANARAZI");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMLAKILAN",
                table: "EMLAKILAN");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Gorsel",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "IlanTarih",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Tanım",
                table: "ILANKONUT");

            migrationBuilder.DropColumn(
                name: "Adres",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "Baslik",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "Fiyat",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "Gorsel",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "Il",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "IlanTarih",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "Ilce",
                table: "ILANARAZI");

            migrationBuilder.DropColumn(
                name: "Tanım",
                table: "ILANARAZI");

            migrationBuilder.RenameTable(
                name: "ILANARAZI",
                newName: "ILANARAZİ");

            migrationBuilder.RenameTable(
                name: "EMLAKILAN",
                newName: "EMLAKİLAN");

            migrationBuilder.RenameColumn(
                name: "TipDetay",
                table: "EMLAKİLAN",
                newName: "Tanım");

            migrationBuilder.RenameColumn(
                name: "Tip",
                table: "EMLAKİLAN",
                newName: "Ilce");

            migrationBuilder.RenameColumn(
                name: "KiralikSatilik",
                table: "EMLAKİLAN",
                newName: "Il");

            migrationBuilder.AddColumn<string>(
                name: "Adres",
                table: "EMLAKİLAN",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Baslik",
                table: "EMLAKİLAN",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Fiyat",
                table: "EMLAKİLAN",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gorsel",
                table: "EMLAKİLAN",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "IlanTarih",
                table: "EMLAKİLAN",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "TipID",
                table: "EMLAKİLAN",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TypeeTipID",
                table: "EMLAKİLAN",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ILANARAZİ",
                table: "ILANARAZİ",
                column: "ArazıID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMLAKİLAN",
                table: "EMLAKİLAN",
                column: "IlanID");

            migrationBuilder.CreateTable(
                name: "EMLAKTİP",
                columns: table => new
                {
                    TipID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipDurum = table.Column<bool>(type: "bit", nullable: false),
                    TipIsim = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EMLAKTİP", x => x.TipID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_EMLAKİLAN_TypeeTipID",
                table: "EMLAKİLAN",
                column: "TypeeTipID");

            migrationBuilder.AddForeignKey(
                name: "FK_EMLAKİLAN_EMLAKTİP_TypeeTipID",
                table: "EMLAKİLAN",
                column: "TypeeTipID",
                principalTable: "EMLAKTİP",
                principalColumn: "TipID");
        }
    }
}
