using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;
using SaborDoSertão.Serviços.Produtos;

namespace SaborDoSertão.EndPoints.Admin.Produtos
{
    public class ProdutoPost
    {
        public static string Template => "/Admin/Produtos";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromBody]ProdutoRequest produtoRequest, [FromServices] AppDBContext context)
        {
            Produto produto = produtoRequest.ToProduto();

            context.ProdutosTable.Add(produto);
            context.SaveChanges();

            return Results.Created(Template + "/" + produto.Id, produto);
        }
}
}
