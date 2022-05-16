using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class CupControllerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TournamentCategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TournamentCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TournamentCategoryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TournamentCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tournament",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StartDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TournamentCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tournament", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tournament_TournamentCategory_TournamentCategoryId",
                        column: x => x.TournamentCategoryId,
                        principalTable: "TournamentCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CupKvitto",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TournamentId = table.Column<int>(type: "int", nullable: true),
                    RefereeId = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId1 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId2 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId3 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId4 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId5 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId6 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId8 = table.Column<int>(type: "int", nullable: true),
                    HockeyGameId9 = table.Column<int>(type: "int", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefRecStatusId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CupKvitto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId",
                        column: x => x.HockeyGameId,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId1",
                        column: x => x.HockeyGameId1,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId2",
                        column: x => x.HockeyGameId2,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId3",
                        column: x => x.HockeyGameId3,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId4",
                        column: x => x.HockeyGameId4,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId5",
                        column: x => x.HockeyGameId5,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId6",
                        column: x => x.HockeyGameId6,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId8",
                        column: x => x.HockeyGameId8,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_HockeyGame_HockeyGameId9",
                        column: x => x.HockeyGameId9,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_Referee_RefereeId",
                        column: x => x.RefereeId,
                        principalTable: "Referee",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_RefRecStatus_RefRecStatusId",
                        column: x => x.RefRecStatusId,
                        principalTable: "RefRecStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CupKvitto_Tournament_TournamentId",
                        column: x => x.TournamentId,
                        principalTable: "Tournament",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId",
                table: "CupKvitto",
                column: "HockeyGameId");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId1",
                table: "CupKvitto",
                column: "HockeyGameId1");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId2",
                table: "CupKvitto",
                column: "HockeyGameId2");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId3",
                table: "CupKvitto",
                column: "HockeyGameId3");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId4",
                table: "CupKvitto",
                column: "HockeyGameId4");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId5",
                table: "CupKvitto",
                column: "HockeyGameId5");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId6",
                table: "CupKvitto",
                column: "HockeyGameId6");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId8",
                table: "CupKvitto",
                column: "HockeyGameId8");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId9",
                table: "CupKvitto",
                column: "HockeyGameId9");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_RefereeId",
                table: "CupKvitto",
                column: "RefereeId");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_RefRecStatusId",
                table: "CupKvitto",
                column: "RefRecStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_TournamentId",
                table: "CupKvitto",
                column: "TournamentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tournament_TournamentCategoryId",
                table: "Tournament",
                column: "TournamentCategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CupKvitto");

            migrationBuilder.DropTable(
                name: "Tournament");

            migrationBuilder.DropTable(
                name: "TournamentCategory");
        }
    }
}
