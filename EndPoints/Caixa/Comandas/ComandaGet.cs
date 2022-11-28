using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class ComandaGet
    {
        public static string Template => "Caixa/Comanda/{id}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(int id, AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == id);

            if (comanda == null)
                return Results.NotFound(id);

            ComandaResponse comandaResponse = new ComandaResponse
            {
                Id = comanda.Id,
                MesaId = comanda.MesaId,
                Abertura = comanda.Abertura,
                Pedido = comanda.Pedido,
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
