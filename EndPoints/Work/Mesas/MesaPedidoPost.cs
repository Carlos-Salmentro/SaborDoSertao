using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints.Work.Comandas;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaPedidoPost
    {
        public static string Template => "/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        

    }
}
