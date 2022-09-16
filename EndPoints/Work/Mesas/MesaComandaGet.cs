using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;
using System.Collections.Generic;
using System.Web.Http;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaComandaGet
    {

        public static string Template => "/Mesas/{id}";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;
        public static Mesa mesa { get; set; }

        public static IResult Action([FromRoute] int id, AppDBContext context)
        {
            mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
                return Results.NotFound("Nenhuma mesa encontrada com o número: " + id);

            var comandas = mesa.Comanda;

            List<ComandaResponse> response = new List<ComandaResponse>();

            foreach (Comanda x in comandas)
            {
                ComandaResponse resp = new ComandaResponse
                {
                    Id = x.Id,
                    Abertura = x.Abertura,
                    Identificador = x.Identificador,
                    MesaId = x.MesaId,
                    Pedido = x.Pedido,
                    Fechamento = x.Fechamento
                };

                response.Add(resp);
            }

            return Results.Ok(response);

        }

        public static void SelectComandaResponse(ComandaResponse comandaResponse, HttpResponse response)
        {
            response.Redirect(Template + "/Comanda/" + comandaResponse.Id);
        }

    }
}
