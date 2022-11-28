using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa
{
    public class CaixaHome
    {
        public static string Template => "/Caixa";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context)
        {
            return Results.Ok();
        }

        public static void SelecionarMesas(HttpResponse response)
        {
            response.Redirect(Template + "/Mesas");
        }

        public static void SelecionarComandas(HttpResponse response)
        {
            response.Redirect(Template + "/Comandas");
        }
    }
}
