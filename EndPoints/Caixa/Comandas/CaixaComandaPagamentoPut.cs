using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraNet;
using System.Net.NetworkInformation;

namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class CaixaComandaPagamentoPut
    {
        public static string Template => "/Caixa/Pagamento/{comandaId}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] int comandaId, [FromBody] PagamentoRequest pagamentoRequest,
            [FromServices] AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);
            if (comanda == null)
            {
                return Results.NotFound("Nenhuma comanda com o Id: " + comandaId + " encontrada. \nSelecione novamente a comanda que deseja pagar.");
            }

            Pagamento pagamento = new Pagamento(comandaId, pagamentoRequest.FormaPagamento, pagamentoRequest.ValorPago);
            context.PagamentosTable.Add(pagamento);
            comanda.ValorPago += pagamentoRequest.ValorPago;
            comanda.ValorRestante -= pagamentoRequest.ValorPago;

            //if (comanda.ValorRestante <= 0.0)
            //{
                


            //}

            return Results.Ok();
        }
    }
}
