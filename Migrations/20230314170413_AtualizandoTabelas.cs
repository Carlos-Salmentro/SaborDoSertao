using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class AtualizandoTabelas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("0d2dc50a-9a8a-400b-bbd5-73cb68a38007"), 5, null, null, "Favada Kg", 9.5, null, null },
                    { new Guid("0ff02e44-d36e-4e61-baf2-e46fd5f99734"), 1, null, null, "Caipirinha de Limao com Vodka", 25.0, null, null },
                    { new Guid("1d0dc275-7d4a-4cd4-9e1a-0273fa89392b"), 2, null, null, "Ovo", 2.5, null, null },
                    { new Guid("1d43099a-8c22-458c-aca8-527af6e8bc63"), 0, null, null, "Baiao de Dois", 50.0, null, 2 },
                    { new Guid("1d7276af-9429-4abc-9e43-102ca01927cf"), 2, null, null, "Feijao", 6.5, null, null },
                    { new Guid("1ec5f733-eb81-4135-bf0f-c045a633dee9"), 0, null, null, "Maria Bonita", 110.0, null, null },
                    { new Guid("2c47259f-4721-48e8-a5f4-4db4c82d69b3"), 1, null, null, "Lua de Mel", 20.0, null, null },
                    { new Guid("2deafc4d-5846-4453-a03d-d0de680783e0"), 0, null, null, "Baiao de Dois", 40.0, null, 1 },
                    { new Guid("3617c55d-90d8-435d-807d-b0259832127e"), 3, null, null, "Batata Frita", 40.0, null, 3 },
                    { new Guid("38ca23ff-f8e4-412f-a7f6-021bb89b46a8"), 1, null, null, "Caipirinha de Limao com Saque", 27.0, null, null },
                    { new Guid("38f3e4dc-6e19-49c2-9ce0-2fbb77725811"), 1, null, null, "Caipirinha de Frutas Vermelhas com Vodka", 29.0, null, null },
                    { new Guid("3a06b141-50e3-45d4-a5dd-1b6ef3b57229"), 1, null, null, "Sex on The Beach", 20.0, null, null },
                    { new Guid("4345b549-487d-40c5-912a-89ad9675ed7d"), 3, null, null, "Batata Frita", 30.0, null, 2 },
                    { new Guid("457bea7a-9624-43c3-9e8f-7b766db5e3e4"), 5, null, null, "Geleia de Mocoto", 7.0, null, null },
                    { new Guid("4713c7bb-feb4-464f-a24e-316ff5e43dbc"), 0, null, null, "Feijoada", 35.0, null, 1 },
                    { new Guid("4e44e3df-9334-4f1e-a5b4-a30485177d27"), 3, null, null, "Mandioca Frita", 24.0, null, 0 },
                    { new Guid("5932463e-c706-4e9b-b0d8-f60d4ada4b7a"), 4, null, null, "Pettit Gateau", 18.5, null, null },
                    { new Guid("5c6cb0f5-a390-44f4-bf95-ce768e0807a0"), 1, null, null, "Caipirinha de Frutas com Vodka", 27.0, null, null },
                    { new Guid("5e9ea480-a04f-444f-95cb-9437e5d83f1b"), 1, null, null, "Caipirinha de Frutas com Pinga", 17.0, null, null },
                    { new Guid("5f7cedf8-63c8-4980-a81f-df4a974b0c4e"), 0, null, null, "Baiao de Dois", 30.0, null, 0 },
                    { new Guid("702f4f6c-008f-40b8-95f2-b7bae85a6542"), 5, null, null, "Diversos", 1.0, null, null },
                    { new Guid("7a57e2af-4216-40b1-931c-58446835c11c"), 1, null, null, "Caipirinha de Frutas com Saque", 29.0, null, null },
                    { new Guid("8a755427-94c0-4ba6-92fa-2aaf645c394a"), 1, null, null, "Caipirinha de Frutas Vermelhas com Pinga", 19.0, null, null },
                    { new Guid("8f8a2eb3-ab79-4144-a149-67a21c9f85eb"), 0, null, null, "Favada", 35.0, null, null },
                    { new Guid("9099294d-6cd8-4572-9e83-2b3bd336128a"), 0, null, null, "Feijoada", 50.0, null, 2 },
                    { new Guid("9748df97-e0d1-4a04-bbea-3170c13694fe"), 1, null, null, "Caipirinha de Frutas Vermelhas com Saque", 31.0, null, null },
                    { new Guid("ac8a8041-3c7e-4ae3-920b-a8ec46541977"), 4, null, null, "Torta Holandesa", 15.0, null, null },
                    { new Guid("aceef5be-c148-4413-a477-b33ade8ba270"), 3, null, null, "Mandioca Frita", 35.0, null, 2 },
                    { new Guid("aed69bd7-9d46-4a1e-bad2-e669564f9e81"), 3, null, null, "Batata Frita", 20.0, null, 0 },
                    { new Guid("bcd91d53-8ae8-40eb-9a57-e3f15438b070"), 2, null, null, "Arroz", 5.0, null, null },
                    { new Guid("d4a01ee2-d480-4b1b-9167-56fd6bd54785"), 3, null, null, "Mandioca Frita", 45.0, null, 3 },
                    { new Guid("daa38710-ba49-46f1-9b88-64132f85c526"), 0, null, null, "Feijoada", 70.0, null, 3 },
                    { new Guid("df19d7cf-b6f3-44bb-97d3-f041a1ddb62e"), 1, null, null, "Caipirinha de Limao com Pinga", 15.0, null, null },
                    { new Guid("e17b0971-6237-4a07-b976-902ef08ae327"), 3, null, null, "Mandioca Frita", 29.0, null, 1 },
                    { new Guid("e6684166-0442-43a4-875a-b5e231d60353"), 4, null, null, "Sorvete", 10.0, null, null },
                    { new Guid("e79a4dce-0f25-4419-a361-f6c5353f574c"), 0, null, null, "Lampião", 125.0, 4, null },
                    { new Guid("f4e080be-3089-4821-b31b-3f13dff8ea93"), 3, null, null, "Batata Frita", 25.0, null, 1 },
                    { new Guid("fb2195c5-0bbb-4645-8281-e88ecb6d968c"), 0, null, null, "Feijoada", 30.0, null, 0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                keyValue: new Guid("0d2dc50a-9a8a-400b-bbd5-73cb68a38007"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("0ff02e44-d36e-4e61-baf2-e46fd5f99734"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1d0dc275-7d4a-4cd4-9e1a-0273fa89392b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1d43099a-8c22-458c-aca8-527af6e8bc63"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1d7276af-9429-4abc-9e43-102ca01927cf"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1ec5f733-eb81-4135-bf0f-c045a633dee9"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2c47259f-4721-48e8-a5f4-4db4c82d69b3"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2deafc4d-5846-4453-a03d-d0de680783e0"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3617c55d-90d8-435d-807d-b0259832127e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("38ca23ff-f8e4-412f-a7f6-021bb89b46a8"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("38f3e4dc-6e19-49c2-9ce0-2fbb77725811"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3a06b141-50e3-45d4-a5dd-1b6ef3b57229"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("4345b549-487d-40c5-912a-89ad9675ed7d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("457bea7a-9624-43c3-9e8f-7b766db5e3e4"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("4713c7bb-feb4-464f-a24e-316ff5e43dbc"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("4e44e3df-9334-4f1e-a5b4-a30485177d27"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5932463e-c706-4e9b-b0d8-f60d4ada4b7a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5c6cb0f5-a390-44f4-bf95-ce768e0807a0"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5e9ea480-a04f-444f-95cb-9437e5d83f1b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5f7cedf8-63c8-4980-a81f-df4a974b0c4e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("702f4f6c-008f-40b8-95f2-b7bae85a6542"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("7a57e2af-4216-40b1-931c-58446835c11c"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8a755427-94c0-4ba6-92fa-2aaf645c394a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8f8a2eb3-ab79-4144-a149-67a21c9f85eb"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9099294d-6cd8-4572-9e83-2b3bd336128a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9748df97-e0d1-4a04-bbea-3170c13694fe"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ac8a8041-3c7e-4ae3-920b-a8ec46541977"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aceef5be-c148-4413-a477-b33ade8ba270"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("aed69bd7-9d46-4a1e-bad2-e669564f9e81"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("bcd91d53-8ae8-40eb-9a57-e3f15438b070"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("d4a01ee2-d480-4b1b-9167-56fd6bd54785"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("daa38710-ba49-46f1-9b88-64132f85c526"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("df19d7cf-b6f3-44bb-97d3-f041a1ddb62e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e17b0971-6237-4a07-b976-902ef08ae327"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e6684166-0442-43a4-875a-b5e231d60353"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e79a4dce-0f25-4419-a361-f6c5353f574c"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f4e080be-3089-4821-b31b-3f13dff8ea93"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("fb2195c5-0bbb-4645-8281-e88ecb6d968c"));
        }
    }
}
