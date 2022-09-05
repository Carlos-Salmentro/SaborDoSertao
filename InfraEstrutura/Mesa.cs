using SaborDoSertão.InfraEstrutura.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("Mesas")]
    public class Mesa
    {
        [Key]
        public int Id { get; set; }
        public Status Status { get; set; }
        public Comanda? Comanda { get; set; }
        public double Valor { get; set; }

        protected Mesa() { }

        public Mesa(int id)
        {
            Id = id;
            Status = Status.Disponivel;
            Valor = 0.0;
        }
    }
}
