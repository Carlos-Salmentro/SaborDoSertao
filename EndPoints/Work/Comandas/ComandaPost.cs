using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints.Work.Mesas;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaPost
    {
        public static string Template => "/Comandas";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromBody] string identificador, int? mesaId, AppDBContext context)
        {
            Comanda comanda = new Comanda(identificador, mesaId);
            
            context.ComandasTable.Add(comanda);
            context.SaveChanges();

            return Results.RedirectToRoute(Template + "/" + identificador);
        }

        public static IResult TransferirComandaParaMesa(string identificador, int id, AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Identificador == identificador);
            
            if(comanda == null)
                return Results.NotFound("Nenhuma comanda encontrada identificada como: " + identificador);
                           
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
            
            if(mesa == null)
            return Results.NotFound("Nenhuma mesa encontrada com o número: " + id);

            comanda.MesaId = id;
            mesa.Status = InfraEstrutura.Enum.Status.EmUso;

            context.SaveChanges();
            string uri = MesasGetAll.Template + "/" + mesa.Id;
            return Results.Redirect(uri);
        }
    }
}
