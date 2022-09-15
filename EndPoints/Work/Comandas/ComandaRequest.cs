using SaborDoSertão.InfraEstrutura;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaRequest
    {
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        public List<Pedido> Pedido { get; set; } = new List<Pedido>();
    }
}
