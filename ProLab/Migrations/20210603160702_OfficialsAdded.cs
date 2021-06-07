using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class OfficialsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OfficialsGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GroupName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Speaker = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchClock = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MatchProtocol = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoothDoor1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BoothDoor2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShotStatistics = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscJockey = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referee1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Referee2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinesMan1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinesMan2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supervisor = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OfficialsGroups", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OfficialsGroups");
        }
    }
}
