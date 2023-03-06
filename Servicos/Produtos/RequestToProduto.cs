using SaborDoSertão.Domain;
using SaborDoSertão.EndPoints;

namespace SaborDoSertão.Serviços.Produtos
{
    public static class ConversoesProduto
    {
        public static Produto ToProduto(this ProdutoRequest produtoRequest)
        {
            Produto produto = new Produto(produtoRequest.Nome, produtoRequest.Preco, produtoRequest.Categoria,
                produtoRequest.Tamanho, produtoRequest.QuantServe, produtoRequest.Custo, produtoRequest.Descricao);

            return produto;
        }

        public static ProdutoResponse ToProdutoResponse(this Produto produto)
        {
            ProdutoResponse produtoResponse = new ProdutoResponse { Id = produto.Id, Categoria = produto.Categoria, Custo = produto.Custo, 
                Descricao = produto.Descricao, Nome = produto.Nome, Preco = produto.Preco, 
                QuantServe = produto.QuantServe, Tamanho = produto.Tamanho};

            return produtoResponse;
        }

    }
}
