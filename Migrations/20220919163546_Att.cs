using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class Att : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorToral",
                table: "ComandasTable",
                newName: "ValorTotal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ValorTotal",
                table: "ComandasTable",
                newName: "ValorToral");
        }
    }
}
