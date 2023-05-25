using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Routing.Template;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace SaborDoSertão.EndPoints.LoginToken
{
    public class LoginTokenPost
    {
        public static string Template => "/login";
        public static string[] Methods => new[] { HttpMethods.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(IConfiguration configuration, LoginRequest loginRequest, UserManager<IdentityUser> userManager)
        {
            IdentityUser user = userManager.FindByEmailAsync(loginRequest.Email).Result;
            if (user == null)
            {
                return Results.BadRequest($"Nenhum usuário com o e-mail {loginRequest.Email} encontrado.");
            }

            var check = userManager.CheckPasswordAsync(user, loginRequest.Senha).Result;
            if (!check)
            {
                return Results.BadRequest("Senha incorreta!");
            }

            byte[] key = Encoding.ASCII.GetBytes(configuration["JWT:MySecret"]);

            SecurityTokenDescriptor securityTokenDescriptor = new SecurityTokenDescriptor()
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.Name, user.NormalizedUserName)
                }),
                Expires = DateTime.UtcNow.AddHours(12),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = configuration["JWT:Issuer"],
                Audience = configuration["JWT:Audience"],
            };

            SecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(securityTokenDescriptor);


            return Results.Ok(new
            {
                token = tokenHandler.WriteToken(token)
            });
        }
    }
}
