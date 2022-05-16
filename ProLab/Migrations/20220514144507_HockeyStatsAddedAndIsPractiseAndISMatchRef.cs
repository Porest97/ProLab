using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class HockeyStatsAddedAndIsPractiseAndISMatchRef : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsMatchRef",
                table: "HockeyStats",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsPractise",
                table: "HockeyStats",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsMatchRef",
                table: "HockeyStats");

            migrationBuilder.DropColumn(
                name: "IsPractise",
                table: "HockeyStats");
        }
    }
}
