using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;
using System.Linq;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesasComandaPedidoPut
    {
        public static string Template => "/Mesas/{id}/Comanda/{ComandaId}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;
        public static Mesa mesa;


        public static IResult Action([FromRoute] int id, [FromRoute] int ComandaId, [FromBody] List<PedidoRequest> pedidoRequest, AppDBContext context)
        {
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
                return Results.NotFound("Nenhuma mesa encontrada com o número: " + id);

            Comanda comanda = mesa.Comanda.FirstOrDefault(x => x.Id == ComandaId);

            List<Pedido> pedidos = new List<Pedido>();

            foreach (PedidoRequest x in pedidoRequest)
            {
                Pedido pedido = new Pedido(comanda.Id, x.ProdutoId, x.Quantidade, x.Observacao, context);
                context.PedidosTable.Add(pedido);
            }

            comanda.ValorTotal += pedidos.Sum(x => x.Valor);
            comanda.ValorRestante += pedidos.Sum(x => x.Valor);
            
            context.SaveChangesAsync().Wait();
            //Imprimir bar/Cozinha
            return Results.Created(Template, pedidoRequest);
        }
    }

}
