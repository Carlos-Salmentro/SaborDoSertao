﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SaborDoSertão.InfraNet;

#nullable disable

namespace SaborDoSertão.Migrations
{
    [DbContext(typeof(AppDBContext))]
    [Migration("20230314170413_AtualizandoTabelas")]
    partial class AtualizandoTabelas
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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
                            Id = new Guid("fb2195c5-0bbb-4645-8281-e88ecb6d968c"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 30.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("4713c7bb-feb4-464f-a24e-316ff5e43dbc"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 35.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("9099294d-6cd8-4572-9e83-2b3bd336128a"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 50.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("daa38710-ba49-46f1-9b88-64132f85c526"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 70.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("8f8a2eb3-ab79-4144-a149-67a21c9f85eb"),
                            Categoria = 0,
                            Nome = "Favada",
                            Preco = 35.0
                        },
                        new
                        {
                            Id = new Guid("5f7cedf8-63c8-4980-a81f-df4a974b0c4e"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 30.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("2deafc4d-5846-4453-a03d-d0de680783e0"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 40.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("1d43099a-8c22-458c-aca8-527af6e8bc63"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 50.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("e79a4dce-0f25-4419-a361-f6c5353f574c"),
                            Categoria = 0,
                            Nome = "Lampião",
                            Preco = 125.0,
                            QuantServe = 4
                        },
                        new
                        {
                            Id = new Guid("1ec5f733-eb81-4135-bf0f-c045a633dee9"),
                            Categoria = 0,
                            Nome = "Maria Bonita",
                            Preco = 110.0
                        },
                        new
                        {
                            Id = new Guid("0ff02e44-d36e-4e61-baf2-e46fd5f99734"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Vodka",
                            Preco = 25.0
                        },
                        new
                        {
                            Id = new Guid("df19d7cf-b6f3-44bb-97d3-f041a1ddb62e"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Pinga",
                            Preco = 15.0
                        },
                        new
                        {
                            Id = new Guid("38ca23ff-f8e4-412f-a7f6-021bb89b46a8"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Saque",
                            Preco = 27.0
                        },
                        new
                        {
                            Id = new Guid("5c6cb0f5-a390-44f4-bf95-ce768e0807a0"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Vodka",
                            Preco = 27.0
                        },
                        new
                        {
                            Id = new Guid("5e9ea480-a04f-444f-95cb-9437e5d83f1b"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Pinga",
                            Preco = 17.0
                        },
                        new
                        {
                            Id = new Guid("7a57e2af-4216-40b1-931c-58446835c11c"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Saque",
                            Preco = 29.0
                        },
                        new
                        {
                            Id = new Guid("38f3e4dc-6e19-49c2-9ce0-2fbb77725811"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Vodka",
                            Preco = 29.0
                        },
                        new
                        {
                            Id = new Guid("8a755427-94c0-4ba6-92fa-2aaf645c394a"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Pinga",
                            Preco = 19.0
                        },
                        new
                        {
                            Id = new Guid("9748df97-e0d1-4a04-bbea-3170c13694fe"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Saque",
                            Preco = 31.0
                        },
                        new
                        {
                            Id = new Guid("2c47259f-4721-48e8-a5f4-4db4c82d69b3"),
                            Categoria = 1,
                            Nome = "Lua de Mel",
                            Preco = 20.0
                        },
                        new
                        {
                            Id = new Guid("3a06b141-50e3-45d4-a5dd-1b6ef3b57229"),
                            Categoria = 1,
                            Nome = "Sex on The Beach",
                            Preco = 20.0
                        },
                        new
                        {
                            Id = new Guid("bcd91d53-8ae8-40eb-9a57-e3f15438b070"),
                            Categoria = 2,
                            Nome = "Arroz",
                            Preco = 5.0
                        },
                        new
                        {
                            Id = new Guid("1d7276af-9429-4abc-9e43-102ca01927cf"),
                            Categoria = 2,
                            Nome = "Feijao",
                            Preco = 6.5
                        },
                        new
                        {
                            Id = new Guid("1d0dc275-7d4a-4cd4-9e1a-0273fa89392b"),
                            Categoria = 2,
                            Nome = "Ovo",
                            Preco = 2.5
                        },
                        new
                        {
                            Id = new Guid("aed69bd7-9d46-4a1e-bad2-e669564f9e81"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 20.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("f4e080be-3089-4821-b31b-3f13dff8ea93"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 25.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("4345b549-487d-40c5-912a-89ad9675ed7d"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 30.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("3617c55d-90d8-435d-807d-b0259832127e"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 40.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("4e44e3df-9334-4f1e-a5b4-a30485177d27"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 24.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("e17b0971-6237-4a07-b976-902ef08ae327"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 29.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("aceef5be-c148-4413-a477-b33ade8ba270"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 35.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("d4a01ee2-d480-4b1b-9167-56fd6bd54785"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 45.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("e6684166-0442-43a4-875a-b5e231d60353"),
                            Categoria = 4,
                            Nome = "Sorvete",
                            Preco = 10.0
                        },
                        new
                        {
                            Id = new Guid("5932463e-c706-4e9b-b0d8-f60d4ada4b7a"),
                            Categoria = 4,
                            Nome = "Pettit Gateau",
                            Preco = 18.5
                        },
                        new
                        {
                            Id = new Guid("ac8a8041-3c7e-4ae3-920b-a8ec46541977"),
                            Categoria = 4,
                            Nome = "Torta Holandesa",
                            Preco = 15.0
                        },
                        new
                        {
                            Id = new Guid("0d2dc50a-9a8a-400b-bbd5-73cb68a38007"),
                            Categoria = 5,
                            Nome = "Favada Kg",
                            Preco = 9.5
                        },
                        new
                        {
                            Id = new Guid("457bea7a-9624-43c3-9e8f-7b766db5e3e4"),
                            Categoria = 5,
                            Nome = "Geleia de Mocoto",
                            Preco = 7.0
                        },
                        new
                        {
                            Id = new Guid("702f4f6c-008f-40b8-95f2-b7bae85a6542"),
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
