using SaborDoSertão.Domain;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.SeedService
{
    public class SeedService
    {
        public List<Mesa> Mesas = new List<Mesa>
        {
            new Mesa(1),
            new Mesa(2),
            new Mesa(3),
            new Mesa(4),
            new Mesa(5),
            new Mesa(6),
            new Mesa(7),
            new Mesa(8),
            new Mesa(9),
            new Mesa(10),
            new Mesa(11),
            new Mesa(12),
            new Mesa(13),
            new Mesa(14),
            new Mesa(15),
            new Mesa(16),
            new Mesa(17),
            new Mesa(18),
            new Mesa(19),
            new Mesa(20)
        };


        public List<Produto> Produtos = new List<Produto>
        {
            new Produto(101, "Feijoada", 35.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.P, null, null, null),
            new Produto(102, "Feijoada", 45.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.M, null, null, null),
            new Produto(103, "Feijoada", 55.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.G, null, null, null),
            new Produto(104, "Feijoada", 75.00, Domain.Enums.Categoria.Comida, Domain.Enums.Tamanho.F, null, null, null),
            new Produto(215, "Sex on the beach", 21.00, Domain.Enums.Categoria.Bebida, null, null, null, null),
            new Produto(301, "Torresmo", 27.00, Domain.Enums.Categoria.Porcao, Domain.Enums.Tamanho.P, null, null, null),
            new Produto(401, "Feijão", 10.00, Domain.Enums.Categoria.Acompanhemento, null, null, null, null),
            new Produto(505, "Cheese Cake", 12.50, Domain.Enums.Categoria.Sobremesa, null, null, null, null),
            new Produto(901, "Fava", 20.00, Domain.Enums.Categoria.Diversos, null, null, null, null)
        };


        //public void SeedService(List<Mesa> Mesas, List<Produto> Produtos, AppDBContext context)
        //{
        //    if (context.Mesas.Count == 0)
        //    {
        //        foreach (Mesa X in Mesas)
        //        {
        //            context.Mesas.Add(X);
        //        }
        //    }

        //    if (context.Produtos.Count == 0)
        //    {
        //        foreach (Produto X in Produtos)
        //        {
        //            context.Produtos.Add(X);
        //        }
        //    }
        //}
    }
}
