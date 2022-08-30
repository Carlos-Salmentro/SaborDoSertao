using SaborDoSertão.Domain.Enums;

namespace SaborDoSertão.Domain
{
    public abstract class Produtos
    {
        public string Nome;
        public double? Custo;
        public double Preco;
        public Categoria Categoria;
        public string? Descricao;
        public Tamanho? Tamanho;
        public int? QuantServe;
        public string? Observacao;
        public Produtos(string nome, double preco, Categoria categoria, Tamanho? tamanho, int? quantServe, double? custo, string? descricao, string? observacao)
        {
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
            Custo = custo;
            Descricao = descricao;
            Tamanho = tamanho;
            QuantServe = quantServe;
            Observacao = observacao;
        }
    }
}
