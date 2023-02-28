using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Mesas
{
    public class MesasGetAll
    {
        public static string Template => "/Admin/Mesas";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action([FromServices] AppDBContext context)
        {
            List<Mesa> mesas = new List<Mesa>();

            foreach (Mesa mesa in context.Mesas)
            {
                mesas.Add(mesa);
            }

            return Results.Ok(mesas);

        }
    }
}
