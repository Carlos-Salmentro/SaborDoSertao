using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints;
using SaborDoSertão.EndPoints.Work.Mesas;
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
        public List<Comanda>? Comanda = new List<Comanda>();

        protected Mesa() { }

        public Mesa(int id)
        {
            Id = id;
            Status = Status.Disponivel;
        }

        

        

        
    }
}
