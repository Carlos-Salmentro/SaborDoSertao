using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class ComandasGetAll
    {
        public static string Template => "Caixa/Comandas";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Hanlder = Action;

        public static IResult Action(AppDBContext context)
        {
            List<Comanda> comandas = context.ComandasTable.ToList();

            List<ComandaResponse> response = new List<ComandaResponse>();

            foreach (Comanda x in comandas)
            {
                ComandaResponse resp = new ComandaResponse
                {
                    Id = x.Id,
                    MesaId = x.MesaId,
                    Abertura = x.Abertura,
                    Fechamento = x.Fechamento,
                    Identificador = x.Identificador,
                };

                response.Add(resp);

            }

            return Results.Ok(response.OrderBy(x => x.MesaId == null).ThenBy(x => x.Identificador));
        }

        public static void SelecionarComanda(int id, HttpResponse response)
        {
            string url = Template + "/" + id;
            response.Redirect(url);
        }
    }
}

