using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.FinanceiroInfo.Enum;
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
        [ForeignKey("ComandaId")]
        public int ComandaId { get; set; }
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        [ForeignKey("FechamentoId")]
        public int FechamentoId { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public double ValorTotal { get; set; }
        
        protected Financeiro() { }

        public Financeiro(int comandaId, AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.SingleOrDefault(x => x.Id == comandaId);
            //List<Pagamento> pagamentos = context.PagamentosTable.Where(x => x.ComandaId == comanda.Id).ToList();

            
            
        }
    }
}