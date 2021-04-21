using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class CSPaymentsAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CSPStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CSPStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CSPStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CleverServicePayments",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GameDate = table.Column<DateTime>(nullable: true),
                    PaymentDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ClubId = table.Column<int>(nullable: true),
                    PaymentBeforeTax = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    Payment = table.Column<decimal>(nullable: false),
                    CSPStatusId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CleverServicePayments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CleverServicePayments_CSPStatus_CSPStatusId",
                        column: x => x.CSPStatusId,
                        principalTable: "CSPStatus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CleverServicePayments_Club_ClubId",
                        column: x => x.ClubId,
                        principalTable: "Club",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CleverServicePayments_CSPStatusId",
                table: "CleverServicePayments",
                column: "CSPStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_CleverServicePayments_ClubId",
                table: "CleverServicePayments",
                column: "ClubId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CleverServicePayments");

            migrationBuilder.DropTable(
                name: "CSPStatus");
        }
    }
}
