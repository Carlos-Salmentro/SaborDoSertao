using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa
{
    public class MesasGetAll
    {
        public static string Template => "/Caixa/Mesas";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action(AppDBContext context)
        {
            var mesas = context.Mesas.ToList();

            var response = mesas.Select(x => new MesaResponse { MesaId = x.Id, Status = x.Status, Comanda = x.Comanda});

            return Results.Ok(response);

        }

        public static void Redirect(MesaResponse mesa, HttpResponse response)
        {
            int id = mesa.MesaId;
            response.Redirect(Template + "/" + id);
        }
    }
}
