using SaborDoSertão.Domain;
using SaborDoSertão.Domain.Enums;

namespace SaborDoSertão.EndPoints
{
    public record MesaResponse
    {
        public int MesaId { get; set; }
        public Status Status { get; set; }
    }
}
