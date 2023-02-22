//using Microsoft.AspNetCore.Mvc;
//using SaborDoSertão.FinanceiroInfo;
//using SaborDoSertão.FinanceiroInfo.Enum;
//using SaborDoSertão.InfraEstrutura;
//using SaborDoSertão.InfraNet;

//namespace SaborDoSertão.EndPoints.Caixa.Mesas
//{
//    public class MesaComandaPagamentoPost
//    {
//        public static string Template => "/Caixa/Mesas/{id}/Comanda/{comandaId}/Pagamento";
//        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
//        public static Delegate Handler = Action;


//        public static IResult Action([FromRoute] int id, [FromRoute] int comandaId, AppDBContext context)
//        {
//            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
//            if (mesa == null)
//                return Results.NotFound(id);


//            Comanda comanda = mesa.Comanda.FirstOrDefault(x => x.Id == comandaId);
//            if (comanda == null)
//                return Results.NotFound(comandaId);

//            ComandaResponse comandaResponse = new ComandaResponse
//            {
//                Id = comanda.Id,
//                MesaId = comanda.MesaId,
//                Abertura = comanda.Abertura,
//                Fechamento = comanda.Fechamento,
//                Identificador = comanda.Identificador,
//                ValorPago = comanda.ValorPago,
//                ValorRestante = comanda.ValorRestante,
//                ValorTotal = comanda.ValorTotal
//            };

//            return Results.Ok(comandaResponse);
//        }

//        public static IResult ImprimirComanda([FromRoute] int comandaId, [FromServices] AppDBContext context)
//        {
//            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);

//            if (comanda == null)
//                return Results.NotFound();

//            //imprimirComanda

//            return Results.Ok();
//        }

//        public static IResult PagarTotal([FromRoute] int comandaId, [FromRoute] int id, [FromBody] FormaPagamento formaPagamento, [FromServices] AppDBContext context)
//        {
//            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);
//            double valorPagar = comanda.ValorRestante;

//            Fechamento fechamento = new Fechamento(formaPagamento, valorPagar);

//            comanda.FechamentoInfo.Add(fechamento);
//            comanda.Fechamento = DateTime.Now;
//            comanda.ValorPago += valorPagar;
//            comanda.ValorRestante -= valorPagar;

//            Financeiro financeiro = new Financeiro(comanda.Id, comanda.MesaId, comanda.Identificador, comanda.Abertura, comanda.Fechamento, comanda.ValorTotal, comanda.FechamentoInfo, comanda.ValorPago, comanda.ValorRestante);

//            //Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);               //PRECISA REMOVER OU BASTA REMOVER DO BD?? (PROXIMA LINHA) 
//            //mesa.Comanda.Remove(comanda);                                            //PRECISA REMOVER OU BASTA REMOVER DO BD?? (PROXIMA LINHA)

//            context.FinanceiroTable.Add(financeiro);
//            context.ComandasTable.Remove(comanda);

//            context.SaveChanges();

//            //imprimir comprovante de pagamento
//            return Results.Accepted(formaPagamento + ", " + valorPagar);

//        }

//        public static IResult PagarParcial([FromRoute] int comandaId, [FromRoute] int id, [FromBody] FormaPagamento formaPagamento, [FromBody] double valorAPagar, AppDBContext context)
//        {
//            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);
//            if (comanda == null)
//                return Results.NotFound(comandaId);

//            Fechamento fechamento = new Fechamento(formaPagamento, valorAPagar);

//            comanda.FechamentoInfo.Add(fechamento);
//            comanda.ValorPago += valorAPagar;
//            comanda.ValorRestante -= valorAPagar;

//            //imprimir comprovante de pagamento

//            if (comanda.ValorRestante <= 0)
//            {
//                comanda.Fechamento = DateTime.Now;

//                Financeiro financeiro = new Financeiro(comanda.Id, comanda.MesaId, comanda.Identificador, comanda.Abertura, comanda.Fechamento, comanda.ValorTotal, comanda.FechamentoInfo, comanda.ValorPago, comanda.ValorRestante);

//                //Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);                //PRECISA REMOVER OU BASTA REMOVER DO BD?? (PROXIMA LINHA)
//                //mesa.Comanda.Remove(comanda);                                             //PRECISA REMOVER OU BASTA REMOVER DO BD?? (PROXIMA LINHA)

//                context.ComandasTable.Remove(comanda);
//                context.FinanceiroTable.Add(financeiro);
//                context.SaveChanges();

//                return Results.Accepted(formaPagamento + ", " + valorAPagar);
//            }

//            context.SaveChanges();


//            return Results.Accepted(formaPagamento + ", " + valorAPagar + ", Pagamento Parcial");

//        }
//    }
//}
