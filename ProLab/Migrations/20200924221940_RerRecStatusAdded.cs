using Microsoft.EntityFrameworkCore.Migrations;

namespace ProLab.Migrations
{
    public partial class RerRecStatusAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RefRecStatusId",
                table: "RefReceipt",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "RefRecStatus",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RefRecStatusName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefRecStatus", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_RefReceipt_RefRecStatusId",
                table: "RefReceipt",
                column: "RefRecStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_RefReceipt_RefRecStatus_RefRecStatusId",
                table: "RefReceipt",
                column: "RefRecStatusId",
                principalTable: "RefRecStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RefReceipt_RefRecStatus_RefRecStatusId",
                table: "RefReceipt");

            migrationBuilder.DropTable(
                name: "RefRecStatus");

            migrationBuilder.DropIndex(
                name: "IX_RefReceipt_RefRecStatusId",
                table: "RefReceipt");

            migrationBuilder.DropColumn(
                name: "RefRecStatusId",
                table: "RefReceipt");
        }
    }
}
