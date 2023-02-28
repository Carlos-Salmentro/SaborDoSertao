using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain.Enums;
using SaborDoSertão.EndPoints;
using SaborDoSertão.EndPoints.Work.Mesas;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.Domain
{
    [Table("Mesas")]
    public class Mesa
    {
        [Key]
        public int Id { get; set; }
        public Status Status { get; set; }
        
        protected Mesa() { }

        public Mesa(int id)
        {
            Id = id;
            Status = Status.Disponivel;
        }






    }
}
