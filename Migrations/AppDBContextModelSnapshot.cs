﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaborDoSertão.InfraNet;

#nullable disable

namespace SaborDoSertão.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SaborDoSertão.Domain.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Abertura")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime(6)");

                    b.Property<bool>("Ativa")
                        .HasColumnType("tinyint(1)")
                        .HasColumnName("Ativa");

                    b.Property<DateTime>("Fechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Identificador")
                        .HasColumnType("longtext");

                    b.Property<int?>("MesaId")
                        .HasColumnType("int");

                    b.Property<double>("ValorPago")
                        .HasColumnType("double");

                    b.Property<double>("ValorRestante")
                        .HasColumnType("double");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("ComandasTable");
                });

            modelBuilder.Entity("SaborDoSertão.Domain.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mesas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Status = 0
                        },
                        new
                        {
                            Id = 2,
                            Status = 0
                        },
                        new
                        {
                            Id = 3,
                            Status = 0
                        },
                        new
                        {
                            Id = 4,
                            Status = 0
                        },
                        new
                        {
                            Id = 5,
                            Status = 0
                        },
                        new
                        {
                            Id = 6,
                            Status = 0
                        },
                        new
                        {
                            Id = 7,
                            Status = 0
                        },
                        new
                        {
                            Id = 8,
                            Status = 0
                        },
                        new
                        {
                            Id = 9,
                            Status = 0
                        },
                        new
                        {
                            Id = 10,
                            Status = 0
                        });
                });

            modelBuilder.Entity("SaborDoSertão.Domain.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("NomeProduto")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.Property<Guid>("ProdutoId")
                        .HasColumnType("char(36)");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("PedidosTable");
                });

            modelBuilder.Entity("SaborDoSertão.Domain.Produto", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<double?>("Custo")
                        .HasColumnType("double");

                    b.Property<string>("Descricao")
                        .HasColumnType("longtext");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Preco")
                        .HasColumnType("double");

                    b.Property<int?>("QuantServe")
                        .HasColumnType("int");

                    b.Property<int?>("Tamanho")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Produtos");

                    b.HasData(
                        new
                        {
                            Id = new Guid("52895843-fa19-4aa8-a8e0-949f5994beb1"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 30.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("a5ff8a08-7792-49d8-b12e-a424b84b6e1e"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 35.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("7538939d-1957-4ec4-8728-5a0896de5685"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 50.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("a0e95a64-d942-45e8-9024-e7c180b1c93e"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 70.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("41604007-b0c4-46ca-8ae3-2d23f4b9d10f"),
                            Categoria = 0,
                            Nome = "Favada",
                            Preco = 35.0
                        },
                        new
                        {
                            Id = new Guid("7b94997f-c27f-4d8a-bb5a-d6b28037a14f"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 30.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("4aab0789-fbe5-4fa3-9957-c96174a1f902"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 40.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("2e942fb0-9c96-46c1-a724-bf70ac7cc127"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 50.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("6c5cf1a6-e66b-46cc-8366-4ca53745aa11"),
                            Categoria = 0,
                            Nome = "Lampião",
                            Preco = 125.0,
                            QuantServe = 4
                        },
                        new
                        {
                            Id = new Guid("aaf48383-f05c-4850-ad5e-b8cbd27fbcee"),
                            Categoria = 0,
                            Nome = "Maria Bonita",
                            Preco = 110.0
                        },
                        new
                        {
                            Id = new Guid("2dd62479-5e90-4312-8e3e-fdde68f67921"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Vodka",
                            Preco = 25.0
                        },
                        new
                        {
                            Id = new Guid("a5599d2e-7655-4361-bb59-536b1a6a76b2"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Pinga",
                            Preco = 15.0
                        },
                        new
                        {
                            Id = new Guid("7d907743-3d07-4f01-a5c4-0e7b8705d464"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Saque",
                            Preco = 27.0
                        },
                        new
                        {
                            Id = new Guid("dea0c8e4-a3bd-4963-87d1-86787cee9de0"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Vodka",
                            Preco = 27.0
                        },
                        new
                        {
                            Id = new Guid("2d173082-a94f-4cbc-bec0-c0d56ab6bcbc"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Pinga",
                            Preco = 17.0
                        },
                        new
                        {
                            Id = new Guid("fb5195ac-ceb7-409c-8ba1-35203becca61"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Saque",
                            Preco = 29.0
                        },
                        new
                        {
                            Id = new Guid("898c161f-6a81-47bb-9702-0d638cdfb167"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Vodka",
                            Preco = 29.0
                        },
                        new
                        {
                            Id = new Guid("dba79881-4a6f-4f19-9c64-07eeab5444bc"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Pinga",
                            Preco = 19.0
                        },
                        new
                        {
                            Id = new Guid("e27483dc-32e9-4847-bdc2-5e2ceca78bc7"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Saque",
                            Preco = 31.0
                        },
                        new
                        {
                            Id = new Guid("1ef0533f-5e55-422e-97c2-e7ad91ccea80"),
                            Categoria = 1,
                            Nome = "Lua de Mel",
                            Preco = 20.0
                        },
                        new
                        {
                            Id = new Guid("0861d788-a486-43e0-923c-4300de29352a"),
                            Categoria = 1,
                            Nome = "Sex on The Beach",
                            Preco = 20.0
                        },
                        new
                        {
                            Id = new Guid("cf0c01a3-909b-423f-a87f-60bf8422080d"),
                            Categoria = 2,
                            Nome = "Arroz",
                            Preco = 5.0
                        },
                        new
                        {
                            Id = new Guid("5d9cfccf-2f04-43ce-9b78-62db233ca6f8"),
                            Categoria = 2,
                            Nome = "Feijao",
                            Preco = 6.5
                        },
                        new
                        {
                            Id = new Guid("555bd4bd-87a8-44cc-ab33-170f4d15cbc1"),
                            Categoria = 2,
                            Nome = "Ovo",
                            Preco = 2.5
                        },
                        new
                        {
                            Id = new Guid("a1b627d4-8e3a-44f2-bf37-cb4baf205269"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 20.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("d6e3c776-c2d0-4370-9b47-e931e680b39b"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 25.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("615abbb3-766e-462b-b66e-613cd523b43f"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 30.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("a908d7cb-52b2-4494-91f4-dc9fddcb9ded"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 40.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("cd99fc51-acde-40e2-804b-1a33e20b9d4d"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 24.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("6ee5abf5-66b1-4c3e-b614-432a12cd7a52"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 29.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("a863e0ae-b22d-430d-9729-4bb6065e53e9"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 35.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("7387af10-d042-4401-8376-ea81a7ac3b22"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 45.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("2dd10a02-d4fd-4014-82e9-1341f06ddb3a"),
                            Categoria = 4,
                            Nome = "Sorvete",
                            Preco = 10.0
                        },
                        new
                        {
                            Id = new Guid("4aee1a52-7f9d-4c3c-9245-1ea199d2d4d1"),
                            Categoria = 4,
                            Nome = "Pettit Gateau",
                            Preco = 18.5
                        },
                        new
                        {
                            Id = new Guid("a7f5efe3-050a-4dce-8947-d34d0d35a6d1"),
                            Categoria = 4,
                            Nome = "Torta Holandesa",
                            Preco = 15.0
                        },
                        new
                        {
                            Id = new Guid("99252b41-2d36-4dd8-b64a-3a83ea3ad2ce"),
                            Categoria = 5,
                            Nome = "Favada Kg",
                            Preco = 9.5
                        },
                        new
                        {
                            Id = new Guid("eea60fa3-3793-436d-aa46-73599e401ced"),
                            Categoria = 5,
                            Nome = "Geleia de Mocoto",
                            Preco = 7.0
                        },
                        new
                        {
                            Id = new Guid("b6c13303-b524-4432-9160-3373bf98f116"),
                            Categoria = 5,
                            Nome = "Diversos",
                            Preco = 1.0
                        });
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Financeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Abertura")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Fechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FechamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Identificador")
                        .HasColumnType("longtext");

                    b.Property<int?>("MesaId")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("FinanceiroTable");
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("ComandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("Data");

                    b.Property<int>("FormaDePagamento")
                        .HasColumnType("int");

                    b.Property<double>("ValorPago")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("PagamentosTable");
                });
#pragma warning restore 612, 618
        }
    }
}
