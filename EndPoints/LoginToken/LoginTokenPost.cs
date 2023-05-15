using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Template;

namespace SaborDoSertão.EndPoints.LoginToken
{
    public class LoginTokenPost
    {
        public static string Template => "/login";
        public static string[] Methods => new[] {HttpMethods.Post.ToString()};
        public static Delegate Handler = Action;

        public static IResult Action(LoginRequest loginRequest, UserManager<IdentityUser> userManager)
        {

            return Results.Ok();
        }
    }
}
