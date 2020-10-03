using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class RefReieptAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RefReceipt",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HockeyGameId = table.Column<int>(nullable: true),
                    GameFeeHD1 = table.Column<decimal>(nullable: false),
                    AllowanceHD1 = table.Column<decimal>(nullable: false),
                    TravelExpensesHD1 = table.Column<decimal>(nullable: false),
                    LostErningsHD1 = table.Column<decimal>(nullable: false),
                    TravelSalarySupplementHD1 = table.Column<decimal>(nullable: false),
                    OtherHD1 = table.Column<decimal>(nullable: false),
                    DescriptionOthersDH1 = table.Column<string>(nullable: true),
                    TotalCostHD1 = table.Column<decimal>(nullable: false),
                    GameFeeHD2 = table.Column<decimal>(nullable: false),
                    AllowanceHD2 = table.Column<decimal>(nullable: false),
                    TravelExpensesHD2 = table.Column<decimal>(nullable: false),
                    LostErningsHD2 = table.Column<decimal>(nullable: false),
                    TravelSalarySupplementHD2 = table.Column<decimal>(nullable: false),
                    OtherHD2 = table.Column<decimal>(nullable: false),
                    DescriptionOthersDH2 = table.Column<string>(nullable: true),
                    TotalCostHD2 = table.Column<decimal>(nullable: false),
                    GameFeeLD1 = table.Column<decimal>(nullable: false),
                    AllowanceLD1 = table.Column<decimal>(nullable: false),
                    TravelExpensesLD1 = table.Column<decimal>(nullable: false),
                    LostErningsLD1 = table.Column<decimal>(nullable: false),
                    TravelSalarySupplementLD1 = table.Column<decimal>(nullable: false),
                    OtherLD1 = table.Column<decimal>(nullable: false),
                    DescriptionOthersLD1 = table.Column<string>(nullable: true),
                    TotalCostLD1 = table.Column<decimal>(nullable: false),
                    GameFeeLD2 = table.Column<decimal>(nullable: false),
                    AllowanceLD2 = table.Column<decimal>(nullable: false),
                    TravelExpensesLD2 = table.Column<decimal>(nullable: false),
                    LostErningsLD2 = table.Column<decimal>(nullable: false),
                    TravelSalarySupplementLD2 = table.Column<decimal>(nullable: false),
                    OtherLD2 = table.Column<decimal>(nullable: false),
                    DescriptionOthersLD2 = table.Column<string>(nullable: true),
                    TotalCostLD2 = table.Column<decimal>(nullable: false),
                    TotalCostHockeyGame = table.Column<decimal>(nullable: false),
                    TotalCostHalfHockeyGame = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefReceipt", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RefReceipt_HockeyGame_HockeyGameId",
                        column: x => x.HockeyGameId,
                        principalTable: "HockeyGame",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_HockeyGameId",
                table: "RefReceipt",
                column: "HockeyGameId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RefReceipt");
        }
    }
}
