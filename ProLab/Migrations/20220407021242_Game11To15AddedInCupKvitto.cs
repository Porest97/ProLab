using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class Game11To15AddedInCupKvitto : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GameFee11",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee12",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee13",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee14",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee15",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "HockeyGameId10",
                table: "CupKvitto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HockeyGameId11",
                table: "CupKvitto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HockeyGameId12",
                table: "CupKvitto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HockeyGameId13",
                table: "CupKvitto",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "HockeyGameId14",
                table: "CupKvitto",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId10",
                table: "CupKvitto",
                column: "HockeyGameId10");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId11",
                table: "CupKvitto",
                column: "HockeyGameId11");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId12",
                table: "CupKvitto",
                column: "HockeyGameId12");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId13",
                table: "CupKvitto",
                column: "HockeyGameId13");

            migrationBuilder.CreateIndex(
                name: "IX_CupKvitto_HockeyGameId14",
                table: "CupKvitto",
                column: "HockeyGameId14");

            migrationBuilder.AddForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId10",
                table: "CupKvitto",
                column: "HockeyGameId10",
                principalTable: "HockeyGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId11",
                table: "CupKvitto",
                column: "HockeyGameId11",
                principalTable: "HockeyGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId12",
                table: "CupKvitto",
                column: "HockeyGameId12",
                principalTable: "HockeyGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId13",
                table: "CupKvitto",
                column: "HockeyGameId13",
                principalTable: "HockeyGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId14",
                table: "CupKvitto",
                column: "HockeyGameId14",
                principalTable: "HockeyGame",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId10",
                table: "CupKvitto");

            migrationBuilder.DropForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId11",
                table: "CupKvitto");

            migrationBuilder.DropForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId12",
                table: "CupKvitto");

            migrationBuilder.DropForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId13",
                table: "CupKvitto");

            migrationBuilder.DropForeignKey(
                name: "FK_CupKvitto_HockeyGame_HockeyGameId14",
                table: "CupKvitto");

            migrationBuilder.DropIndex(
                name: "IX_CupKvitto_HockeyGameId10",
                table: "CupKvitto");

            migrationBuilder.DropIndex(
                name: "IX_CupKvitto_HockeyGameId11",
                table: "CupKvitto");

            migrationBuilder.DropIndex(
                name: "IX_CupKvitto_HockeyGameId12",
                table: "CupKvitto");

            migrationBuilder.DropIndex(
                name: "IX_CupKvitto_HockeyGameId13",
                table: "CupKvitto");

            migrationBuilder.DropIndex(
                name: "IX_CupKvitto_HockeyGameId14",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee11",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee12",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee13",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee14",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee15",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "HockeyGameId10",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "HockeyGameId11",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "HockeyGameId12",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "HockeyGameId13",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "HockeyGameId14",
                table: "CupKvitto");
        }
    }
}
