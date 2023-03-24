using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;
using System.Collections.Generic;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaComandaGet
    {

        public static string Template => "/Mesas/{MesaId}";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;
        public static Mesa mesa { get; set; }

        public static IResult Action([FromRoute] int MesaId, AppDBContext context)
        {
            mesa = context.Mesas.FirstOrDefault(x => x.Id == MesaId);
            if (mesa == null)
                return Results.NotFound("Nenhuma mesa encontrada com o número: " + MesaId);

            List<Comanda> comandas = context.ComandasTable.Where(x => x.Ativa == true).Where(x => x.MesaId == MesaId).ToList();

            List<ComandaResponse> response = new List<ComandaResponse>();

            foreach (var comanda in comandas)
            {
                ComandaResponse comandaResponse = new ComandaResponse(comanda);

                response.Add(comandaResponse);
            }

            return Results.Ok(response);

        }

        public static void SelectComandaResponse(ComandaResponse comandaResponse, HttpResponse response)
        {
            response.Redirect(Template + "/Comanda/" + comandaResponse.Id);
        }

    }
}
