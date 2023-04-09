namespace SaborDoSertão.EndPoints.Admin.Usuarios
{
    public record UsuarioRequest (string Name, string Email, string Password, string Phone, string CPF);
    
}
