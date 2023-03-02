using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.Domain.Enums;
using SaborDoSertão.EndPoints.Work.Mesas;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaPost
    {
        public static string Template => "/Comandas";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromBody] ComandaRequest comandaRequest, AppDBContext context)
        {
            Comanda comanda = new Comanda(comandaRequest.Identificador, comandaRequest.MesaId);

            if (comandaRequest.MesaId != null)
            {
                Mesa mesa = context.Mesas.Single(x => x.Id == comandaRequest.MesaId);
                mesa.Status = Status.EmUso;
            }

            context.ComandasTable.Add(comanda);
            context.SaveChanges();

            ComandaResponse comandaResponse = new ComandaResponse(comanda);

            return Results.Created(Template, comanda);
        }

        //public static IResult TransferirComandaParaMesa(string identificador, int id, AppDBContext context)
        //{
        //    Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Identificador == identificador);

        //    if(comanda == null)
        //        return Results.NotFound("Nenhuma comanda encontrada identificada como: " + identificador);

        //    Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);

        //    if(mesa == null)
        //    return Results.NotFound("Nenhuma mesa encontrada com o número: " + id);

        //    comanda.MesaId = id;
        //    mesa.Status = Status.EmUso;

        //    context.SaveChanges();
        //    string uri = MesasGetAll.Template + "/" + mesa.Id;
        //    return Results.Redirect(uri);
        //}
    }
}
