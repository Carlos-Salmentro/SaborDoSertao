using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Mesas
{
    public class AdminMesasDelete
    {
        public static string Template => "/Admin/Mesas/{id}";
        public static string[] Methods => new string[] { HttpMethods.Delete.ToString() };
        public static Delegate Handler = Action;


        public static IResult Action([FromRoute] int id, AppDBContext context)
        {
            var mesa = context.Mesas.FirstOrDefault(x => x.Id == id);

            if (mesa == null)
            {
                return Results.NotFound(id);
            }

            context.Mesas.Remove(mesa);
            context.SaveChanges();
            return Results.Ok("Mesa de número " + id + " excluida");

        }
    }
}
