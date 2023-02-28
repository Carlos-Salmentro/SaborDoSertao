using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaPutPedido
    {
        public static string Template => "/Comandas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(ComandaResponse comandaResponse, List<PedidoRequest> pedidoRequests, AppDBContext context)
        {
            if (pedidoRequests == null)
            {
                return Results.NotFound("Nenhum pedido para adicionar à comanda");
            }

            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Identificador == comandaResponse.Identificador);

            if (comanda == null)
            {
                return Results.NotFound("Nenhuma comanda encontrada com o identificador " + comandaResponse.Identificador);
            }

            List<Pedido> pedidos = new List<Pedido>();

            foreach (PedidoRequest x in pedidoRequests)
            {
                Produto produto = context.ProdutosTable.Single(p => p.Id == x.ProdutoId);
                Pedido pedido = new Pedido(comanda.Id, produto, x.Quantidade, x.Observacao);
                pedidos.Add(pedido);
            }

            comanda.ValorTotal += pedidos.Sum(x => x.Valor);
            comanda.ValorRestante += pedidos.Sum(x => x.Valor);

            context.PedidosTable.AddRange(pedidos);
            context.SaveChanges();
            //imprimir List<Pedido> pedidos bar - cozinha

            return Results.Created(Template, pedidoRequests);

        }
    }
}
