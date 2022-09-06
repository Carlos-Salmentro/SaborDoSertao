using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints.Work
{
    public class PedidoRequest
    {
        public Produto Produtos { get; set; }
        public int Quantidade { get; set; }
        public string? Observacao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }
    }
}
