using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraNet;
using System.Net.NetworkInformation;

namespace SaborDoSertão.EndPoints.Caixa
{
    public class CaixaPagamento
    {
        public static string Template => "/Caixa/Pagamento/{comandaId}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] int comandaId, [FromBody] FormaPagamento formaPagamento, [FromBody] double valorPago,
            [FromServices] AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);
            if(comanda == null)
            {
                return Results.NotFound("Nenhuma comanda com o Id: " + comandaId + " encontrada. \nSelecione novamente a comanda que deseja pagar.");
            }

            Pagamento fechamento = new Pagamento(comandaId, formaPagamento, valorPago);
            context.FechamentosTable.Add(fechamento);
            comanda.ValorPago += valorPago;
            comanda.ValorRestante -= valorPago;

            if(comanda.ValorRestante <= 0.0)
            {
                List<Pagamento> fechamentos = context.FechamentosTable.Where(x => x.ComandaId == comandaId).ToList();

                    
            }

            return Results.Ok();
        }
    }
}
