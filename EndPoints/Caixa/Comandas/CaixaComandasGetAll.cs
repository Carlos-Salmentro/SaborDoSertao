using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class CaixaComandasGetAll
    {
        public static string Template => "Caixa/Comandas";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Hanlder = Action;

        public static IResult Action(AppDBContext context)
        {
            List<Comanda> comandas = context.ComandasTable.Where(x => x.Ativa == true).ToList();

            List<ComandaResponse> response = new List<ComandaResponse>();

            foreach (Comanda comanda in comandas)
            {
                ComandaResponse comandaResponse = new ComandaResponse(comanda);

                response.Add(comandaResponse);
            }

            return Results.Ok(response.OrderBy(x => x.MesaId == null).ThenBy(x => x.Identificador));
        }
                
    }
}

