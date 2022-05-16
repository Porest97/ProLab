using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class HockeyGameId7AddedInCupKvitto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "HockeyGameId7",
                table: "CupKvitto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId7",
                table: "CupKvitto",
                column: "HockeyGameId7");

            migrationBuilder.AddForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId7",
                table: "CupKvitto",
                column: "HockeyGameId7",
                principalTable: "HockeyGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId7",
                table: "CupKvitto");

            migrationBuilder.DropIndex(
                name: "IX_CupKvitto_HockeyGameId7",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "HockeyGameId7",
                table: "CupKvitto");
        }
    }
}
