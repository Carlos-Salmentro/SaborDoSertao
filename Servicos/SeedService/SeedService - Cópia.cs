//using SaborDoSertão.InfraNet;
//using SaborDoSertão.InfraEstrutura;
//using SaborDoSertão.InfraEstrutura.Enum;
//using SaborDoSertão.Domain;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;

//namespace SaborDoSertão.Servicos.SeedService
//{
//    public class SeedService
//    {
//        private readonly ModelBuilder modelBuilder;

//        public SeedService(ModelBuilder modelBuilder)
//        {
//            this.modelBuilder = modelBuilder;
//        }

//        public void Seed()
//        {
//            modelBuilder.Entity<Mesa>().HasData(
              
//                new Mesa(1),
//                new Mesa(2),
//                new Mesa(3),
//                new Mesa(4),
//                new Mesa(5),
//                new Mesa(6),
//                new Mesa(7),
//                new Mesa(8),
//                new Mesa(9),
//                new Mesa(10)
//            );


//            modelBuilder.Entity<Produto>().HasData(

//                new Produto(0001, "Feijoada", 30.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.P,
//            null, null, null),
//            new Produto(0002, "Feijoada", 35.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.M,
//                null, null, null),
//            new Produto(0003, "Feijoada", 50.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.G,
//                null, null, null),
//            new Produto(0004, "Feijoada", 70.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.F,
//                null, null, null),
//            new Produto(0005, "Favada", 35.00, Domain.Enums.Categoria.Comida, null,
//               null, null, null),
//            new Produto(0006, "Baiao de Dois", 30.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.P,
//                null, null, null),
//            new Produto(0007, "Baiao de Dois", 40.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.M,
//                null, null, null),
//            new Produto(0008, "Baiao de Dois", 50.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.G,
//                null, null, null),
//            new Produto(0009, "Lampião", 125.00, Domain.Enums.Categoria.Comida, null,
//                4, null, null),
//            new Produto(0010, "Maria Bonita", 110.00, Domain.Enums.Categoria.Comida, null,
//                null, null, null),

//            new Produto(1001, "Caipirinha de Limao com Vodka", 25.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1002, "Caipirinha de Limao com Pinga", 15.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1003, "Caipirinha de Limao com Saque", 27.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1004, "Caipirinha de Frutas com Vodka", 27.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1005, "Caipirinha de Frutas com Pinga", 17.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1006, "Caipirinha de Frutas com Saque", 29.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1007, "Caipirinha de Frutas Vermelhas com Vodka", 29.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1008, "Caipirinha de Frutas Vermelhas com Pinga", 19.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1009, "Caipirinha de Frutas Vermelhas com Saque", 31.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1010, "Lua de Mel", 20.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),
//            new Produto(1011, "Sex on The Beach", 20.00, Domain.Enums.Categoria.Bebida, null,
//                null, null, null),

//            new Produto(2001, "Arroz", 5.00, Domain.Enums.Categoria.Acompanhemento, null,
//                null, null, null),
//            new Produto(2002, "Feijao", 6.50, Domain.Enums.Categoria.Acompanhemento, null,
//                null, null, null),
//            new Produto(2003, "Ovo", 2.50, Domain.Enums.Categoria.Acompanhemento, null,
//                null, null, null),

//            new Produto(3001, "Batata Frita", 20.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.P,
//                null, null, null),
//            new Produto(3002, "Batata Frita", 25.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.M,
//                null, null, null),
//            new Produto(3003, "Batata Frita", 30.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.G,
//                null, null, null),
//            new Produto(3004, "Batata Frita", 40.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.F,
//                null, null, null),
//            new Produto(3005, "Mandioca Frita", 24.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.P,
//                null, null, null),
//            new Produto(3006, "Mandioca Frita", 29.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.M,
//                null, null, null),
//            new Produto(3007, "Mandioca Frita", 35.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.G,
//                null, null, null),
//            new Produto(3008, "Mandioca Frita", 45.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.F,
//                null, null, null),

//            new Produto(4001, "Sorvete", 10.00, Domain.Enums.Categoria.Sobremesa, null,
//                null, null, null),
//            new Produto(4002, "Pettit Gateau", 18.50, Domain.Enums.Categoria.Sobremesa, null,
//                null, null, null),
//            new Produto(4003, "Torta Holandesa", 15.00, Domain.Enums.Categoria.Sobremesa, null,
//                null, null, null),

//            new Produto(5001, "Favada Kg", 9.50, Domain.Enums.Categoria.Diversos, null,
//                null, null, null),
//            new Produto(5002, "Geleia de Mocoto", 7.00, Domain.Enums.Categoria.Diversos, null,
//                null, null, null),
//            new Produto(5003, "Diversos", 1.00, Domain.Enums.Categoria.Diversos, null,
//                null, null, null)
            
//            );
                

            
//        }

//    }
//}
