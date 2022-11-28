using SaborDoSertão.Domain.Enums;

namespace SaborDoSertão.EndPoints
{
    public record ProdutoResponse
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public double? Custo { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        public string? Descricao { get; set; }
        public Tamanho? Tamanho { get; set; }
        public int? QuantServe { get; set; }
    }
}
