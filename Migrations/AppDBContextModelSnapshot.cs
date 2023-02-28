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

                    b.Property<int?>("FinanceiroId")
                        .HasColumnType("int");

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

                    b.HasIndex("FinanceiroId");

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
                            Id = new Guid("d8a2fe6c-51fc-4195-ae3f-dba8b46a93b0"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 30.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("b8364c7b-d131-45a1-8988-d92f0c0ba170"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 35.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("fdc01406-2b75-46fb-9f8b-d495154f2294"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 50.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("72316005-140a-4dd1-befe-bf9c4581540d"),
                            Categoria = 0,
                            Nome = "Feijoada",
                            Preco = 70.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("eea8ea96-8b04-4a8b-adf7-6644948a2104"),
                            Categoria = 0,
                            Nome = "Favada",
                            Preco = 35.0
                        },
                        new
                        {
                            Id = new Guid("8dcf63b5-9c59-4ecd-969b-a337f4b73e6d"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 30.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("b58bfc43-4472-4d5f-8fc7-ad45bc763d7b"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 40.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("b9578df5-3269-4d10-bc9e-7e05375e346b"),
                            Categoria = 0,
                            Nome = "Baiao de Dois",
                            Preco = 50.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("147d4bb8-f505-4c0a-a8f5-187ff516b05a"),
                            Categoria = 0,
                            Nome = "Lampião",
                            Preco = 125.0,
                            QuantServe = 4
                        },
                        new
                        {
                            Id = new Guid("eca1cf50-34b0-48f5-b4f4-088ff3e239c8"),
                            Categoria = 0,
                            Nome = "Maria Bonita",
                            Preco = 110.0
                        },
                        new
                        {
                            Id = new Guid("df9b5a91-2967-46aa-94b7-971f703e326d"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Vodka",
                            Preco = 25.0
                        },
                        new
                        {
                            Id = new Guid("9ff9ac93-6de0-4f12-b9e8-5594d9261090"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Pinga",
                            Preco = 15.0
                        },
                        new
                        {
                            Id = new Guid("b156b6be-4da8-40c6-a277-292bb6f60ca0"),
                            Categoria = 1,
                            Nome = "Caipirinha de Limao com Saque",
                            Preco = 27.0
                        },
                        new
                        {
                            Id = new Guid("e3d96dda-6748-4b55-b97b-526ab6b26206"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Vodka",
                            Preco = 27.0
                        },
                        new
                        {
                            Id = new Guid("c62a5514-2e13-4246-bb08-c1b789bbab2a"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Pinga",
                            Preco = 17.0
                        },
                        new
                        {
                            Id = new Guid("5686857c-bee8-41d1-a1a5-9297f5f22e2a"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas com Saque",
                            Preco = 29.0
                        },
                        new
                        {
                            Id = new Guid("42e67c72-083a-4c38-a3a9-f851d12fa263"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Vodka",
                            Preco = 29.0
                        },
                        new
                        {
                            Id = new Guid("d2022fec-e04a-47e5-b073-1c484eb017d1"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Pinga",
                            Preco = 19.0
                        },
                        new
                        {
                            Id = new Guid("2cb9f185-5797-4f6f-992b-1564d6186e9b"),
                            Categoria = 1,
                            Nome = "Caipirinha de Frutas Vermelhas com Saque",
                            Preco = 31.0
                        },
                        new
                        {
                            Id = new Guid("38534e75-0a08-40cc-bd68-816dfb22888a"),
                            Categoria = 1,
                            Nome = "Lua de Mel",
                            Preco = 20.0
                        },
                        new
                        {
                            Id = new Guid("927ae63a-43bf-4e87-9593-ab5cb7dc7d13"),
                            Categoria = 1,
                            Nome = "Sex on The Beach",
                            Preco = 20.0
                        },
                        new
                        {
                            Id = new Guid("cbaf0d96-8d78-42ae-a3bf-678d90eaef96"),
                            Categoria = 2,
                            Nome = "Arroz",
                            Preco = 5.0
                        },
                        new
                        {
                            Id = new Guid("e122fdb4-3b29-45de-89a1-e377f9f585a9"),
                            Categoria = 2,
                            Nome = "Feijao",
                            Preco = 6.5
                        },
                        new
                        {
                            Id = new Guid("ee564693-442e-4595-bcdd-5651d37dd08e"),
                            Categoria = 2,
                            Nome = "Ovo",
                            Preco = 2.5
                        },
                        new
                        {
                            Id = new Guid("0eb61b60-f9e4-495d-9457-36b5387d9253"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 20.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("f6d38594-c07b-4c17-9fa3-bd176945bee8"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 25.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("c9f108b6-d28c-4c25-9e90-69ed13bbf3b3"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 30.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("f7f182c0-b08a-43fe-ad8b-1055a70e4f5f"),
                            Categoria = 3,
                            Nome = "Batata Frita",
                            Preco = 40.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("9196a514-c553-425f-8c0f-ab6c4838946e"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 24.0,
                            Tamanho = 0
                        },
                        new
                        {
                            Id = new Guid("49faf6b4-f31d-4bae-b681-6d11aee22c89"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 29.0,
                            Tamanho = 1
                        },
                        new
                        {
                            Id = new Guid("aa518629-e66b-4bfa-9908-423782a5cb14"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 35.0,
                            Tamanho = 2
                        },
                        new
                        {
                            Id = new Guid("f8abc241-e2c3-45ef-8f2e-076d810e8e57"),
                            Categoria = 3,
                            Nome = "Mandioca Frita",
                            Preco = 45.0,
                            Tamanho = 3
                        },
                        new
                        {
                            Id = new Guid("ec0bf86a-8a48-40a7-af36-4f6bb0acc485"),
                            Categoria = 4,
                            Nome = "Sorvete",
                            Preco = 10.0
                        },
                        new
                        {
                            Id = new Guid("b9eacdb9-fbd3-470c-bafb-86fcdeff1ebb"),
                            Categoria = 4,
                            Nome = "Pettit Gateau",
                            Preco = 18.5
                        },
                        new
                        {
                            Id = new Guid("03621d8b-b5a4-4983-9a79-8cb1041085fc"),
                            Categoria = 4,
                            Nome = "Torta Holandesa",
                            Preco = 15.0
                        },
                        new
                        {
                            Id = new Guid("56afe346-7801-47b1-a8a6-5c18a64c41f0"),
                            Categoria = 5,
                            Nome = "Favada Kg",
                            Preco = 9.5
                        },
                        new
                        {
                            Id = new Guid("3a5fe4c7-c8c4-4da0-920b-b594ad08f453"),
                            Categoria = 5,
                            Nome = "Geleia de Mocoto",
                            Preco = 7.0
                        },
                        new
                        {
                            Id = new Guid("9c04ae0c-789c-4901-9174-3fe388ea58da"),
                            Categoria = 5,
                            Nome = "Diversos",
                            Preco = 1.0
                        });
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Fechamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("FinanceiroId")
                        .HasColumnType("int");

                    b.Property<int>("FormaDePagamento")
                        .HasColumnType("int");

                    b.Property<double>("ValorPago")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("FinanceiroId");

                    b.ToTable("Fechamento");
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Financeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Abertura")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("IdentificacaoComanda")
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

            modelBuilder.Entity("SaborDoSertão.Domain.Pedido", b =>
                {
                    b.HasOne("SaborDoSertão.FinanceiroInfo.Financeiro", null)
                        .WithMany("Pedido")
                        .HasForeignKey("FinanceiroId");
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Fechamento", b =>
                {
                    b.HasOne("SaborDoSertão.FinanceiroInfo.Financeiro", null)
                        .WithMany("FechamentoInfo")
                        .HasForeignKey("FinanceiroId");
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Financeiro", b =>
                {
                    b.Navigation("FechamentoInfo");

                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}
