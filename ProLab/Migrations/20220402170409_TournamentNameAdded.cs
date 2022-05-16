using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class TournamentNameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TournamentName",
                table: "Tournament",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TournamentName",
                table: "Tournament");
        }
    }
}
