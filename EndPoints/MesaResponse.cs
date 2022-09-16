using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraEstrutura.Enum;

namespace SaborDoSertão.EndPoints
{
    public class MesaResponse
    {
        public int MesaId { get; set; }
        public Status Status { get; set; }
        public List<Comanda>? Comanda;
    }
}
