using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPokeAPI.Migrations
{
    public partial class up5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyPokemons_Users_UserId",
                table: "MyPokemons");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MyPokemons",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MyPokemons_Users_UserId",
                table: "MyPokemons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MyPokemons_Users_UserId",
                table: "MyPokemons");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "MyPokemons",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_MyPokemons_Users_UserId",
                table: "MyPokemons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId");
        }
    }
}
