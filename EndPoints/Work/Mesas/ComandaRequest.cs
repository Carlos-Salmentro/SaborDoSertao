using SaborDoSertão.InfraEstrutura;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class ComandaRequest
    {
        public string? Identificador { get; set; }
        public List<Pedido> Pedido { get; set; } = new List<Pedido>();
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
    }
}
