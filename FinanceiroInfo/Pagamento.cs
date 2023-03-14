using SaborDoSertão.FinanceiroInfo.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.FinanceiroInfo
{
    [Table("PagamentosTable")]
    public class Pagamento
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("ComandaId")]
        public int ComandaId { get; set; }
        public FormaPagamento FormaDePagamento { get; set; }
        public double ValorPago { get; set; }

        private Pagamento() { }

        public Pagamento(int comandaId, FormaPagamento formaDePagamento, double valorPago)
        {
            ComandaId = comandaId;
            FormaDePagamento = formaDePagamento;
            ValorPago = valorPago;
        }
    }
}
