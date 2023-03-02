using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints
{
    public class ComandaRequest
    {
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
    }
}
