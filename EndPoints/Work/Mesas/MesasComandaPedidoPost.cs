using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;
using System.Linq;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesasComandaPedidoPost
    {
        public static string Template => "/Mesas/{mesaId}/Comanda/{ComandaId}";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;
        public static Mesa mesa;


        public static IResult Action([FromRoute] int mesaId, [FromRoute] int comandaId, [FromBody] PedidoRequest pedidoRequest, AppDBContext context)
        {
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == mesaId);
            if (mesa == null)
                return Results.NotFound("Nenhuma mesa encontrada com o número: " + mesaId);


            Comanda comanda = context.ComandasTable.Where(x => x.Ativa == true).FirstOrDefault(x => x.Id == comandaId);
            if (comanda == null)
            {
                return Results.NotFound("Nenhuma comanda com o Id " + comandaId.ToString() + " encontrada!");
            }


            Produto produto = context.ProdutosTable.Single(p => p.Id == pedidoRequest.ProdutoId);
            Pedido pedido = new Pedido(comanda.Id, produto, pedidoRequest.Quantidade, pedidoRequest.Observacao);
            context.PedidosTable.Add(pedido);

            comanda.ValorTotal += pedido.Valor;
            comanda.ValorRestante += pedido.Valor;

            context.SaveChangesAsync().Wait();
            //Imprimir bar/Cozinha
            return Results.Created(Template, pedidoRequest);
        }

        //public static IResult Action([FromRoute] int mesaId, [FromRoute] int comandaId, [FromBody] List<PedidoRequest> pedidoRequest, AppDBContext context)
        //{
        //    Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == mesaId);
        //    if (mesa == null)
        //        return Results.NotFound("Nenhuma mesa encontrada com o número: " + mesaId);

        //    Comanda comanda = mesa.Comanda.FirstOrDefault(x => x.Id == comandaId);

        //    List<Pedido> pedidos = new List<Pedido>();

        //    foreach (PedidoRequest x in pedidoRequest)
        //    {
        //        Produto produto = context.ProdutosTable.Single(p => p.Id == x.ProdutoId);
        //        pedidos.Add(new Pedido(comanda.Id, produto, x.Quantidade, x.Observacao));
        //    }

        //    comanda.ValorTotal += pedidos.Sum(x => x.Valor);
        //    comanda.ValorRestante += pedidos.Sum(x => x.Valor);

        //    context.SaveChangesAsync().Wait();
        //    //Imprimir bar/Cozinha
        //    return Results.Created(Template, pedidoRequest);
        //}
    }

}
