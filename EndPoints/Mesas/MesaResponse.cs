using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraEstrutura.Enum;

namespace SaborDoSertão.EndPoints.Mesas
{
    public class MesaResponse
    {
        public int MesaId { get; set; }
        public Status Status {get; set;}
        public Comanda? Comanda;
    }
}
