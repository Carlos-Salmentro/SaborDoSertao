using SaborDoSertão.FinanceiroInfo.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.FinanceiroInfo
{
    public class Fechamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public FormaPagamento FormaDePagamento { get; set; }
        public double ValorPago { get; set; }

        private Fechamento() { }

        public Fechamento(FormaPagamento formaDePagamento, double valorPago)
        {
            FormaDePagamento = formaDePagamento;
            ValorPago = valorPago;
        }
    }
}
