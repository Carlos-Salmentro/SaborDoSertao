using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa
{
    public class MesaFechamentoDelete
    {
        public static string Template = "Caixa/Mesas/{id}/Comanda/{comandaId}";
        public static string[] Method = new string[] { HttpMethod.Delete.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, [FromRoute] int id, [FromRoute] int comandaId)
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

        public static IResult PagarComandaTotal(ComandaResponse comandaResponse, AppDBContext context, bool confirma, FormaPagamento formaPagamento)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaResponse.Id);

            if (comanda == null)
                return Results.NotFound(comandaResponse.Id);

            comanda.ValorTotal = (double)comandaResponse.ValorTotal;

            Fechamento fechamento = new Fechamento(formaPagamento, comanda.ValorTotal);
            comanda.FechamentoInfo.Add(fechamento);

            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == comanda.MesaId);

            if (confirma == true)
            {
                comanda.ValorPago = comanda.ValorTotal;
                comanda.ValorRestante -= 0.0;
                Financeiro financeiro = new Financeiro(comanda);
                context.FinanceiroTable.Add(financeiro);
                mesa.Comanda.Remove(comanda);
                mesa.Status = InfraEstrutura.Enum.Status.Disponivel;
                context.SaveChanges();
                return Results.Ok();
                //imprimir comprovante
            }

            else
            {
                return Results.Redirect(Template);
            }

        }

        public static IResult DividirPagamentoComanda(ComandaResponse comandaResponse, AppDBContext context, bool confirma, FormaPagamento formaPagamento, double valorPago)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaResponse.Id);

            if (comanda == null)
                return Results.NotFound(comanda.Id);

            comanda.ValorTotal = (double)comandaResponse.ValorTotal;

            Fechamento fechamento = new Fechamento(formaPagamento, valorPago);
            
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == comandaResponse.MesaId);

            if(confirma == true)
            {
                comanda.FechamentoInfo.Add(fechamento);
                comanda.ValorPago += valorPago;
                comanda.ValorRestante -= valorPago;
                comanda.FechamentoInfo.Add(fechamento);

                if (comanda.ValorRestante == 0)
                {
                    Financeiro financeiro = new Financeiro(comanda);
                    context.FinanceiroTable.Add(financeiro);
                    mesa.Comanda.Remove(comanda);

                    //imprimirComandaComprovante
                }

                context.SaveChanges();

                return Results.Ok();
            }

            return Results.Redirect(Template);

            
        }

    }
}
