using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
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
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
                return Results.NotFound("Nenhuma mesa encontrada com o número " + id);


            List<ComandaResponse> list = new List<ComandaResponse>();

            foreach (Comanda comanda in mesa.Comanda)
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
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
                return Results.NotFound(id);

            List<Comanda> comandas = mesa.Comanda;
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
