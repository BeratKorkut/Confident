using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class mig_update_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_IlanKonuts",
                table: "IlanKonuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_IlanArazis",
                table: "IlanArazis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmlakTipis",
                table: "EmlakTipis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmlakIlans",
                table: "EmlakIlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EmlakDetays",
                table: "EmlakDetays");

            migrationBuilder.RenameTable(
                name: "IlanKonuts",
                newName: "ILANKONUT");

            migrationBuilder.RenameTable(
                name: "IlanArazis",
                newName: "ILANARAZİ");

            migrationBuilder.RenameTable(
                name: "EmlakTipis",
                newName: "EMLAKTİP");

            migrationBuilder.RenameTable(
                name: "EmlakIlans",
                newName: "EMLAKİLAN");

            migrationBuilder.RenameTable(
                name: "EmlakDetays",
                newName: "EMLAKDETAY");

            migrationBuilder.AlterColumn<bool>(
                name: "TapuDurumu",
                table: "ILANKONUT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "Takas",
                table: "ILANKONUT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "SiteIciMi",
                table: "ILANKONUT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "KullanımDurumu",
                table: "ILANKONUT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "KrediyeUygunMu",
                table: "ILANKONUT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "KatSayisi",
                table: "ILANKONUT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "EsyaliMi",
                table: "ILANKONUT",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "BinaYasi",
                table: "ILANKONUT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BanyoSayisi",
                table: "ILANKONUT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "Aidat",
                table: "ILANKONUT",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "Takas",
                table: "ILANARAZİ",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<int>(
                name: "ParselNo",
                table: "ILANARAZİ",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PaftaNo",
                table: "ILANARAZİ",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<bool>(
                name: "KrediyeUygunluk",
                table: "ILANARAZİ",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "KatKarsiligi",
                table: "ILANARAZİ",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<decimal>(
                name: "Kaks",
                table: "ILANARAZİ",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Gabari",
                table: "ILANARAZİ",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "AdaNo",
                table: "ILANARAZİ",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "PK_ILANKONUT",
                table: "ILANKONUT",
                column: "KonutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ILANARAZİ",
                table: "ILANARAZİ",
                column: "ArazıID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMLAKTİP",
                table: "EMLAKTİP",
                column: "TipID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMLAKİLAN",
                table: "EMLAKİLAN",
                column: "IlanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EMLAKDETAY",
                table: "EMLAKDETAY",
                column: "DetayID");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_EMLAKİLAN_EMLAKTİP_TypeeTipID",
                table: "EMLAKİLAN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ILANKONUT",
                table: "ILANKONUT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ILANARAZİ",
                table: "ILANARAZİ");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMLAKTİP",
                table: "EMLAKTİP");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMLAKİLAN",
                table: "EMLAKİLAN");

            migrationBuilder.DropIndex(
                name: "IX_EMLAKİLAN_TypeeTipID",
                table: "EMLAKİLAN");

            migrationBuilder.DropPrimaryKey(
                name: "PK_EMLAKDETAY",
                table: "EMLAKDETAY");

            migrationBuilder.DropColumn(
                name: "TipID",
                table: "EMLAKİLAN");

            migrationBuilder.DropColumn(
                name: "TypeeTipID",
                table: "EMLAKİLAN");

            migrationBuilder.RenameTable(
                name: "ILANKONUT",
                newName: "IlanKonuts");

            migrationBuilder.RenameTable(
                name: "ILANARAZİ",
                newName: "IlanArazis");

            migrationBuilder.RenameTable(
                name: "EMLAKTİP",
                newName: "EmlakTipis");

            migrationBuilder.RenameTable(
                name: "EMLAKİLAN",
                newName: "EmlakIlans");

            migrationBuilder.RenameTable(
                name: "EMLAKDETAY",
                newName: "EmlakDetays");

            migrationBuilder.AlterColumn<bool>(
                name: "TapuDurumu",
                table: "IlanKonuts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Takas",
                table: "IlanKonuts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "SiteIciMi",
                table: "IlanKonuts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "KullanımDurumu",
                table: "IlanKonuts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "KrediyeUygunMu",
                table: "IlanKonuts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "KatSayisi",
                table: "IlanKonuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "EsyaliMi",
                table: "IlanKonuts",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BinaYasi",
                table: "IlanKonuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BanyoSayisi",
                table: "IlanKonuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Aidat",
                table: "IlanKonuts",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "Takas",
                table: "IlanArazis",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ParselNo",
                table: "IlanArazis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PaftaNo",
                table: "IlanArazis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "KrediyeUygunluk",
                table: "IlanArazis",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "KatKarsiligi",
                table: "IlanArazis",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Kaks",
                table: "IlanArazis",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Gabari",
                table: "IlanArazis",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AdaNo",
                table: "IlanArazis",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_IlanKonuts",
                table: "IlanKonuts",
                column: "KonutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_IlanArazis",
                table: "IlanArazis",
                column: "ArazıID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmlakTipis",
                table: "EmlakTipis",
                column: "TipID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmlakIlans",
                table: "EmlakIlans",
                column: "IlanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_EmlakDetays",
                table: "EmlakDetays",
                column: "DetayID");
        }
    }
}
