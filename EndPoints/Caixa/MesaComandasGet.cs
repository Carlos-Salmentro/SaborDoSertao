using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa
{
    public class MesaComandasGet
    {
        public static string Template => "/Caixa/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, [FromRoute] int id)
        {
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
            {
                return Results.NotFound("Nenhuma mesa encontrada com o número " + id);
            }

            List<ComandaResponse> list = new List<ComandaResponse>();

            foreach (Comanda comanda in mesa.Comanda)
            {
                ComandaResponse comandaResponse = new ComandaResponse
                {
                    Id = comanda.Id,
                    Abertura = comanda.Abertura,
                    Identificador = comanda.Identificador,
                    MesaId = comanda.MesaId,
                    Pedido = comanda.Pedido
                };

                list.Add(comandaResponse);
            };

            return Results.Ok(list);
        }

        public static void SelecionarComanda(ComandaResponse comandaResponse, HttpResponse response)
        {
            response.Redirect(Template + "/Comanda/" + comandaResponse.Id);
        }
    }

    
}
