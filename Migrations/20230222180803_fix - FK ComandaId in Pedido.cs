using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SaborDoSertão.Migrations
{
    public partial class fixFKComandaIdinPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fechamento_ComandasTable_ComandaId",
                table: "Fechamento");

            migrationBuilder.DropIndex(
                name: "IX_Fechamento_ComandaId",
                table: "Fechamento");

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("088f77a2-6389-4ca0-944c-8d69a18eeeec"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("0e17dc9f-cf32-465e-9e5f-fa462ccff85d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("122b33c7-dddc-44bb-9265-1fe6c57327b7"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("136e23dc-64a9-4070-9739-3bc373fef485"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("15d1b16b-f8ed-4b67-9548-3f3f99d5a3e7"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1a113b60-2d25-4e00-bfa8-3220a7476155"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1c96ce4c-d1db-42b7-a076-b2363db0b141"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1ec8a47d-fe96-476a-b2ab-ea64001abdd1"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("24772e99-09eb-49a9-95b1-82fb51970f0e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2c9e4152-b092-49cd-803b-9c88fb0ee38a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("30376d1e-910d-40ac-873a-ad1f1d4aec40"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3c463bb1-9470-4f9b-8a6e-fb2ceb670887"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("56276feb-ef58-4192-bdb6-972ebf553761"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5af5c72f-3742-43c6-8670-123b4cb969ba"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("5ba4855b-e314-4648-ad8d-d01c7b75c0dc"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("6b0e6e3d-c36a-49cd-9fac-f57e63887ca8"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("78880618-c46a-419d-b5cb-c09daf649ef3"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("791d95b0-3994-483d-83d2-e67fe48fad48"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("7982558a-ed24-437a-b5b0-f5b2e78e38e7"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8036f6fe-cab2-4bb8-8439-16b8ff2318ed"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("80569ece-a75f-4216-b2f1-b6ad79c3a9fc"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("890820c5-be45-4f5d-a38b-6eaf6bcb7323"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8c053f63-5183-4e98-af92-b01a9795a7ff"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8cbd00a9-1bfa-469e-9425-7c7f4bb7c511"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("91f55991-05be-421b-936c-ce1e5d906a88"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("9f9f0490-6f09-4a8e-9897-38d24511ca3e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a0d24976-bee4-4353-898d-ddf3b5ed926b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a1b0ec73-37da-42a8-985a-7877786fa4fe"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a22524c6-d8af-49bc-9ad2-87aa9bebe03c"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a9cc489c-a8e4-43b4-971a-0ad44efa83e6"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c2b97eb1-2e1e-4211-bd14-b5a4ee33f135"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ce009b7f-2607-43b2-b563-7f64c6c96bb8"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("d7469c7e-b2e8-4578-9e8f-ab1b29652b3f"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("ee4b3497-1a6f-4a71-bd69-6b9b57c859c3"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f2a3a4c9-0539-454b-8ff0-cf8ef60f3795"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f3ba4178-423f-4929-9796-08670ef4d63f"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f3e8dedf-b347-4bd6-ae34-eb0e2bbec93a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("fc752508-a9d8-4ff7-ab00-d5fca3555ac4"));

            migrationBuilder.DropColumn(
                name: "ComandaId",
                table: "Fechamento");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Categoria", "Custo", "Descricao", "Nome", "Preco", "QuantServe", "Tamanho" },
                values: new object[,]
                {
                    { new Guid("002cbf2d-899d-44f5-a504-e02c5dba63b1"), 5, null, null, "Geleia de Mocoto", 7.0, null, null },
                    { new Guid("00a4a693-41ce-427a-8f14-e9ab9c62d5df"), 0, null, null, "Feijoada", 50.0, null, 2 },
                    { new Guid("038211c8-2e81-4f0b-b38c-a40c09fe83d5"), 3, null, null, "Mandioca Frita", 35.0, null, 2 },
                    { new Guid("1dc661e0-e5b2-441c-b3a1-fdcecdd8c553"), 3, null, null, "Mandioca Frita", 45.0, null, 3 },
                    { new Guid("1ef8c8f2-a6ee-4b56-a30e-68ba50cec93f"), 1, null, null, "Caipirinha de Frutas Vermelhas com Pinga", 19.0, null, null },
                    { new Guid("2bef545b-28fc-41bb-bf90-2dbaa3760eaf"), 3, null, null, "Batata Frita", 30.0, null, 2 },
                    { new Guid("2dd2e6fb-b464-4ae3-a31e-22fec131e813"), 2, null, null, "Arroz", 5.0, null, null },
                    { new Guid("3ba2953c-a792-4783-9bdb-ef0d04875a40"), 0, null, null, "Baiao de Dois", 30.0, null, 0 },
                    { new Guid("3e1549b0-69f8-40fc-a4f5-304334a3aceb"), 1, null, null, "Caipirinha de Frutas com Pinga", 17.0, null, null },
                    { new Guid("41c6b6cc-6b55-43c4-a8f1-f3bf2b4dec8e"), 3, null, null, "Mandioca Frita", 29.0, null, 1 },
                    { new Guid("45fdbf63-caad-40bd-8d67-3ec916d6b3f6"), 5, null, null, "Diversos", 1.0, null, null },
                    { new Guid("48f03ee9-ad52-47c9-a272-c74316d80f0b"), 0, null, null, "Feijoada", 30.0, null, 0 },
                    { new Guid("510a9109-e23c-493f-a527-1afbb166a3d5"), 0, null, null, "Favada", 35.0, null, null },
                    { new Guid("547ddf8c-12f6-49da-b84c-43b6bb233160"), 3, null, null, "Batata Frita", 40.0, null, 3 },
                    { new Guid("571f6987-b3a6-4b36-a446-940bdabacb32"), 1, null, null, "Sex on The Beach", 20.0, null, null },
                    { new Guid("6bf70546-5c2c-49e5-8d85-0651b0f775e3"), 3, null, null, "Batata Frita", 25.0, null, 1 },
                    { new Guid("6c96151b-1236-4538-8f84-1afd7a52b93f"), 1, null, null, "Lua de Mel", 20.0, null, null },
                    { new Guid("722e6634-58fc-4181-9219-f5605486d692"), 1, null, null, "Caipirinha de Limao com Vodka", 25.0, null, null },
                    { new Guid("8946f1f3-e517-43cb-aa19-6ad7415666c3"), 0, null, null, "Feijoada", 70.0, null, 3 },
                    { new Guid("89db4161-e8b7-4c46-b478-2cb60e06e041"), 4, null, null, "Sorvete", 10.0, null, null },
                    { new Guid("8aaf4314-a79f-4009-be67-659485197760"), 0, null, null, "Feijoada", 35.0, null, 1 },
                    { new Guid("a100feac-88aa-4f72-8b87-61666c7ccfcf"), 1, null, null, "Caipirinha de Limao com Pinga", 15.0, null, null },
                    { new Guid("a3d95543-0b33-4222-b48f-5c32482bf317"), 4, null, null, "Torta Holandesa", 15.0, null, null },
                    { new Guid("a565e588-c4b0-4ec1-8703-fccbe748419d"), 0, null, null, "Baiao de Dois", 50.0, null, 2 },
                    { new Guid("a69bbccb-3eb3-4d3e-b2c3-0b333922da76"), 1, null, null, "Caipirinha de Frutas com Saque", 29.0, null, null },
                    { new Guid("b6a58019-18f7-4f7b-9ee3-69f5b0c09aff"), 0, null, null, "Maria Bonita", 110.0, null, null },
                    { new Guid("b89f2660-3df7-4107-81d2-bd25f3e2eb48"), 3, null, null, "Batata Frita", 20.0, null, 0 },
                    { new Guid("b8dbfea7-23bb-4e7e-9b7d-d103132ee81b"), 1, null, null, "Caipirinha de Frutas Vermelhas com Saque", 31.0, null, null },
                    { new Guid("bcecf4d9-ff3c-47b2-bd95-bcd497f6c82e"), 2, null, null, "Ovo", 2.5, null, null },
                    { new Guid("c26cc939-72a0-4d24-8e6f-00add63e077b"), 5, null, null, "Favada Kg", 9.5, null, null },
                    { new Guid("c4e9dc18-73f4-4f1e-9ba2-acf05b9fc3a6"), 4, null, null, "Pettit Gateau", 18.5, null, null },
                    { new Guid("c82fd35e-3924-4ada-8285-bce1a9915f36"), 0, null, null, "Baiao de Dois", 40.0, null, 1 },
                    { new Guid("c88a7b50-055f-4950-86e0-5bd2fc01963a"), 1, null, null, "Caipirinha de Frutas com Vodka", 27.0, null, null },
                    { new Guid("c939a9a1-8894-48aa-87a5-0ab46106b62e"), 1, null, null, "Caipirinha de Limao com Saque", 27.0, null, null },
                    { new Guid("cae816e0-d79b-4696-853d-54f8f1d581e2"), 1, null, null, "Caipirinha de Frutas Vermelhas com Vodka", 29.0, null, null },
                    { new Guid("daef4274-ec72-493e-b55a-9ba756fa3964"), 0, null, null, "Lampião", 125.0, 4, null },
                    { new Guid("e102dc36-e4d1-4867-bc78-88abc8a8511b"), 3, null, null, "Mandioca Frita", 24.0, null, 0 },
                    { new Guid("f04141e0-5ab3-4eb5-ba6a-95ad4eacff1e"), 2, null, null, "Feijao", 6.5, null, null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("002cbf2d-899d-44f5-a504-e02c5dba63b1"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("00a4a693-41ce-427a-8f14-e9ab9c62d5df"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("038211c8-2e81-4f0b-b38c-a40c09fe83d5"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1dc661e0-e5b2-441c-b3a1-fdcecdd8c553"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("1ef8c8f2-a6ee-4b56-a30e-68ba50cec93f"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2bef545b-28fc-41bb-bf90-2dbaa3760eaf"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("2dd2e6fb-b464-4ae3-a31e-22fec131e813"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3ba2953c-a792-4783-9bdb-ef0d04875a40"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("3e1549b0-69f8-40fc-a4f5-304334a3aceb"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("41c6b6cc-6b55-43c4-a8f1-f3bf2b4dec8e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("45fdbf63-caad-40bd-8d67-3ec916d6b3f6"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("48f03ee9-ad52-47c9-a272-c74316d80f0b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("510a9109-e23c-493f-a527-1afbb166a3d5"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("547ddf8c-12f6-49da-b84c-43b6bb233160"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("571f6987-b3a6-4b36-a446-940bdabacb32"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("6bf70546-5c2c-49e5-8d85-0651b0f775e3"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("6c96151b-1236-4538-8f84-1afd7a52b93f"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("722e6634-58fc-4181-9219-f5605486d692"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8946f1f3-e517-43cb-aa19-6ad7415666c3"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("89db4161-e8b7-4c46-b478-2cb60e06e041"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("8aaf4314-a79f-4009-be67-659485197760"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a100feac-88aa-4f72-8b87-61666c7ccfcf"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a3d95543-0b33-4222-b48f-5c32482bf317"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a565e588-c4b0-4ec1-8703-fccbe748419d"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("a69bbccb-3eb3-4d3e-b2c3-0b333922da76"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b6a58019-18f7-4f7b-9ee3-69f5b0c09aff"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b89f2660-3df7-4107-81d2-bd25f3e2eb48"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("b8dbfea7-23bb-4e7e-9b7d-d103132ee81b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("bcecf4d9-ff3c-47b2-bd95-bcd497f6c82e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c26cc939-72a0-4d24-8e6f-00add63e077b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c4e9dc18-73f4-4f1e-9ba2-acf05b9fc3a6"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c82fd35e-3924-4ada-8285-bce1a9915f36"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c88a7b50-055f-4950-86e0-5bd2fc01963a"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("c939a9a1-8894-48aa-87a5-0ab46106b62e"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("cae816e0-d79b-4696-853d-54f8f1d581e2"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("daef4274-ec72-493e-b55a-9ba756fa3964"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("e102dc36-e4d1-4867-bc78-88abc8a8511b"));

            migrationBuilder.DeleteData(
                table: "Produtos",
                keyColumn: "Id",
                keyValue: new Guid("f04141e0-5ab3-4eb5-ba6a-95ad4eacff1e"));

            migrationBuilder.AddColumn<Guid>(
                name: "ComandaId",
                table: "Fechamento",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Produtos",
                columns: new[] { "Id", "Categoria", "Custo", "Descricao", "Nome", "Preco", "QuantServe", "Tamanho" },
                values: new object[,]
                {
                    { new Guid("088f77a2-6389-4ca0-944c-8d69a18eeeec"), 4, null, null, "Pettit Gateau", 18.5, null, null },
                    { new Guid("0e17dc9f-cf32-465e-9e5f-fa462ccff85d"), 1, null, null, "Caipirinha de Frutas Vermelhas com Saque", 31.0, null, null },
                    { new Guid("122b33c7-dddc-44bb-9265-1fe6c57327b7"), 1, null, null, "Caipirinha de Limao com Pinga", 15.0, null, null },
                    { new Guid("136e23dc-64a9-4070-9739-3bc373fef485"), 1, null, null, "Caipirinha de Frutas com Vodka", 27.0, null, null },
                    { new Guid("15d1b16b-f8ed-4b67-9548-3f3f99d5a3e7"), 1, null, null, "Sex on The Beach", 20.0, null, null },
                    { new Guid("1a113b60-2d25-4e00-bfa8-3220a7476155"), 0, null, null, "Lampião", 125.0, 4, null },
                    { new Guid("1c96ce4c-d1db-42b7-a076-b2363db0b141"), 3, null, null, "Mandioca Frita", 35.0, null, 2 },
                    { new Guid("1ec8a47d-fe96-476a-b2ab-ea64001abdd1"), 5, null, null, "Favada Kg", 9.5, null, null },
                    { new Guid("24772e99-09eb-49a9-95b1-82fb51970f0e"), 5, null, null, "Diversos", 1.0, null, null },
                    { new Guid("2c9e4152-b092-49cd-803b-9c88fb0ee38a"), 2, null, null, "Arroz", 5.0, null, null },
                    { new Guid("30376d1e-910d-40ac-873a-ad1f1d4aec40"), 0, null, null, "Feijoada", 35.0, null, 1 },
                    { new Guid("3c463bb1-9470-4f9b-8a6e-fb2ceb670887"), 2, null, null, "Feijao", 6.5, null, null },
                    { new Guid("56276feb-ef58-4192-bdb6-972ebf553761"), 0, null, null, "Baiao de Dois", 50.0, null, 2 },
                    { new Guid("5af5c72f-3742-43c6-8670-123b4cb969ba"), 0, null, null, "Maria Bonita", 110.0, null, null },
                    { new Guid("5ba4855b-e314-4648-ad8d-d01c7b75c0dc"), 0, null, null, "Feijoada", 70.0, null, 3 },
                    { new Guid("6b0e6e3d-c36a-49cd-9fac-f57e63887ca8"), 0, null, null, "Feijoada", 30.0, null, 0 },
                    { new Guid("78880618-c46a-419d-b5cb-c09daf649ef3"), 1, null, null, "Lua de Mel", 20.0, null, null },
                    { new Guid("791d95b0-3994-483d-83d2-e67fe48fad48"), 1, null, null, "Caipirinha de Frutas Vermelhas com Vodka", 29.0, null, null },
                    { new Guid("7982558a-ed24-437a-b5b0-f5b2e78e38e7"), 3, null, null, "Mandioca Frita", 45.0, null, 3 },
                    { new Guid("8036f6fe-cab2-4bb8-8439-16b8ff2318ed"), 0, null, null, "Baiao de Dois", 40.0, null, 1 },
                    { new Guid("80569ece-a75f-4216-b2f1-b6ad79c3a9fc"), 5, null, null, "Geleia de Mocoto", 7.0, null, null },
                    { new Guid("890820c5-be45-4f5d-a38b-6eaf6bcb7323"), 3, null, null, "Batata Frita", 40.0, null, 3 },
                    { new Guid("8c053f63-5183-4e98-af92-b01a9795a7ff"), 1, null, null, "Caipirinha de Limao com Saque", 27.0, null, null },
                    { new Guid("8cbd00a9-1bfa-469e-9425-7c7f4bb7c511"), 3, null, null, "Mandioca Frita", 29.0, null, 1 },
                    { new Guid("91f55991-05be-421b-936c-ce1e5d906a88"), 3, null, null, "Batata Frita", 20.0, null, 0 },
                    { new Guid("9f9f0490-6f09-4a8e-9897-38d24511ca3e"), 1, null, null, "Caipirinha de Limao com Vodka", 25.0, null, null },
                    { new Guid("a0d24976-bee4-4353-898d-ddf3b5ed926b"), 2, null, null, "Ovo", 2.5, null, null },
                    { new Guid("a1b0ec73-37da-42a8-985a-7877786fa4fe"), 0, null, null, "Favada", 35.0, null, null },
                    { new Guid("a22524c6-d8af-49bc-9ad2-87aa9bebe03c"), 4, null, null, "Torta Holandesa", 15.0, null, null },
                    { new Guid("a9cc489c-a8e4-43b4-971a-0ad44efa83e6"), 1, null, null, "Caipirinha de Frutas com Saque", 29.0, null, null },
                    { new Guid("c2b97eb1-2e1e-4211-bd14-b5a4ee33f135"), 1, null, null, "Caipirinha de Frutas com Pinga", 17.0, null, null },
                    { new Guid("ce009b7f-2607-43b2-b563-7f64c6c96bb8"), 3, null, null, "Batata Frita", 30.0, null, 2 },
                    { new Guid("d7469c7e-b2e8-4578-9e8f-ab1b29652b3f"), 3, null, null, "Mandioca Frita", 24.0, null, 0 },
                    { new Guid("ee4b3497-1a6f-4a71-bd69-6b9b57c859c3"), 1, null, null, "Caipirinha de Frutas Vermelhas com Pinga", 19.0, null, null },
                    { new Guid("f2a3a4c9-0539-454b-8ff0-cf8ef60f3795"), 0, null, null, "Feijoada", 50.0, null, 2 },
                    { new Guid("f3ba4178-423f-4929-9796-08670ef4d63f"), 4, null, null, "Sorvete", 10.0, null, null },
                    { new Guid("f3e8dedf-b347-4bd6-ae34-eb0e2bbec93a"), 0, null, null, "Baiao de Dois", 30.0, null, 0 },
                    { new Guid("fc752508-a9d8-4ff7-ab00-d5fca3555ac4"), 3, null, null, "Batata Frita", 25.0, null, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fechamento_ComandaId",
                table: "Fechamento",
                column: "ComandaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fechamento_ComandasTable_ComandaId",
                table: "Fechamento",
                column: "ComandaId",
                principalTable: "ComandasTable",
                principalColumn: "Id");
        }
    }
}
