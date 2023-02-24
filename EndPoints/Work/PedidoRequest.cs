using SaborDoSertão.Domain;
using System.Text.Json.Serialization;

namespace SaborDoSertão.EndPoints.Work
{
    public class PedidoRequest
    {
        [JsonPropertyName("ProdutoId")]
        public Guid ProdutoId { get; set; }
        [JsonPropertyName("NomeProduto")]
        public string NomeProduto { get; set; }
        [JsonPropertyName("Quantidade")]
        public int Quantidade { get; set; }
        [JsonPropertyName("Observacao")]
        public string? Observacao { get; set; }
    }
}
