using SaborDoSertão.Servicos;
using SaborDoSertão.InfraEstrutura.Enum;

namespace SaborDoSertão.InfraEstrutura
{
    public class Mesas
    {
        public Status Status;
        public int Numero;
        public List<Pedido> Pedidos;
        public double Valor;
    }

}
