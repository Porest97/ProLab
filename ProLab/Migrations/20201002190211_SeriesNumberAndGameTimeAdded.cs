using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class SeriesNumberAndGameTimeAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SeriesNumber",
                table: "Series",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SeriesPlayTime",
                table: "Series",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SeriesNumber",
                table: "Series");

            migrationBuilder.DropColumn(
                name: "SeriesPlayTime",
                table: "Series");
        }
    }
}
