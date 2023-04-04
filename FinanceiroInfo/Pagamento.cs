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
        [Column("FormaDePagamento")]
        public FormaPagamento FormaDePagamento { get; set; }
        [Column("ValorPago")]
        public double ValorPago { get; set; }
        [Column("Data")]
        public DateTime Data { get; set; }

        private Pagamento() { }

        public Pagamento(int comandaId, FormaPagamento formaDePagamento, double valorPago)
        {
            ComandaId = comandaId;
            FormaDePagamento = formaDePagamento;
            ValorPago = valorPago;
            Data = DateTime.Now;
        }
    }
}
