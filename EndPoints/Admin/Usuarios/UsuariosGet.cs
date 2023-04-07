namespace SaborDoSertão.EndPoints.Admin.Usuarios
{
    public class UsuariosGet
    {
        public static string Template => "/admin/usuarios";
        public static string[] Methods => new[] {HttpMethods.Get};
        public static Delegate Handler => Action;

        public static IResult Action(string id)
        {
            return Results.Ok();
        }
    }
}
