using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("Comandas")]
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Pedido> Pedido { get; set; } = new List<Pedido>();
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }

        public Comanda() { }
    
    }
}
