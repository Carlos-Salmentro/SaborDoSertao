using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaPedidoPost
    {
        public static string Template => "/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute]int id, AppDBContext context, [FromBody]ComandaRequest? comanda, PedidoRequest pedido)
        {
            var mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
                return Results.BadRequest("Nenhuma mesa encontrada com esse número: " + id);

           if(mesa.Comanda == null)
            {
                mesa.Comanda = new Comanda { Identificador = comanda.Identificador, Abertura = DateTime.Now}
            }
        }
        
    }
}
