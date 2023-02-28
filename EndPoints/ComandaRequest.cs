using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints
{
    public class ComandaRequest
    {
        public int? Id;
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        public List<Pedido> Pedido { get; set; } = new List<Pedido>();
    }
}
