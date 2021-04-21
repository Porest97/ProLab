using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class TSMHockeyGameAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TSMHocekyGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDateTime = table.Column<DateTime>(nullable: false),
                    GameNumber = table.Column<string>(nullable: true),
                    Round = table.Column<string>(nullable: true),
                    HomeTeam = table.Column<string>(nullable: true),
                    AwayTeam = table.Column<string>(nullable: true),
                    Arena = table.Column<string>(nullable: true),
                    Series = table.Column<string>(nullable: true),
                    HD1 = table.Column<string>(nullable: true),
                    HD2 = table.Column<string>(nullable: true),
                    LD1 = table.Column<string>(nullable: true),
                    LD2 = table.Column<string>(nullable: true),
                    Supervisor = table.Column<string>(nullable: true),
                    DateChanged = table.Column<string>(nullable: true),
                    ChangedBy = table.Column<string>(nullable: true),
                    GameStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSMHocekyGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSMHocekyGame_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TSMHocekyGame_GameStatusId",
                table: "TSMHocekyGame",
                column: "GameStatusId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TSMHocekyGame");
        }
    }
}
