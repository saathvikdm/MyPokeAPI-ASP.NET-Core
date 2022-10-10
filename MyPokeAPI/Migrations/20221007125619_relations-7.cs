using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyPokeAPI.Migrations
{
    public partial class relations7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Fk_UserId",
                table: "MyPokemons",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Fk_UserId",
                table: "MyPokemons");
        }
    }
}
