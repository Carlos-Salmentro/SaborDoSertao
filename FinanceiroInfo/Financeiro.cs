using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.FinanceiroInfo
{

    [Table("FinanceiroTable")]
    public class Financeiro
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public List<Comanda> Comandas = new List<Comanda>();

        protected Financeiro() { }

        public Financeiro(Comanda comanda)
        {
            Comandas.Add(comanda);
        }

        public Financeiro(List<Comanda> comandas)
        {
            Comandas.AddRange(comandas);
        }
    }
}