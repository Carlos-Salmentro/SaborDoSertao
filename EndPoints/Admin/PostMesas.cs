using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin
{
    public class PostMesas
    {
        public static string Template => "/Admin/Mesas";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, [FromBody] MesasRequest request)
        {
            var mesa = new Mesa(request.Id);
            context.Mesas.Add(mesa);
            context.SaveChanges();

            //colocar no Template o URI do GetMesas
            return Results.Created(Template, mesa);
        }
    }
}
