using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class PsotedAndChangedAddedInHockeyGames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TSMHocekyGame_GameStatus_GameStatusId",
                table: "TSMHocekyGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TSMHocekyGame",
                table: "TSMHocekyGame");

            migrationBuilder.RenameTable(
                name: "TSMHocekyGame",
                newName: "TSMHockeyGame");

            migrationBuilder.RenameIndex(
                name: "IX_TSMHocekyGame_GameStatusId",
                table: "TSMHockeyGame",
                newName: "IX_TSMHockeyGame_GameStatusId");

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimeChanged",
                table: "HockeyGame",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateTimePosted",
                table: "HockeyGame",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_TSMHockeyGame",
                table: "TSMHockeyGame",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSMHockeyGame_GameStatus_GameStatusId",
                table: "TSMHockeyGame",
                column: "GameStatusId",
                principalTable: "GameStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TSMHockeyGame_GameStatus_GameStatusId",
                table: "TSMHockeyGame");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TSMHockeyGame",
                table: "TSMHockeyGame");

            migrationBuilder.DropColumn(
                name: "DateTimeChanged",
                table: "HockeyGame");

            migrationBuilder.DropColumn(
                name: "DateTimePosted",
                table: "HockeyGame");

            migrationBuilder.RenameTable(
                name: "TSMHockeyGame",
                newName: "TSMHocekyGame");

            migrationBuilder.RenameIndex(
                name: "IX_TSMHockeyGame_GameStatusId",
                table: "TSMHocekyGame",
                newName: "IX_TSMHocekyGame_GameStatusId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TSMHocekyGame",
                table: "TSMHocekyGame",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TSMHocekyGame_GameStatus_GameStatusId",
                table: "TSMHocekyGame",
                column: "GameStatusId",
                principalTable: "GameStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
