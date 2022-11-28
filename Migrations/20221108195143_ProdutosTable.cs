using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class ProdutosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FinanceiroId",
                table: "Pedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Abertura",
                table: "FinanceiroTable",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Fechamento",
                table: "FinanceiroTable",
                type: "datetime(6)",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "IdentificacaoComanda",
                table: "FinanceiroTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Identificador",
                table: "FinanceiroTable",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<int>(
                name: "MesaId",
                table: "FinanceiroTable",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "ValorTotal",
                table: "FinanceiroTable",
                type: "double",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<int>(
                name: "FinanceiroId",
                table: "Fechamento",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_FinanceiroId",
                table: "Pedidos",
                column: "FinanceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Fechamento_FinanceiroId",
                table: "Fechamento",
                column: "FinanceiroId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fechamento_FinanceiroTable_FinanceiroId",
                table: "Fechamento",
                column: "FinanceiroId",
                principalTable: "FinanceiroTable",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_FinanceiroTable_FinanceiroId",
                table: "Pedidos",
                column: "FinanceiroId",
                principalTable: "FinanceiroTable",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fechamento_FinanceiroTable_FinanceiroId",
                table: "Fechamento");

            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_FinanceiroTable_FinanceiroId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_FinanceiroId",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Fechamento_FinanceiroId",
                table: "Fechamento");

            migrationBuilder.DropColumn(
                name: "FinanceiroId",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Abertura",
                table: "FinanceiroTable");

            migrationBuilder.DropColumn(
                name: "Fechamento",
                table: "FinanceiroTable");

            migrationBuilder.DropColumn(
                name: "IdentificacaoComanda",
                table: "FinanceiroTable");

            migrationBuilder.DropColumn(
                name: "Identificador",
                table: "FinanceiroTable");

            migrationBuilder.DropColumn(
                name: "MesaId",
                table: "FinanceiroTable");

            migrationBuilder.DropColumn(
                name: "ValorTotal",
                table: "FinanceiroTable");

            migrationBuilder.DropColumn(
                name: "FinanceiroId",
                table: "Fechamento");
        }
    }
}
