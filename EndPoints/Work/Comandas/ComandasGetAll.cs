using SaborDoSertão.Domain;
using SaborDoSertão.EndPoints.Work.Mesas;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandasGetAll
    {
        public static string Template => "/Comandas";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context)
        {
            List<Comanda> comandas = context.ComandasTable.OrderBy(x => x.MesaId == null).OrderByDescending(x => x.Identificador).ToList();
            List<ComandaResponse> comandaResponse = new List<ComandaResponse>();
            
            foreach(Comanda comanda in comandas)
            {
                ComandaResponse comandaResponse1 = new ComandaResponse
                {
                    Id = comanda.Id,
                    Identificador = comanda.Identificador,
                    Abertura = comanda.Abertura,
                    Fechamento = comanda.Fechamento,
                    MesaId = comanda.MesaId,
                    ValorPago = comanda.ValorPago,
                    ValorRestante = comanda.ValorRestante,
                    ValorTotal = comanda.ValorTotal
                };
            }
            return Results.Ok(comandaResponse);
        }

        public static void Select(Comanda comanda, HttpResponse redirectResponse)
        {
            redirectResponse.Redirect(Template + "/" + comanda.Identificador);

        }

    }
}
