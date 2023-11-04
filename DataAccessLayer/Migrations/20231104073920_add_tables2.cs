using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class add_tables2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ılanKonuts",
                table: "ılanKonuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ılanArazis",
                table: "ılanArazis");

            migrationBuilder.RenameTable(
                name: "ılanKonuts",
                newName: "ilanKonuts");

            migrationBuilder.RenameTable(
                name: "ılanArazis",
                newName: "ilanArazis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ilanKonuts",
                table: "ilanKonuts",
                column: "KonutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ilanArazis",
                table: "ilanArazis",
                column: "ArazıID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ilanKonuts",
                table: "ilanKonuts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ilanArazis",
                table: "ilanArazis");

            migrationBuilder.RenameTable(
                name: "ilanKonuts",
                newName: "ılanKonuts");

            migrationBuilder.RenameTable(
                name: "ilanArazis",
                newName: "ılanArazis");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ılanKonuts",
                table: "ılanKonuts",
                column: "KonutID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ılanArazis",
                table: "ılanArazis",
                column: "ArazıID");
        }
    }
}
