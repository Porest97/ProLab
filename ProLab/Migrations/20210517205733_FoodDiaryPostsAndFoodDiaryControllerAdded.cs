using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class FoodDiaryPostsAndFoodDiaryControllerAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FoodDiaryPosts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateTimePosted = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateTimeChanged = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ApplicationUserId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Meal = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Calories = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    SaturatedFat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PolyunsaturatedFat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MonounsaturatedFat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransFat = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Cholesterol = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sodium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Potassium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Carbohydrates = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Fibers = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Sugar = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Protein = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminA = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    VitaminC = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Calcium = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Iron = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDiaryPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FoodDiaryPosts_AspNetUsers_ApplicationUserId",
                        column: x => x.ApplicationUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodDiaryPosts_ApplicationUserId",
                table: "FoodDiaryPosts",
                column: "ApplicationUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodDiaryPosts");
        }
    }
}
