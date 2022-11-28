using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Produtos
{
    public class ProdutoDelete
    {
        public static string Template => "/Admin/Produtos/{id}";
        public static string[] Methods = new string[] { HttpMethod.Delete.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromServices]AppDBContext context, [FromRoute] int id)
        {
            Produto produto = context.ProdutosTable.FirstOrDefault(x => x.Id == id);

            if (produto == null)
                return Results.NotFound(id);

            context.ProdutosTable.Remove(produto);
            context.SaveChanges();

            return Results.Ok();
        }
    }
}
