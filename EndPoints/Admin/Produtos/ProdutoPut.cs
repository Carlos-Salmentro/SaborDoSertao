using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Admin.Produtos
{
    public class ProdutoPut
    {
        public static string Template => "/Admin/Produtos/{id}";
        public static string[] Methods = { HttpMethods.Put.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromServices] AppDBContext context, [FromRoute] int id, [FromBody] ProdutoRequest produtoAlteracoes)
        {
            Produto produto = context.ProdutosTable.FirstOrDefault(x => x.Id == id);

            if (produto == null)
                return Results.NotFound(id);

            produto.Nome = produtoAlteracoes.Nome;
            produto.Tamanho = produtoAlteracoes.Tamanho;
            produto.Custo = produtoAlteracoes.Custo;
            produto.Preco = produtoAlteracoes.Preco;
            produto.Descricao = produtoAlteracoes.Descricao;
            produto.Categoria = produtoAlteracoes.Categoria;
            produto.QuantServe = produtoAlteracoes.QuantServe;

            context.SaveChanges();
            
            return Results.Accepted();
            
        }
    }
}
