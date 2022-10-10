using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPokeAPI.Migrations
{
    public partial class up1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fk_UserId",
                table: "MyPokemons");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fk_UserId",
                table: "MyPokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
