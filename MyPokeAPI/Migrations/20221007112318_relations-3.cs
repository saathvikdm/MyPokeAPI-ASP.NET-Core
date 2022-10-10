using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPokeAPI.Migrations
{
    public partial class relations3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyPokemons_Users_UserId",
                table: "MyPokemons");

            migrationBuilder.DropIndex(
                name: "IX_MyPokemons_UserId",
                table: "MyPokemons");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "MyPokemons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "MyPokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MyPokemons_UserId",
                table: "MyPokemons",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_MyPokemons_Users_UserId",
                table: "MyPokemons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
