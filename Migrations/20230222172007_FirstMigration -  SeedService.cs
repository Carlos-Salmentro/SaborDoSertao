using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class FirstMigrationSeedService : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ComandasTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    MesaId = table.Column<int>(type: "int", nullable: true),
                    Identificador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abertura = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fechamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ValorTotal = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ComandasTable", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FinanceiroTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    IdentificacaoComanda = table.Column<int>(type: "int", nullable: false),
                    MesaId = table.Column<int>(type: "int", nullable: true),
                    Identificador = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Abertura = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    Fechamento = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ValorTotal = table.Column<double>(type: "double", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinanceiroTable", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Mesas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mesas", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Produtos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Nome = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Custo = table.Column<double>(type: "double", nullable: true),
                    Preco = table.Column<double>(type: "double", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Descricao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Tamanho = table.Column<int>(type: "int", nullable: true),
                    QuantServe = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Produtos", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Fechamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    FormaDePagamento = table.Column<int>(type: "int", nullable: false),
                    ValorPago = table.Column<double>(type: "double", nullable: false),
                    ComandaId = table.Column<int>(type: "int", nullable: true),
                    FinanceiroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fechamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fechamento_ComandasTable_ComandaId",
                        column: x => x.ComandaId,
                        principalTable: "ComandasTable",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Fechamento_FinanceiroTable_FinanceiroId",
                        column: x => x.FinanceiroId,
                        principalTable: "FinanceiroTable",
                        principalColumn: "Id");
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PedidosTable",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    ProdutoId = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Observacao = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Valor = table.Column<double>(type: "double", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    FinanceiroId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PedidosTable", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PedidosTable_FinanceiroTable_FinanceiroId",
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
                    { new Guid("01dd8a6b-fcb8-4e14-b798-2401d0403dfe"), 1, null, null, "Lua de Mel", 20.0, null, null },
                    { new Guid("06a195f3-cc33-41e1-b0b0-296ede9a5527"), 0, null, null, "Lampião", 125.0, 4, null },
                    { new Guid("09cc5a55-ef8d-4081-8810-f84cb42fa51a"), 3, null, null, "Batata Frita", 30.0, null, 2 },
                    { new Guid("0a5ba535-f0aa-4e49-b3d1-df1a0f66058d"), 2, null, null, "Feijao", 6.5, null, null },
                    { new Guid("0f0f08e7-5a85-4cd5-8437-733a1b1dd58e"), 0, null, null, "Feijoada", 50.0, null, 2 },
                    { new Guid("1c2320c4-b43c-491d-947e-2f22918c43fb"), 0, null, null, "Maria Bonita", 110.0, null, null },
                    { new Guid("24b62918-7d89-425b-932d-67582fafa1d2"), 3, null, null, "Mandioca Frita", 45.0, null, 3 },
                    { new Guid("29a7571d-44f8-4b8f-bc04-a36cca288ea4"), 2, null, null, "Ovo", 2.5, null, null },
                    { new Guid("2b870893-e160-43e8-8efc-bff18b84cb87"), 4, null, null, "Torta Holandesa", 15.0, null, null },
                    { new Guid("2c2d9348-0a8f-4bea-a75f-655fef5fd856"), 5, null, null, "Geleia de Mocoto", 7.0, null, null },
                    { new Guid("2ff469ff-524e-4836-920c-8d2cdfd038fe"), 1, null, null, "Caipirinha de Frutas com Pinga", 17.0, null, null },
                    { new Guid("397f3671-2598-4455-98d0-c779a0cb6685"), 3, null, null, "Mandioca Frita", 29.0, null, 1 },
                    { new Guid("3e32904b-3610-4944-bae2-41ec2bfd65ee"), 0, null, null, "Feijoada", 35.0, null, 1 },
                    { new Guid("40094a21-5d8f-4139-a561-50d196b50153"), 5, null, null, "Diversos", 1.0, null, null },
                    { new Guid("415abfaa-61d7-4429-8174-952515756b6d"), 3, null, null, "Mandioca Frita", 35.0, null, 2 },
                    { new Guid("5f64191c-52e7-4b7f-aa14-b20873e33413"), 1, null, null, "Caipirinha de Frutas com Vodka", 27.0, null, null },
                    { new Guid("6b0e06d9-cf2c-45d7-b5bb-143372f02dcd"), 1, null, null, "Caipirinha de Limao com Saque", 27.0, null, null },
                    { new Guid("73150b5c-b115-45a8-9184-c15eb51f5417"), 3, null, null, "Batata Frita", 40.0, null, 3 },
                    { new Guid("7581be68-f4ff-4476-8895-33ba17ceb269"), 0, null, null, "Feijoada", 70.0, null, 3 },
                    { new Guid("78de35f3-8ef7-4433-a605-a36d54187796"), 3, null, null, "Batata Frita", 25.0, null, 1 },
                    { new Guid("7d6d7b0f-3679-4941-9392-5440921ab7e5"), 3, null, null, "Mandioca Frita", 24.0, null, 0 },
                    { new Guid("811a9b27-855f-4b83-afb3-f5c3a43d602d"), 1, null, null, "Caipirinha de Frutas Vermelhas com Vodka", 29.0, null, null },
                    { new Guid("8336702e-64fc-485e-90a3-cfd1fdae5769"), 1, null, null, "Sex on The Beach", 20.0, null, null },
                    { new Guid("8c3be61d-fc28-4090-904d-e0d5dfc3d685"), 0, null, null, "Baiao de Dois", 40.0, null, 1 },
                    { new Guid("92f70f03-98d7-4ae9-8fb3-b36a47bbf96b"), 1, null, null, "Caipirinha de Limao com Pinga", 15.0, null, null },
                    { new Guid("a2f5e8b7-dcba-4d6d-9d9c-ed1b33516d31"), 2, null, null, "Arroz", 5.0, null, null },
                    { new Guid("a414ccf9-8dc5-4a1f-a1f6-2f2adcfa0eb2"), 4, null, null, "Sorvete", 10.0, null, null },
                    { new Guid("a5c8fc3e-74ba-471d-9b1d-192b645ac228"), 0, null, null, "Baiao de Dois", 50.0, null, 2 },
                    { new Guid("a74bb4eb-ee87-458d-a0c2-8519de580805"), 4, null, null, "Pettit Gateau", 18.5, null, null },
                    { new Guid("addb7d4b-e8d7-4eef-a854-f7780433f838"), 0, null, null, "Baiao de Dois", 30.0, null, 0 },
                    { new Guid("b7590c77-1728-47aa-8606-8bffd15d58e4"), 1, null, null, "Caipirinha de Frutas com Saque", 29.0, null, null },
                    { new Guid("c0c23055-6228-4310-98bc-44ac59e79b23"), 3, null, null, "Batata Frita", 20.0, null, 0 },
                    { new Guid("de0fe8e2-050e-4c3f-b619-9d214230462e"), 0, null, null, "Favada", 35.0, null, null },
                    { new Guid("e502ce22-85a6-4425-8629-15cf5e75a5e9"), 0, null, null, "Feijoada", 30.0, null, 0 },
                    { new Guid("f2aa1503-4a78-4bbe-b720-30db0908002b"), 5, null, null, "Favada Kg", 9.5, null, null },
                    { new Guid("f2c07f50-9394-4cae-a8bd-48f68460df66"), 1, null, null, "Caipirinha de Frutas Vermelhas com Pinga", 19.0, null, null },
                    { new Guid("f8087ca3-9c21-4141-ac1b-3eaffae0404a"), 1, null, null, "Caipirinha de Limao com Vodka", 25.0, null, null },
                    { new Guid("fa9d4ecf-6949-40b8-959a-8dbe751203ec"), 1, null, null, "Caipirinha de Frutas Vermelhas com Saque", 31.0, null, null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fechamento_ComandaId",
                table: "Fechamento",
                column: "ComandaId");

            migrationBuilder.CreateIndex(
                name: "IX_Fechamento_FinanceiroId",
                table: "Fechamento",
                column: "FinanceiroId");

            migrationBuilder.CreateIndex(
                name: "IX_PedidosTable_FinanceiroId",
                table: "PedidosTable",
                column: "FinanceiroId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fechamento");

            migrationBuilder.DropTable(
                name: "Mesas");

            migrationBuilder.DropTable(
                name: "PedidosTable");

            migrationBuilder.DropTable(
                name: "Produtos");

            migrationBuilder.DropTable(
                name: "ComandasTable");

            migrationBuilder.DropTable(
                name: "FinanceiroTable");
        }
    }
}
