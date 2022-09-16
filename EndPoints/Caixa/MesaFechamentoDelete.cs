using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa
{
    public class MesaFechamentoDelete
    {
        public static string Template = "Caixa/Mesas/{id}";
        public static string[] Method = new string[] { HttpMethod.Delete.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, [FromRoute] int id)
        {
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            if(mesa == null)
            {
                return Results.NotFound(id);
            }

            //Definir valor total de cada comanda
            foreach(Comanda comanda in mesa.Comanda)
            {
                
            }
        }

    }
}
