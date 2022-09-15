using SaborDoSertão.EndPoints.Mesas;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesasGetAll
    {
        public static string Template => "/Mesas";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context)
        {
            var mesas = context.Mesas.Select(x => new MesaResponse { MesaId = x.Id, Comanda = x.Comanda, Status = x.Status });
            return Results.Ok(mesas);
        }

        public void SelectMesa(Mesa mesa, HttpResponse response)
        {
            var uri = Template + "/" + mesa.Id;

            response.Redirect(uri);
        }

    }
}
