using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class AddPagamentosTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PedidosTable_FinanceiroTable_FinanceiroId",
                table: "PedidosTable");

            migrationBuilder.DropTable(
                name: "Fechamento");

            migrationBuilder.DropIndex(
                name: "IX_PedidosTable_FinanceiroId",
                table: "PedidosTable");

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Mesas",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("03621d8b-b5a4-4983-9a79-8cb1041085fc"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("0eb61b60-f9e4-495d-9457-36b5387d9253"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("147d4bb8-f505-4c0a-a8f5-187ff516b05a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2cb9f185-5797-4f6f-992b-1564d6186e9b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("38534e75-0a08-40cc-bd68-816dfb22888a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3a5fe4c7-c8c4-4da0-920b-b594ad08f453"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("42e67c72-083a-4c38-a3a9-f851d12fa263"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("49faf6b4-f31d-4bae-b681-6d11aee22c89"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5686857c-bee8-41d1-a1a5-9297f5f22e2a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("56afe346-7801-47b1-a8a6-5c18a64c41f0"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("72316005-140a-4dd1-befe-bf9c4581540d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8dcf63b5-9c59-4ecd-969b-a337f4b73e6d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9196a514-c553-425f-8c0f-ab6c4838946e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("927ae63a-43bf-4e87-9593-ab5cb7dc7d13"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9c04ae0c-789c-4901-9174-3fe388ea58da"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9ff9ac93-6de0-4f12-b9e8-5594d9261090"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aa518629-e66b-4bfa-9908-423782a5cb14"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b156b6be-4da8-40c6-a277-292bb6f60ca0"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b58bfc43-4472-4d5f-8fc7-ad45bc763d7b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b8364c7b-d131-45a1-8988-d92f0c0ba170"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b9578df5-3269-4d10-bc9e-7e05375e346b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b9eacdb9-fbd3-470c-bafb-86fcdeff1ebb"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c62a5514-2e13-4246-bb08-c1b789bbab2a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c9f108b6-d28c-4c25-9e90-69ed13bbf3b3"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("cbaf0d96-8d78-42ae-a3bf-678d90eaef96"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("d2022fec-e04a-47e5-b073-1c484eb017d1"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("d8a2fe6c-51fc-4195-ae3f-dba8b46a93b0"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("df9b5a91-2967-46aa-94b7-971f703e326d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e122fdb4-3b29-45de-89a1-e377f9f585a9"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e3d96dda-6748-4b55-b97b-526ab6b26206"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ec0bf86a-8a48-40a7-af36-4f6bb0acc485"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("eca1cf50-34b0-48f5-b4f4-088ff3e239c8"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ee564693-442e-4595-bcdd-5651d37dd08e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("eea8ea96-8b04-4a8b-adf7-6644948a2104"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f6d38594-c07b-4c17-9fa3-bd176945bee8"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f7f182c0-b08a-43fe-ad8b-1055a70e4f5f"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f8abc241-e2c3-45ef-8f2e-076d810e8e57"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("fdc01406-2b75-46fb-9f8b-d495154f2294"));

            migrationBuilder.DropColumn(
                name: "FinanceiroId",
                table: "PedidosTable");

            migrationBuilder.RenameColumn(
                name: "IdentificacaoComanda",
                table: "FinanceiroTable",
                newName: "FechamentoId");

            migrationBuilder.AddColumn<int>(
                name: "ComandaId",
                table: "FinanceiroTable",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PagamentosTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ComandaId = table.Column<int>(type: "int", nullable: false),
                    FormaDePagamento = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PagamentosTable", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PagamentosTable");

            migrationBuilder.DropColumn(
                name: "ComandaId",
                table: "FinanceiroTable");

            migrationBuilder.RenameColumn(
                name: "FechamentoId",
                table: "FinanceiroTable",
                newName: "IdentificacaoComanda");

            migrationBuilder.AddColumn<int>(
                name: "FinanceiroId",
                table: "PedidosTable",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Fechamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FinanceiroId = table.Column<int>(type: "int", nullable: true),
                    FormaDePagamento = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fechamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fechamento_FinanceiroTable_FinanceiroId",
                        column: x => x.FinanceiroId,
                        principalTable: "FinanceiroTable",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Mesas",
                columns: new[] { "Id", "Status" },
                values: new object[,]
                {
                    { 1, 0 },
                    { 2, 0 },
                    { 3, 0 },
                    { 4, 0 },
                    { 5, 0 },
                    { 6, 0 },
                    { 7, 0 },
                    { 8, 0 },
                    { 9, 0 },
                    { 10, 0 }
                });

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Categoria", "Custo", "Descricao", "Nome", "Preco", "QuantServe", "Tamanho" },
                values: new object[,]
                {
                    { new Guid("03621d8b-b5a4-4983-9a79-8cb1041085fc"), 4, null, null, "Torta Holandesa", 15.0, null, null },
                    { new Guid("0eb61b60-f9e4-495d-9457-36b5387d9253"), 3, null, null, "Batata Frita", 20.0, null, 0 },
                    { new Guid("147d4bb8-f505-4c0a-a8f5-187ff516b05a"), 0, null, null, "Lampião", 125.0, 4, null },
                    { new Guid("2cb9f185-5797-4f6f-992b-1564d6186e9b"), 1, null, null, "Caipirinha de Frutas Vermelhas com Saque", 31.0, null, null },
                    { new Guid("38534e75-0a08-40cc-bd68-816dfb22888a"), 1, null, null, "Lua de Mel", 20.0, null, null },
                    { new Guid("3a5fe4c7-c8c4-4da0-920b-b594ad08f453"), 5, null, null, "Geleia de Mocoto", 7.0, null, null },
                    { new Guid("42e67c72-083a-4c38-a3a9-f851d12fa263"), 1, null, null, "Caipirinha de Frutas Vermelhas com Vodka", 29.0, null, null },
                    { new Guid("49faf6b4-f31d-4bae-b681-6d11aee22c89"), 3, null, null, "Mandioca Frita", 29.0, null, 1 },
                    { new Guid("5686857c-bee8-41d1-a1a5-9297f5f22e2a"), 1, null, null, "Caipirinha de Frutas com Saque", 29.0, null, null },
                    { new Guid("56afe346-7801-47b1-a8a6-5c18a64c41f0"), 5, null, null, "Favada Kg", 9.5, null, null },
                    { new Guid("72316005-140a-4dd1-befe-bf9c4581540d"), 0, null, null, "Feijoada", 70.0, null, 3 },
                    { new Guid("8dcf63b5-9c59-4ecd-969b-a337f4b73e6d"), 0, null, null, "Baiao de Dois", 30.0, null, 0 },
                    { new Guid("9196a514-c553-425f-8c0f-ab6c4838946e"), 3, null, null, "Mandioca Frita", 24.0, null, 0 },
                    { new Guid("927ae63a-43bf-4e87-9593-ab5cb7dc7d13"), 1, null, null, "Sex on The Beach", 20.0, null, null },
                    { new Guid("9c04ae0c-789c-4901-9174-3fe388ea58da"), 5, null, null, "Diversos", 1.0, null, null },
                    { new Guid("9ff9ac93-6de0-4f12-b9e8-5594d9261090"), 1, null, null, "Caipirinha de Limao com Pinga", 15.0, null, null },
                    { new Guid("aa518629-e66b-4bfa-9908-423782a5cb14"), 3, null, null, "Mandioca Frita", 35.0, null, 2 },
                    { new Guid("b156b6be-4da8-40c6-a277-292bb6f60ca0"), 1, null, null, "Caipirinha de Limao com Saque", 27.0, null, null },
                    { new Guid("b58bfc43-4472-4d5f-8fc7-ad45bc763d7b"), 0, null, null, "Baiao de Dois", 40.0, null, 1 },
                    { new Guid("b8364c7b-d131-45a1-8988-d92f0c0ba170"), 0, null, null, "Feijoada", 35.0, null, 1 },
                    { new Guid("b9578df5-3269-4d10-bc9e-7e05375e346b"), 0, null, null, "Baiao de Dois", 50.0, null, 2 },
                    { new Guid("b9eacdb9-fbd3-470c-bafb-86fcdeff1ebb"), 4, null, null, "Pettit Gateau", 18.5, null, null },
                    { new Guid("c62a5514-2e13-4246-bb08-c1b789bbab2a"), 1, null, null, "Caipirinha de Frutas com Pinga", 17.0, null, null },
                    { new Guid("c9f108b6-d28c-4c25-9e90-69ed13bbf3b3"), 3, null, null, "Batata Frita", 30.0, null, 2 },
                    { new Guid("cbaf0d96-8d78-42ae-a3bf-678d90eaef96"), 2, null, null, "Arroz", 5.0, null, null },
                    { new Guid("d2022fec-e04a-47e5-b073-1c484eb017d1"), 1, null, null, "Caipirinha de Frutas Vermelhas com Pinga", 19.0, null, null },
                    { new Guid("d8a2fe6c-51fc-4195-ae3f-dba8b46a93b0"), 0, null, null, "Feijoada", 30.0, null, 0 },
                    { new Guid("df9b5a91-2967-46aa-94b7-971f703e326d"), 1, null, null, "Caipirinha de Limao com Vodka", 25.0, null, null },
                    { new Guid("e122fdb4-3b29-45de-89a1-e377f9f585a9"), 2, null, null, "Feijao", 6.5, null, null },
                    { new Guid("e3d96dda-6748-4b55-b97b-526ab6b26206"), 1, null, null, "Caipirinha de Frutas com Vodka", 27.0, null, null },
                    { new Guid("ec0bf86a-8a48-40a7-af36-4f6bb0acc485"), 4, null, null, "Sorvete", 10.0, null, null },
                    { new Guid("eca1cf50-34b0-48f5-b4f4-088ff3e239c8"), 0, null, null, "Maria Bonita", 110.0, null, null },
                    { new Guid("ee564693-442e-4595-bcdd-5651d37dd08e"), 2, null, null, "Ovo", 2.5, null, null },
                    { new Guid("eea8ea96-8b04-4a8b-adf7-6644948a2104"), 0, null, null, "Favada", 35.0, null, null },
                    { new Guid("f6d38594-c07b-4c17-9fa3-bd176945bee8"), 3, null, null, "Batata Frita", 25.0, null, 1 },
                    { new Guid("f7f182c0-b08a-43fe-ad8b-1055a70e4f5f"), 3, null, null, "Batata Frita", 40.0, null, 3 },
                    { new Guid("f8abc241-e2c3-45ef-8f2e-076d810e8e57"), 3, null, null, "Mandioca Frita", 45.0, null, 3 },
                    { new Guid("fdc01406-2b75-46fb-9f8b-d495154f2294"), 0, null, null, "Feijoada", 50.0, null, 2 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PedidosTable_FinanceiroId",
                table: "PedidosTable",
                column: "FinanceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_Fechamento_FinanceiroId",
                table: "Fechamento",
                column: "FinanceiroId");

            migrationBuilder.AddForeignKey(
                name: "FK_PedidosTable_FinanceiroTable_FinanceiroId",
                table: "PedidosTable",
                column: "FinanceiroId",
                principalTable: "FinanceiroTable",
                principalColumn: "Id");
        }
    }
}
