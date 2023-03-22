using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints
{
    public class ComandaResponse
    {
        public int Id { get; set; }
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }
        public double ValorTotal { get; set; }
        public double ValorPago { get; set; }
        public double ValorRestante { get; set; }
        public bool Ativa { get; set; }

        public ComandaResponse(Comanda comanda)
        {
            Id = comanda.Id;
            MesaId= comanda.MesaId;
            Identificador = comanda.Identificador;
            Abertura= comanda.Abertura;
            Fechamento= comanda.Fechamento;
            ValorTotal = comanda.ValorTotal;
            ValorPago = comanda.ValorPago;
            ValorRestante= comanda.ValorRestante;
            Ativa= comanda.Ativa;
        }
    }

    
}
