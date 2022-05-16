using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class Hockey4LifeLogsAddedInProLab : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Hockey4LifeLogs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Events = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HockeyDay = table.Column<int>(type: "int", nullable: false),
                    DayInLife = table.Column<int>(type: "int", nullable: false),
                    Hours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfGames = table.Column<int>(type: "int", nullable: false),
                    RefereeId = table.Column<int>(type: "int", nullable: true),
                    GameId = table.Column<int>(type: "int", nullable: true),
                    GameId1 = table.Column<int>(type: "int", nullable: true),
                    GameId2 = table.Column<int>(type: "int", nullable: true),
                    GameId3 = table.Column<int>(type: "int", nullable: true),
                    GameId4 = table.Column<int>(type: "int", nullable: true),
                    GameId5 = table.Column<int>(type: "int", nullable: true),
                    GameId6 = table.Column<int>(type: "int", nullable: true),
                    GameId7 = table.Column<int>(type: "int", nullable: true),
                    GameId8 = table.Column<int>(type: "int", nullable: true),
                    GameId9 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hockey4LifeLogs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId1",
                        column: x => x.GameId1,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId2",
                        column: x => x.GameId2,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId3",
                        column: x => x.GameId3,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId4",
                        column: x => x.GameId4,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId5",
                        column: x => x.GameId5,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId6",
                        column: x => x.GameId6,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId7",
                        column: x => x.GameId7,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId8",
                        column: x => x.GameId8,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Games_GameId9",
                        column: x => x.GameId9,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Hockey4LifeLogs_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_ApplicationUserId",
                table: "Hockey4LifeLogs",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId",
                table: "Hockey4LifeLogs",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId1",
                table: "Hockey4LifeLogs",
                column: "GameId1");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId2",
                table: "Hockey4LifeLogs",
                column: "GameId2");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId3",
                table: "Hockey4LifeLogs",
                column: "GameId3");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId4",
                table: "Hockey4LifeLogs",
                column: "GameId4");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId5",
                table: "Hockey4LifeLogs",
                column: "GameId5");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId6",
                table: "Hockey4LifeLogs",
                column: "GameId6");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId7",
                table: "Hockey4LifeLogs",
                column: "GameId7");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId8",
                table: "Hockey4LifeLogs",
                column: "GameId8");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_GameId9",
                table: "Hockey4LifeLogs",
                column: "GameId9");

            migrationBuilder.CreateIndex(
                name: "IX_Hockey4LifeLogs_RefereeId",
                table: "Hockey4LifeLogs",
                column: "RefereeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Hockey4LifeLogs");
        }
    }
}
