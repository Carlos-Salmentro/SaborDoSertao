using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraNet;
using System.Collections.Generic;
using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints.Caixa.Mesas
{
    public class CaixaMesasGetAll
    {
        public static string Template => "/Caixa/Mesas";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

       public static IResult Action(AppDBContext context)
        {
            List<Mesa> mesas = context.Mesas.ToList();

            return Results.Ok(mesas);
        }
    }
}
