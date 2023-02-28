using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Mesas
{
    public class MesasGetAll
    {
        public static string Template => "/Caixa/Mesas";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action([FromServices]AppDBContext context)
        {
            var mesas = context.Mesas.ToList();

            var response = mesas.Select(x => new MesaResponse { MesaId = x.Id, Status = x.Status});

            return Results.Ok(response);

        }

        public static void Redirect(int id /*MesaResponse response */, HttpResponse response)
        {
           response.Redirect(Template + "/" + id);
        }
    }
}
