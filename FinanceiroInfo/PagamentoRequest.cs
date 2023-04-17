using SaborDoSertão.FinanceiroInfo.Enum;

namespace SaborDoSertão.FinanceiroInfo
{
    public record PagamentoRequest(FormaPagamento FormaPagamento, double ValorPago)
    {
        //public FormaPagamento FormaPagamento { get; set; }
        //public double ValorPago { get; set; }

        //public PagamentoRequest(FormaPagamento formaPagamento, double valorPago) 
        //{
        //    FormaPagamento= formaPagamento;
        //    ValorPago= valorPago;
        //}
    }
}
