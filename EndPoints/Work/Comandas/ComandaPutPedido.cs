using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaPutPedido
    {
        public static string Template => "/Comandas/{comandaId}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] int comandaId, [FromBody] PedidoRequest pedidoRequests, AppDBContext context)
        {
            if (pedidoRequests == null)
            {
                return Results.NotFound("Nenhum pedido para adicionar à comanda");
            }

            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);

            if (comanda == null)
            {
                return Results.NotFound("Nenhuma comanda encontrada com o identificador " + comandaId);
            }
            
            Produto produto = context.ProdutosTable.FirstOrDefault(x => x.Id == pedidoRequests.ProdutoId);

            if(produto == null)
            {
                return Results.NotFound("Nenhum produto encontrado com o Id: " + pedidoRequests.ProdutoId);
            }

            Pedido pedidos = new Pedido(comandaId, produto, pedidoRequests.Quantidade, pedidoRequests.Observacao);

            comanda.ValorTotal += pedidos.Valor;
            comanda.ValorRestante += pedidos.Valor;

            context.PedidosTable.AddRange(pedidos);
            context.SaveChanges();
            //imprimir List<Pedido> pedidos bar - cozinha

            return Results.Created(Template, pedidoRequests);

        }
    }
}
