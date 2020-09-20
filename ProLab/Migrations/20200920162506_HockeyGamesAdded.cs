using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class HockeyGamesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber1",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber2",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ssn",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Arena",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArenaNumber = table.Column<string>(nullable: true),
                    ArenaName = table.Column<string>(nullable: true),
                    StreetAddress = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Arena", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Club",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClubNumber = table.Column<string>(nullable: true),
                    ClubName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Club", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameCategory",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameCategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameType",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameTypeName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Series",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SeriesName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Series", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HockeyGame",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDateTime = table.Column<DateTime>(nullable: false),
                    GameNumber = table.Column<string>(nullable: true),
                    TSMNumber = table.Column<string>(nullable: true),
                    GameCategoryId = table.Column<int>(nullable: true),
                    GameStatusId = table.Column<int>(nullable: true),
                    GameTypeId = table.Column<int>(nullable: true),
                    SeriesId = table.Column<int>(nullable: true),
                    ArenaId = table.Column<int>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    ClubId1 = table.Column<int>(nullable: true),
                    HomeTeamScore = table.Column<int>(nullable: true),
                    AwayTeamScore = table.Column<int>(nullable: true),
                    ApplicationUserId = table.Column<string>(nullable: true),
                    ApplicationUserId1 = table.Column<string>(nullable: true),
                    ApplicationUserId2 = table.Column<string>(nullable: true),
                    ApplicationUserId3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HockeyGame", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HockeyGame_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_AspNetUsers_ApplicationUserId1",
                        column: x => x.ApplicationUserId1,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_AspNetUsers_ApplicationUserId2",
                        column: x => x.ApplicationUserId2,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_AspNetUsers_ApplicationUserId3",
                        column: x => x.ApplicationUserId3,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_Arena_ArenaId",
                        column: x => x.ArenaId,
                        principalTable: "Arena",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_Club_ClubId1",
                        column: x => x.ClubId1,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_GameCategory_GameCategoryId",
                        column: x => x.GameCategoryId,
                        principalTable: "GameCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_GameStatus_GameStatusId",
                        column: x => x.GameStatusId,
                        principalTable: "GameStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_GameType_GameTypeId",
                        column: x => x.GameTypeId,
                        principalTable: "GameType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HockeyGame_Series_SeriesId",
                        column: x => x.SeriesId,
                        principalTable: "Series",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ApplicationUserId",
                table: "HockeyGame",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ApplicationUserId1",
                table: "HockeyGame",
                column: "ApplicationUserId1");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ApplicationUserId2",
                table: "HockeyGame",
                column: "ApplicationUserId2");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ApplicationUserId3",
                table: "HockeyGame",
                column: "ApplicationUserId3");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ArenaId",
                table: "HockeyGame",
                column: "ArenaId");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ClubId",
                table: "HockeyGame",
                column: "ClubId");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_ClubId1",
                table: "HockeyGame",
                column: "ClubId1");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_GameCategoryId",
                table: "HockeyGame",
                column: "GameCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_GameStatusId",
                table: "HockeyGame",
                column: "GameStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_GameTypeId",
                table: "HockeyGame",
                column: "GameTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_HockeyGame_SeriesId",
                table: "HockeyGame",
                column: "SeriesId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HockeyGame");

            migrationBuilder.DropTable(
                name: "Arena");

            migrationBuilder.DropTable(
                name: "Club");

            migrationBuilder.DropTable(
                name: "GameCategory");

            migrationBuilder.DropTable(
                name: "GameStatus");

            migrationBuilder.DropTable(
                name: "GameType");

            migrationBuilder.DropTable(
                name: "Series");

            migrationBuilder.DropColumn(
                name: "PhoneNumber1",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PhoneNumber2",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ssn",
                table: "AspNetUsers");
        }
    }
}
