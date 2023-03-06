using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Mesas
{
    public class AdminMesasGetAll
    {
        public static string Template => "/Admin/Mesas";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action([FromServices] AppDBContext context)
        {
            List<MesaResponse> mesas = new List<MesaResponse>();

            foreach (Mesa mesa in context.Mesas)
            {
                MesaResponse mesaResponse= new MesaResponse {MesaId = mesa.Id, Status = mesa.Status };
                mesas.Add(mesaResponse);
            }

            return Results.Ok(mesas);

        }
    }
}
