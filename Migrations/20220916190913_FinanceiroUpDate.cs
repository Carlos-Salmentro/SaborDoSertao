using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class FinanceiroUpDate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FinanceiroInfo",
                table: "FinanceiroInfo");

            migrationBuilder.RenameTable(
                name: "FinanceiroInfo",
                newName: "FinanceiroTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinanceiroTable",
                table: "FinanceiroTable",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FinanceiroTable",
                table: "FinanceiroTable");

            migrationBuilder.RenameTable(
                name: "FinanceiroTable",
                newName: "FinanceiroInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinanceiroInfo",
                table: "FinanceiroInfo",
                column: "Id");
        }
    }
}
