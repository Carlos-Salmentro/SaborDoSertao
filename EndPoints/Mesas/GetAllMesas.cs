using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Mesas
{
    public class GetAllMesas
    {
        public static string Template => "/GetMesas";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action(AppDBContext context)
        {
            var mesas = context.Mesas.ToList();
            var response = mesas.Select(x => new MesaResponse { MesaId = x.Id, Status = x.Status });

            return Results.Ok(response);
        }

    }
}
