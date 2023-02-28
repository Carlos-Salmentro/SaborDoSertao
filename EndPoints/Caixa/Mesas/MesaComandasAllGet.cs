using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Mesas
{
    public class MesaComandasAllGet
    {
        public static string Template => "/Caixa/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromServices] AppDBContext context, [FromRoute] int id)
        {
            List<Comanda> comandas= context.ComandasTable.Where(x => x.MesaId== id).ToList();

            List<ComandaResponse> list = new List<ComandaResponse>();

            foreach (Comanda comanda in comandas)
            {
                ComandaResponse comandaResponse = new ComandaResponse
                {
                    Id = comanda.Id,
                    Abertura = comanda.Abertura,
                    Identificador = comanda.Identificador,
                    MesaId = comanda.MesaId,
                    
                };

                list.Add(comandaResponse);
            };

            return Results.Ok(list);
        }

        public static IResult ImprimirComandas([FromRoute] int id, [FromServices] AppDBContext context)
        {
            List<Comanda> comandas = context.ComandasTable.Where(x => x.MesaId == id).ToList();
            if (comandas == null)
                return Results.NotFound();

            foreach (Comanda comanda in comandas)
            {
                //imprimirComanda
            }

            return Results.Ok();
        }

        public static void SelecionarComanda([FromBody] ComandaResponse comandaResponse, /*int id*/ HttpResponse response)
        {
            response.Redirect(Template + "/Comanda/" + comandaResponse.Id);
        }
    }


}
