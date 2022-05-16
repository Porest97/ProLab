using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class TeamRostersAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlayerType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlayerTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerTypeShortName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HockeyPlayer",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SSN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlayerTypeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HockeyPlayer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HockeyPlayer_PlayerType_PlayerTypeId",
                        column: x => x.PlayerTypeId,
                        principalTable: "PlayerType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TeamRosters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TeamName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClubId = table.Column<int>(type: "int", nullable: true),
                    HeadCoach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssCoach = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeamLeader = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HockeyPlayerId = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId1 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId2 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId3 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId4 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId5 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId6 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId7 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId8 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId9 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId10 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId11 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId12 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId13 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId14 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId15 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId16 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId17 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId18 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId19 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId20 = table.Column<int>(type: "int", nullable: true),
                    HockeyPlayerId21 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamRosters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TeamRosters_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId",
                        column: x => x.HockeyPlayerId,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId1",
                        column: x => x.HockeyPlayerId1,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId10",
                        column: x => x.HockeyPlayerId10,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId11",
                        column: x => x.HockeyPlayerId11,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId12",
                        column: x => x.HockeyPlayerId12,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId13",
                        column: x => x.HockeyPlayerId13,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId14",
                        column: x => x.HockeyPlayerId14,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId15",
                        column: x => x.HockeyPlayerId15,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId16",
                        column: x => x.HockeyPlayerId16,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId17",
                        column: x => x.HockeyPlayerId17,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId18",
                        column: x => x.HockeyPlayerId18,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId19",
                        column: x => x.HockeyPlayerId19,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId2",
                        column: x => x.HockeyPlayerId2,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId20",
                        column: x => x.HockeyPlayerId20,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId21",
                        column: x => x.HockeyPlayerId21,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId3",
                        column: x => x.HockeyPlayerId3,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId4",
                        column: x => x.HockeyPlayerId4,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId5",
                        column: x => x.HockeyPlayerId5,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId6",
                        column: x => x.HockeyPlayerId6,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId7",
                        column: x => x.HockeyPlayerId7,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId8",
                        column: x => x.HockeyPlayerId8,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TeamRosters_HockeyPlayer_HockeyPlayerId9",
                        column: x => x.HockeyPlayerId9,
                        principalTable: "HockeyPlayer",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HockeyPlayer_PlayerTypeId",
                table: "HockeyPlayer",
                column: "PlayerTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_ClubId",
                table: "TeamRosters",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId",
                table: "TeamRosters",
                column: "HockeyPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId1",
                table: "TeamRosters",
                column: "HockeyPlayerId1");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId10",
                table: "TeamRosters",
                column: "HockeyPlayerId10");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId11",
                table: "TeamRosters",
                column: "HockeyPlayerId11");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId12",
                table: "TeamRosters",
                column: "HockeyPlayerId12");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId13",
                table: "TeamRosters",
                column: "HockeyPlayerId13");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId14",
                table: "TeamRosters",
                column: "HockeyPlayerId14");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId15",
                table: "TeamRosters",
                column: "HockeyPlayerId15");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId16",
                table: "TeamRosters",
                column: "HockeyPlayerId16");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId17",
                table: "TeamRosters",
                column: "HockeyPlayerId17");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId18",
                table: "TeamRosters",
                column: "HockeyPlayerId18");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId19",
                table: "TeamRosters",
                column: "HockeyPlayerId19");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId2",
                table: "TeamRosters",
                column: "HockeyPlayerId2");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId20",
                table: "TeamRosters",
                column: "HockeyPlayerId20");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId21",
                table: "TeamRosters",
                column: "HockeyPlayerId21");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId3",
                table: "TeamRosters",
                column: "HockeyPlayerId3");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId4",
                table: "TeamRosters",
                column: "HockeyPlayerId4");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId5",
                table: "TeamRosters",
                column: "HockeyPlayerId5");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId6",
                table: "TeamRosters",
                column: "HockeyPlayerId6");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId7",
                table: "TeamRosters",
                column: "HockeyPlayerId7");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId8",
                table: "TeamRosters",
                column: "HockeyPlayerId8");

            migrationBuilder.CreateIndex(
                name: "IX_TeamRosters_HockeyPlayerId9",
                table: "TeamRosters",
                column: "HockeyPlayerId9");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TeamRosters");

            migrationBuilder.DropTable(
                name: "HockeyPlayer");

            migrationBuilder.DropTable(
                name: "PlayerType");
        }
    }
}
