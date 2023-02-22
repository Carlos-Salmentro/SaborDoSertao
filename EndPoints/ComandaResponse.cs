using SaborDoSertão.InfraEstrutura;

namespace SaborDoSertão.EndPoints
{
    public class ComandaResponse
    {
        public int Id;
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        //public List<Pedido> Pedido { get; set; } = new List<Pedido>();
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public double ValorTotal;
        public double ValorPago;
        public double ValorRestante;
    }
}
