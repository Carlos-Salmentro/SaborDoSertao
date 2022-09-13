using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin
{
    public class ComandasMesaGetAll
    {
        public static string Template => "/Admin/Mesas";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action(AppDBContext context)
        {
            var mesas = context.Mesas.ToList();

            var response = mesas.Select(x => new MesaResponse { Id = x.Id, Status = x.Status, Valor = x.Valor });

            return Results.Ok(response);

        }
        
        public static void Redirect(Mesa mesa)
        {
            int id = mesa.Id;
            return HttpResponse.Redirect(Fechamento.Template);
        }

    }
}
