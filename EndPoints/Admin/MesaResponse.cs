using SaborDoSertão.InfraEstrutura.Enum;

namespace SaborDoSertão.EndPoints.Admin
{
    public class MesaResponse
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public double Valor { get; set; }
    }
}
