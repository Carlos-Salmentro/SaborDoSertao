using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;
using System.Web.Http;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesasComandaPedidoPut
    {
        public static string Template => "/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;
        public static Mesa mesa;

        
        public static IResult Action([FromBody]Comanda comanda, [FromBody]List<PedidoRequest> pedidoRequest, AppDBContext context)
        {
            List<Pedido> pedidos = new List<Pedido>();

            foreach (PedidoRequest x in pedidoRequest)
            {
                Pedido pedido = new Pedido(x.Produtos, x.Quantidade, x.Observacao);
                comanda.Pedido.Add(pedido);
            }

            context.SaveChangesAsync();
            //Imprimir bar/Cozinha
            return Results.CreatedAtRoute(Template);
        }
    }
}
