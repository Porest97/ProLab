using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class DHTOHDinRefReceipt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionOthersDH1",
                table: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "DescriptionOthersDH2",
                table: "RefReceipt");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionOthersHD1",
                table: "RefReceipt",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionOthersHD2",
                table: "RefReceipt",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DescriptionOthersHD1",
                table: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "DescriptionOthersHD2",
                table: "RefReceipt");

            migrationBuilder.AddColumn<string>(
                name: "DescriptionOthersDH1",
                table: "RefReceipt",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "DescriptionOthersDH2",
                table: "RefReceipt",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
