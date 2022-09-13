using SaborDoSertão.InfraEstrutura;
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
            var comandas = context.ComandasTable.ToList().OrderBy(x => x.MesaId == null).OrderByDescending(x => x.Identificador);
                
            return Results.Ok(comandas);
        }

        public static void Select (Comanda comanda, HttpResponse redirectResponse)
        {
            redirectResponse.Redirect(Template + "/" + comanda.Identificador);
        }

    }
}
