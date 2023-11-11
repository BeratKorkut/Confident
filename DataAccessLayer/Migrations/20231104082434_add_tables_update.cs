using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_tables_update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ilanKonuts",
                table: "ilanKonuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ilanArazis",
                table: "ilanArazis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_emlakTipis",
                table: "emlakTipis");

            migrationBuilder.DropPrimaryKey(
                name: "PK_emlakIlans",
                table: "emlakIlans");

            migrationBuilder.DropPrimaryKey(
                name: "PK_emlakDetays",
                table: "emlakDetays");

            migrationBuilder.RenameTable(
                name: "ilanKonuts",
                newName: "IlanKonuts");

            migrationBuilder.RenameTable(
                name: "ilanArazis",
                newName: "IlanArazis");

            migrationBuilder.RenameTable(
                name: "emlakTipis",
                newName: "EmlakTipis");

            migrationBuilder.RenameTable(
                name: "emlakIlans",
                newName: "EmlakIlans");

            migrationBuilder.RenameTable(
                name: "emlakDetays",
                newName: "EmlakDetays");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "ilanKonuts");

            migrationBuilder.RenameTable(
                name: "IlanArazis",
                newName: "ilanArazis");

            migrationBuilder.RenameTable(
                name: "EmlakTipis",
                newName: "emlakTipis");

            migrationBuilder.RenameTable(
                name: "EmlakIlans",
                newName: "emlakIlans");

            migrationBuilder.RenameTable(
                name: "EmlakDetays",
                newName: "emlakDetays");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ilanKonuts",
                table: "ilanKonuts",
                column: "KonutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ilanArazis",
                table: "ilanArazis",
                column: "ArazıID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emlakTipis",
                table: "emlakTipis",
                column: "TipID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emlakIlans",
                table: "emlakIlans",
                column: "IlanID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_emlakDetays",
                table: "emlakDetays",
                column: "DetayID");
        }
    }
}
