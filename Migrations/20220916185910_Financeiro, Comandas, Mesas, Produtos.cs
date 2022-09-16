using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class FinanceiroComandasMesasProdutos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mesas_Comandas_ComandaId",
                table: "Mesas");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Comandas_ComandaId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Mesas_ComandaId",
                table: "Mesas");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Comandas",
                table: "Comandas");

            migrationBuilder.DropColumn(
                name: "ComandaId",
                table: "Mesas");

            migrationBuilder.DropColumn(
                name: "Valor",
                table: "Mesas");

            migrationBuilder.RenameTable(
                name: "Comandas",
                newName: "ComandasTable");

            migrationBuilder.AddColumn<string>(
                name: "Identificador",
                table: "ComandasTable",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MesaId",
                table: "ComandasTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ValorToral",
                table: "ComandasTable",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ComandasTable",
                table: "ComandasTable",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Fechamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormaDePagamento = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<double>(type: "double", nullable: false),
                    ComandaId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fechamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fechamento_ComandasTable_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "ComandasTable",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateIndex(
                name: "IX_Fechamento_ComandaId",
                table: "Fechamento",
                column: "ComandaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_ComandasTable_ComandaId",
                table: "Pedidos",
                column: "ComandaId",
                principalTable: "ComandasTable",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_ComandasTable_ComandaId",
                table: "Pedidos");

            migrationBuilder.DropTable(
                name: "Fechamento");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ComandasTable",
                table: "ComandasTable");

            migrationBuilder.DropColumn(
                name: "Identificador",
                table: "ComandasTable");

            migrationBuilder.DropColumn(
                name: "MesaId",
                table: "ComandasTable");

            migrationBuilder.DropColumn(
                name: "ValorToral",
                table: "ComandasTable");

            migrationBuilder.RenameTable(
                name: "ComandasTable",
                newName: "Comandas");

            migrationBuilder.AddColumn<int>(
                name: "ComandaId",
                table: "Mesas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "Valor",
                table: "Mesas",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Comandas",
                table: "Comandas",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Mesas_ComandaId",
                table: "Mesas",
                column: "ComandaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Mesas_Comandas_ComandaId",
                table: "Mesas",
                column: "ComandaId",
                principalTable: "Comandas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Comandas_ComandaId",
                table: "Pedidos",
                column: "ComandaId",
                principalTable: "Comandas",
                principalColumn: "Id");
        }
    }
}
