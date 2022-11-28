using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Mesas
{
    public class MesaFechamentoPost
    {
        public static string Template => "Caixa/Mesas/{id}";
        public static string[] Method = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromServices] AppDBContext context, [FromRoute] int id, [FromRoute] int comandaId)
        {
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if (mesa == null)
            {
                return Results.NotFound(id);
            }

            Comanda comanda = mesa.Comanda.FirstOrDefault(x => x.Id == comandaId);
            if (comanda == null)
                Results.NotFound(comandaId);

            ComandaResponse comandaResponse = new ComandaResponse
            {
                Id = comandaId,
                Abertura = comanda.Abertura,
                Identificador = comanda.Identificador,
                MesaId = comanda.MesaId,
                Pedido = comanda.Pedido,
                ValorTotal = comanda.Pedido.Sum(x => x.Valor),
                ValorRestante = comanda.ValorTotal - comanda.ValorPago
            };

            return Results.Ok(comandaResponse);

        }

        
    }
}
