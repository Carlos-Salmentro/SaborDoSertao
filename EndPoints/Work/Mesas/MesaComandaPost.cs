using SaborDoSertão.EndPoints.Work.Comandas;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaComandaPost
    {
        public static string Template => "/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler => Action;
        public static Mesa mesa { get; private set; }


        public static IResult Action(ComandaRequest comandaRequest, int id, AppDBContext context)
        {
            mesa = context.Mesas.FirstOrDefault(x => x.Id == id);

            Comanda comanda = new Comanda(mesa.Id, comandaRequest.Identificador);

            mesa.Comanda.Add(comanda);

            mesa.Status = InfraEstrutura.Enum.Status.EmUso;
            context.SaveChangesAsync();
            return Results.CreatedAtRoute(Template);
        }
    }
}
