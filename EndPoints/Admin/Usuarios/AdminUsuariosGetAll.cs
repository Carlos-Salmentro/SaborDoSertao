using Microsoft.AspNetCore.Identity;

namespace SaborDoSertão.EndPoints.Admin.Usuarios
{
    public class AdminUsuariosGetAll
    {
        public static string Template => "/Admin/Usuarios";
        public static string[] Methods => new[] {HttpMethods.Get.ToString()};
        public static Delegate Handler => Action;

        public static IResult Action(UserManager<IdentityUser> userManager)
        {
            List<IdentityUser> users = userManager.Users.ToList();
            List<UsuarioResponse> usuarioResponses = new List<UsuarioResponse>(users.Select(x => new UsuarioResponse (x.UserName, x.Email )));

            return Results.Ok(usuarioResponses);
        }
    }
}
