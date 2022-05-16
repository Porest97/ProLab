using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class HockeyStatsAddedAndIsMatch : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMatch",
                table: "HockeyStats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMatch",
                table: "HockeyStats");
        }
    }
}
