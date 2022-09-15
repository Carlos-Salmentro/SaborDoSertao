using SaborDoSertão.FinanceiroInfo.Enum;

namespace SaborDoSertão.FinanceiroInfo
{
    public class Fechamento
    {
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
