using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPokeAPI.Migrations
{
    public partial class relations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "MyPokemons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyPokemons",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Url",
                table: "MyPokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MyPokemons",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
