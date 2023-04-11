using Microsoft.AspNetCore.Identity;

namespace SaborDoSertão.EndPoints.Admin.Usuarios
{
    public class AdminUsuarioPost
    {
        public static string Template => "Admin/Usuarios";
        public static string[] Methods = new string[] {HttpMethods.Post.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action(UsuarioRequest usuarioRequest, UserManager<IdentityUser> userManager)
        {
            IdentityUser user = new IdentityUser { Email= usuarioRequest.Email, UserName = usuarioRequest.Name, PhoneNumber = usuarioRequest.Phone };

            var result = userManager.CreateAsync(user, usuarioRequest.Password).Result;

            if(!result.Succeeded)
            {
                return Results.BadRequest(result.Errors.ToList());
            }

            return Results.Created(Template + user.Id, user.UserName);
        }
    }
}
