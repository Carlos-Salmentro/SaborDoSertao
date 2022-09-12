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
            var comandas = context.ComandasTable.ToList().OrderBy(x => x.Identificador);
            return Results.Ok(comandas);
        }
    }
}
