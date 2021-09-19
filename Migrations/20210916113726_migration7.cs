using Microsoft.EntityFrameworkCore.Migrations;

namespace gotcha_web.Migrations
{
    public partial class migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "Contracts",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Contracts_GameId",
                table: "Contracts",
                column: "GameId");

            migrationBuilder.AddForeignKey(
                name: "FK_Contracts_Games_GameId",
                table: "Contracts",
                column: "GameId",
                principalTable: "Games",
                principalColumn: "GameId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contracts_Games_GameId",
                table: "Contracts");

            migrationBuilder.DropIndex(
                name: "IX_Contracts_GameId",
                table: "Contracts");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "Contracts");
        }
    }
}
