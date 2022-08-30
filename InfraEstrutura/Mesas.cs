using SaborDoSertão.Servicos;
using SaborDoSertão.InfraEstrutura.Enum;

namespace SaborDoSertão.InfraEstrutura
{
    public class Mesas
    {
        public int Id;
        public Status Status;
        public List<Pedido> Pedidos = new List<Pedido>();
        public double Valor;
    }

}
