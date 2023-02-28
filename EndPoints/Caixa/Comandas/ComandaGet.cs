using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class ComandaGet
    {
        public static string Template => "Caixa/Comanda/{ComandaId}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] int ComandaId, AppDBContext context)
        {
            Comanda comanda = 
                context.ComandasTable.FirstOrDefault(x => x.Id == ComandaId);

            if (comanda == null)
                return Results.NotFound(ComandaId);

            ComandaResponse comandaResponse = new ComandaResponse
            {
                Id = comanda.Id,
                MesaId = comanda.MesaId,
                Abertura = comanda.Abertura,
                Fechamento = comanda.Fechamento,
                Identificador = comanda.Identificador,
                ValorTotal = comanda.ValorTotal,
                ValorPago = comanda.ValorPago,
                ValorRestante = comanda.ValorRestante,
            };

            return Results.Ok(comandaResponse);

        }
    }
}
