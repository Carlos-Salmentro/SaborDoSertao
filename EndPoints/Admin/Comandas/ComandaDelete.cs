using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Comandas
{
    public class ComandaDelete
    {
        public static string Template => "/Admin/Comandas/{comandaId}";
        public static string[] Methods = new string[] {HttpMethods.Delete.ToString()};
        public static Delegate Handler => Action;

        public static IResult Action([FromRoute]int comandaId, [FromServices] AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.Where(x => x.Ativa == true).Single(x => x.Id == comandaId);

            //Você tem certeza que deseja excluir essa comanda? A ação não poderá ser desfeita e todos os dados contidos nela serão perdidos. (S/N)
            //Solicitar senha para confirmação.

            context.ComandasTable.Remove(comanda);
            return Results.Ok("Comanda com id: " + comanda.Id + "apagada com sucesso.");
        }
    }
}
