using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.Domain.Enums;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.InfraNet;


namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class CaixaComandaPagamentoPut
    {
        public static string Template => "/Caixa/Pagamento/{comandaId}";
        public static string[] Methods = new string[] { HttpMethod.Put.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] int comandaId, [FromBody] PagamentoRequest pagamentoRequest, [FromServices] AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.Where(x => x.Ativa == true).FirstOrDefault(x => x.Id == comandaId);
            if (comanda == null)
            {
                return Results.NotFound("Nenhuma comanda com o Id: " + comandaId + " encontrada. \nSelecione novamente a comanda que deseja pagar.");
            }

            Pagamento pagamento = new Pagamento(comandaId, pagamentoRequest.FormaPagamento, pagamentoRequest.ValorPago);
            context.PagamentosTable.Add(pagamento);
            comanda.ValorPago += pagamentoRequest.ValorPago;
            comanda.ValorRestante -= pagamentoRequest.ValorPago;
            
            //testando se comanda foi totalmente paga
            if (comanda.ValorRestante <= 0.0)
            {
                comanda.Ativa = false;

                int? mesaId = comanda.MesaId;
                
                //testando se a mesa tem comanda atrelada para deixar disponivel ou nao
                if(mesaId != null)
                {
                    List<Comanda> comandas = new List<Comanda>(context.ComandasTable.Where(x => x.Ativa == true).Where(x => x.MesaId == mesaId));
                    comandas.Remove(comanda);

                    if(comandas.Count == 0)
                    {
                        Mesa mesa = context.Mesas.Single(x => x.Id == comanda.MesaId);
                        mesa.Status = Status.Disponivel;
                    }

                }

            }

            context.SaveChanges();

            return Results.Ok("Comanda: " + comanda.Id + "Pago: " + pagamentoRequest.ValorPago);
        }
    }
}
