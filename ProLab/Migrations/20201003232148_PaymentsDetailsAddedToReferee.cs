using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class PaymentsDetailsAddedToReferee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BankAccount",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "Referee",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SwishNumber",
                table: "Referee",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BankAccount",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "Referee");

            migrationBuilder.DropColumn(
                name: "SwishNumber",
                table: "Referee");
        }
    }
}
