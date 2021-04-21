using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class TSMGamesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TSMSeries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TSMSeriesName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSMSeries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TSMGames",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GameDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TSMNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArenaId = table.Column<int>(type: "int", nullable: true),
                    ClubId = table.Column<int>(type: "int", nullable: true),
                    ClubId1 = table.Column<int>(type: "int", nullable: true),
                    HomeTeamScore = table.Column<int>(type: "int", nullable: true),
                    AwayTeamScore = table.Column<int>(type: "int", nullable: true),
                    RefereeId = table.Column<int>(type: "int", nullable: true),
                    RefereeId1 = table.Column<int>(type: "int", nullable: true),
                    RefereeId2 = table.Column<int>(type: "int", nullable: true),
                    RefereeId3 = table.Column<int>(type: "int", nullable: true),
                    TSMSeriesId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TSMGames", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TSMGames_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_Club_ClubId1",
                        column: x => x.ClubId1,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_Referee_RefereeId1",
                        column: x => x.RefereeId1,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_Referee_RefereeId2",
                        column: x => x.RefereeId2,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_Referee_RefereeId3",
                        column: x => x.RefereeId3,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TSMGames_TSMSeries_TSMSeriesId",
                        column: x => x.TSMSeriesId,
                        principalTable: "TSMSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_ArenaId",
                table: "TSMGames",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_ClubId",
                table: "TSMGames",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_ClubId1",
                table: "TSMGames",
                column: "ClubId1");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_RefereeId",
                table: "TSMGames",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_RefereeId1",
                table: "TSMGames",
                column: "RefereeId1");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_RefereeId2",
                table: "TSMGames",
                column: "RefereeId2");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_RefereeId3",
                table: "TSMGames",
                column: "RefereeId3");

            migrationBuilder.CreateIndex(
                name: "IX_TSMGames_TSMSeriesId",
                table: "TSMGames",
                column: "TSMSeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TSMGames");

            migrationBuilder.DropTable(
                name: "TSMSeries");
        }
    }
}
