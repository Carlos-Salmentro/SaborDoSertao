using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class ComandasMesaGet
    {
        public static string Template => "/Mesas/{id}/Comandas";
        public static string[] Methods = new string[] { (HttpMethod.Get.ToString()) };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, int id)
        {
            var list = context.Mesas.FindAsync()
            List<Comanda> lista = new List<Comanda>
        }
    }
}
