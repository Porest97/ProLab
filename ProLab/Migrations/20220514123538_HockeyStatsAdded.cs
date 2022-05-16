using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class HockeyStatsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "HockeyStats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    GameDateTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MatchNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HomeTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AwayTeam = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Arena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Series = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LD1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LD2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TotalPayments = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    HomeTeamScore = table.Column<int>(type: "int", nullable: true),
                    AwayTeamScore = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HockeyStats", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HockeyStats");
        }
    }
}
