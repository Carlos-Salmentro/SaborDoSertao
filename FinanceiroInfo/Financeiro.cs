using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.FinanceiroInfo
{

    [Table("FinanceiroInfo")]
    public class Financeiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public DateTime Data;
        public FormaPagamento FormaPagamento;
        public List<Comanda> Comandas = new List<Comanda>();
                        
        protected Financeiro() { }

    }
}