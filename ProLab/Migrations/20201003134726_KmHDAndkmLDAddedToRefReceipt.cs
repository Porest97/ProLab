using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class KmHDAndkmLDAddedToRefReceipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "KmHD1",
                table: "RefReceipt",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KmHD2",
                table: "RefReceipt",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KmLD1",
                table: "RefReceipt",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "KmLD2",
                table: "RefReceipt",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KmHD1",
                table: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "KmHD2",
                table: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "KmLD1",
                table: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "KmLD2",
                table: "RefReceipt");
        }
    }
}
