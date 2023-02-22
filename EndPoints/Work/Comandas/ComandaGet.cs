using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaGet
    {
        public static string Template => "/Comandas/{identificador}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, [FromRoute] string identificador)
        {
            if (identificador == null)
            {
                return Results.BadRequest("É necessário informar a identificação da comanda para acessa-la");
            }

            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Identificador == identificador);

            if (comanda == null)
                return Results.NotFound("Nenhuma comanda encontrada com o identificador: " + identificador);

            ComandaResponse comandaResponse = new ComandaResponse
            {
                Id = comanda.Id,
                Identificador = comanda.Identificador,
                Abertura = comanda.Abertura,
                MesaId = comanda.MesaId,
                //Pedido = new List<Pedido>(context.PedidosTable.Select()
                
            };

            return Results.Ok(comandaResponse);

        }

    }
}
