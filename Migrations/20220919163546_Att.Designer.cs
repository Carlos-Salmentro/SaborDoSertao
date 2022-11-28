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
    [Migration("20220919163546_Att")]
    partial class Att
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("SaborDoSertão.Domain.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

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
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Fechamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ComandaId")
                        .HasColumnType("int");

                    b.Property<int>("FormaDePagamento")
                        .HasColumnType("int");

                    b.Property<double>("ValorPago")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ComandaId");

                    b.ToTable("Fechamento");
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Financeiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("FinanceiroTable");
                });

            modelBuilder.Entity("SaborDoSertão.InfraEstrutura.Comanda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("Abertura")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("Fechamento")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Identificador")
                        .HasColumnType("longtext");

                    b.Property<int?>("MesaId")
                        .HasColumnType("int");

                    b.Property<double>("ValorTotal")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("ComandasTable");
                });

            modelBuilder.Entity("SaborDoSertão.InfraEstrutura.Mesa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Mesas");
                });

            modelBuilder.Entity("SaborDoSertão.InfraEstrutura.Pedido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("ComandaId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Observacao")
                        .HasColumnType("longtext");

                    b.Property<int>("ProdutosId")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<double>("Valor")
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.HasIndex("ComandaId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("Pedidos");
                });

            modelBuilder.Entity("SaborDoSertão.FinanceiroInfo.Fechamento", b =>
                {
                    b.HasOne("SaborDoSertão.InfraEstrutura.Comanda", null)
                        .WithMany("FechamentoInfo")
                        .HasForeignKey("ComandaId");
                });

            modelBuilder.Entity("SaborDoSertão.InfraEstrutura.Pedido", b =>
                {
                    b.HasOne("SaborDoSertão.InfraEstrutura.Comanda", null)
                        .WithMany("Pedido")
                        .HasForeignKey("ComandaId");

                    b.HasOne("SaborDoSertão.Domain.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("SaborDoSertão.InfraEstrutura.Comanda", b =>
                {
                    b.Navigation("FechamentoInfo");

                    b.Navigation("Pedido");
                });
#pragma warning restore 612, 618
        }
    }
}