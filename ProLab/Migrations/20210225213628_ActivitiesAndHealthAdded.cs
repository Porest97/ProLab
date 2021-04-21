using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class ActivitiesAndHealthAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ActivityPostStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ActivityPostStatusName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPostStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HealthActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthActivityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KcalPerHour = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthActivities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ActivityPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeStarted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeEnded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursSpent = table.Column<int>(type: "int", nullable: false),
                    MinutesSpent = table.Column<int>(type: "int", nullable: false),
                    SecondsSpent = table.Column<int>(type: "int", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HealthActivityId = table.Column<int>(type: "int", nullable: false),
                    ActivityPostStatusId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ActivityPosts_ActivityPostStatuses_ActivityPostStatusId",
                        column: x => x.ActivityPostStatusId,
                        principalTable: "ActivityPostStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityPosts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ActivityPosts_HealthActivities_HealthActivityId",
                        column: x => x.HealthActivityId,
                        principalTable: "HealthActivities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPosts_ActivityPostStatusId",
                table: "ActivityPosts",
                column: "ActivityPostStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPosts_ApplicationUserId",
                table: "ActivityPosts",
                column: "ApplicationUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityPosts_HealthActivityId",
                table: "ActivityPosts",
                column: "HealthActivityId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ActivityPosts");

            migrationBuilder.DropTable(
                name: "ActivityPostStatuses");

            migrationBuilder.DropTable(
                name: "HealthActivities");
        }
    }
}
