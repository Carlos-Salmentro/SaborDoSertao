using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints.Work
{
    public class PedidoRequest
    {
        public Guid ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string? Observacao { get; set; }
                
    }
}
