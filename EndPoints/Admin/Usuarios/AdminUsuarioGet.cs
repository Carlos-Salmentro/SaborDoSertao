using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace SaborDoSertão.EndPoints.Admin.Usuarios
{
    public class AdminUsuarioGet
    {
        public static string Template => "/Admin/Usuarios/{usuarioId}";
        public static string[] Methods = new string[] {HttpMethods.Get.ToString()};
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] string usuarioId, [FromServices] UserManager<IdentityUser> userManager)
        {
            Task user = userManager.FindByIdAsync(usuarioId);

            return Results.Ok(user);
        }
    }
}
