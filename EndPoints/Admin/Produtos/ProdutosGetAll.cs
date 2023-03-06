using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;
using SaborDoSertão.Serviços.Produtos;

namespace SaborDoSertão.EndPoints.Admin.Produtos
{
    public class AdminProdutosGetAll
    {
        public static string Template => "/Admin/Produtos/{page}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromServices] AppDBContext context, [FromRoute] int page, [FromQuery] int rows)
        {
            List<Produto> produtos = new List<Produto>();
            List<ProdutoResponse> produtoResponse = new List<ProdutoResponse>();

            produtos = context.ProdutosTable.Skip((page - 1) * rows).Take(rows).ToList();

            foreach(Produto p in produtos)
            {
                ProdutoResponse response = p.ToProdutoResponse();
                produtoResponse.Add(response);
            }

            return Results.Ok(produtoResponse);
        }
    }
}
