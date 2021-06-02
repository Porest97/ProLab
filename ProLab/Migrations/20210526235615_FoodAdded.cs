using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class FoodAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           


            migrationBuilder.CreateTable(
                name: "FoodRatings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodRatingNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodRatingName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodRatingDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Foods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FoodDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EnergyKcal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EnergyKJ = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fibers = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Water = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Alcohol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Ash = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Monosaccharides = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Disaccharides = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sucrose = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WholeGrainsTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sugars = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalSaturatedFattyAcids = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FattyAcid40100 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LauricAcidC120 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MyristicAcidC140 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PalmiticAcidC160 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StearinAcid180 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArachidicAcidC200 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalMonounsaturatedFattyAcids = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PalmOleicAcidC161 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OleicAcidC181 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TotalPolyunsaturatedFattyAcids = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LinoleAcidC182 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LinolenicAcidC183 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ArachidonicAcidC204 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    EPAC205 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DPAC225 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DHAC226 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cholesterol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Retinol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BetaCarotene = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminD = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminE = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminK = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Thiamine = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Riboflavin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Niacin = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NiacinEquivalents = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminB6 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminB12 = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Folate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Phosphorus = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iodine = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iron = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Calcium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Potassium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Magnesium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sodium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salt = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Selenium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Zink = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WasteProcent = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Foods", x => x.Id);
                });
            migrationBuilder.CreateTable(
               name: "FoodsFoodRatings",
               columns: table => new
               {
                   FoodId = table.Column<int>(nullable: false),
                   FoodRatingId = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_FoodsRatings", x => new { x.FoodId, x.FoodRatingId });
                   table.ForeignKey(
                       name: "FK_FoodsFoodRatings_FoodRatings_FoodRatingsId",
                       column: x => x.FoodRatingId,
                       principalTable: "FoodRatings",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
                   table.ForeignKey(
                       name: "FK_FoodsFoodRatings_Foods_FoodId",
                       column: x => x.FoodId,
                       principalTable: "Foods",
                       principalColumn: "Id",
                       onDelete: ReferentialAction.Restrict);
               });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodRatings");

            migrationBuilder.DropTable(
                name: "Foods");

            migrationBuilder.DropTable(
                name: "FoodsFoodRatings");
        }
    }
}
