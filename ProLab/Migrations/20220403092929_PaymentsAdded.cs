using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProLab.Migrations
{
    public partial class PaymentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Allowance",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "CupKvitto",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee1",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee10",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee2",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee3",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee4",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee5",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee6",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee7",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee8",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "GameFee9",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "Km",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LateGameStart",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "LostErnings",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalCost",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TravelExpenses",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TravelSalarySupplement",
                table: "CupKvitto",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Allowance",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee1",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee10",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee2",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee3",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee4",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee5",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee6",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee7",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee8",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "GameFee9",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "Km",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "LateGameStart",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "LostErnings",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "TotalCost",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "TravelExpenses",
                table: "CupKvitto");

            migrationBuilder.DropColumn(
                name: "TravelSalarySupplement",
                table: "CupKvitto");
        }
    }
}
