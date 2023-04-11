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

            return Results.Ok(users);
        }
    }
}
