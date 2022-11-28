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
        public int IdentificacaoComanda { get; set; }
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        public List<Pedido> Pedido { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public double ValorTotal { get; set; }
        public List<Fechamento> FechamentoInfo { get; set; }

        protected Financeiro() { }

        public Financeiro(int identificacaoComanda, int? mesaId, string? identificador, List<Pedido> pedido, DateTime abertura, DateTime fechamento, double valorTotal, List<Fechamento> fechamentoInfo, double valorPago, double valorRestante)
        {
            IdentificacaoComanda = identificacaoComanda;
            MesaId = mesaId;
            Identificador = identificador;
            Pedido = pedido;
            Abertura = abertura;
            Fechamento = fechamento;
            ValorTotal = valorTotal;
            FechamentoInfo = fechamentoInfo;
        }
    }
}