using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;
using System.Web.Http;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaPost
    {
        public static string Template => "/Comandas";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromBody] string identificador, int? mesaId, AppDBContext context)
        {
            Comanda comanda = new Comanda(identificador, mesaId);
            
            context.ComandasTable.Add(comanda);
            context.SaveChanges();

            return Results.RedirectToRoute(Template + "/" + identificador);
        }
    }
}
