using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Comandas
{
    public class AdminComandasGet
    {
        public static string Template => "/Admin/Comandas";
        public static string[] Methods => new[] {HttpMethod.Get.ToString()};
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context)
        {
            List<Comanda> comandas= new List<Comanda>();

            comandas = context.ComandasTable.ToList();

            List<ComandaResponse> comandasResponse= new List<ComandaResponse>();

            foreach(Comanda comanda in comandas)
            {
                ComandaResponse comandaResponse = new ComandaResponse(comanda);
                comandasResponse.Add(comandaResponse);
            }

            return Results.Ok(comandasResponse);
        }
    }
}
