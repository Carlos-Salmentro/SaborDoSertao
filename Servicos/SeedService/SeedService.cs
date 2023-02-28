using SaborDoSertão.InfraNet;
using SaborDoSertão.Domain.Enums;
using SaborDoSertão.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.Servicos.SeedService
{
    public class SeedService
    {
        private readonly ModelBuilder modelBuilder;

        public SeedService(ModelBuilder modelBuilder)
        {
            this.modelBuilder = modelBuilder;
        }

        public void Seed()
        {
            modelBuilder.Entity<Mesa>().HasData(

                new Mesa(1),
                new Mesa(2),
                new Mesa(3),
                new Mesa(4),
                new Mesa(5),
                new Mesa(6),
                new Mesa(7),
                new Mesa(8),
                new Mesa(9),
                new Mesa(10)
            );


            modelBuilder.Entity<Produto>()
                .HasData(

            new Produto("Feijoada", 30.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.P,
                null, null, null),
            new Produto("Feijoada", 35.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.M,
                null, null, null),
            new Produto("Feijoada", 50.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.G,
                null, null, null),
            new Produto("Feijoada", 70.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.F,
                null, null, null),
            new Produto("Favada", 35.00, Domain.Enums.Categoria.Comida, null,
               null, null, null),
            new Produto("Baiao de Dois", 30.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.P,
                null, null, null),
            new Produto("Baiao de Dois", 40.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.M,
                null, null, null),
            new Produto("Baiao de Dois", 50.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.G,
                null, null, null),
            new Produto("Lampião", 125.00, Domain.Enums.Categoria.Comida, null,
                4, null, null),
            new Produto("Maria Bonita", 110.00, Domain.Enums.Categoria.Comida, null,
                null, null, null),

            new Produto("Caipirinha de Limao com Vodka", 25.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Limao com Pinga", 15.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Limao com Saque", 27.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Frutas com Vodka", 27.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Frutas com Pinga", 17.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Frutas com Saque", 29.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Frutas Vermelhas com Vodka", 29.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Frutas Vermelhas com Pinga", 19.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Caipirinha de Frutas Vermelhas com Saque", 31.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Lua de Mel", 20.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),
            new Produto("Sex on The Beach", 20.00, Domain.Enums.Categoria.Bebida, null,
                null, null, null),

            new Produto("Arroz", 5.00, Domain.Enums.Categoria.Acompanhemento, null,
                null, null, null),
            new Produto("Feijao", 6.50, Domain.Enums.Categoria.Acompanhemento, null,
                null, null, null),
            new Produto("Ovo", 2.50, Domain.Enums.Categoria.Acompanhemento, null,
                null, null, null),

            new Produto("Batata Frita", 20.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.P,
                null, null, null),
            new Produto("Batata Frita", 25.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.M,
                null, null, null),
            new Produto("Batata Frita", 30.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.G,
                null, null, null),
            new Produto("Batata Frita", 40.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.F,
                null, null, null),
            new Produto("Mandioca Frita", 24.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.P,
                null, null, null),
            new Produto("Mandioca Frita", 29.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.M,
                null, null, null),
            new Produto("Mandioca Frita", 35.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.G,
                null, null, null),
            new Produto("Mandioca Frita", 45.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.F,
                null, null, null),

            new Produto("Sorvete", 10.00, Domain.Enums.Categoria.Sobremesa, null,
                null, null, null),
            new Produto("Pettit Gateau", 18.50, Domain.Enums.Categoria.Sobremesa, null,
                null, null, null),
            new Produto("Torta Holandesa", 15.00, Domain.Enums.Categoria.Sobremesa, null,
                null, null, null),

            new Produto("Favada Kg", 9.50, Domain.Enums.Categoria.Diversos, null,
                null, null, null),
            new Produto("Geleia de Mocoto", 7.00, Domain.Enums.Categoria.Diversos, null,
                null, null, null),
            new Produto("Diversos", 1.00, Domain.Enums.Categoria.Diversos, null,
                null, null, null)

            ); ;



        }

    }
}
