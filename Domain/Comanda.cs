using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.FinanceiroInfo.Enum;
using SaborDoSertão.InfraNet;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.Domain
{
    [Table("ComandasTable")]
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("MesaId")]
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public DateTime Abertura { get; set; } = DateTime.Now.ToLocalTime();
        public DateTime Fechamento { get; set; }
        public double ValorTotal { get; set; } = 0.0;
        public double ValorPago { get; set; } = 0.0;
        public double ValorRestante { get; set; } = 0.0;
        [Column("Ativa")]
        public bool Ativa { get; set; }

        public Comanda() { }

        public Comanda(int mesaId, string? identificador)
        {
            MesaId = mesaId;
            Identificador = identificador;
            Abertura = DateTime.Now;
            Ativa = true;

        }

        /*public Comanda(int mesaId, string? identificador)
        {
            MesaId = mesaId;
            Identificador = identificador;
            Abertura = DateTime.Now;
            Fechamento = null;
            Pedido = new List<Pedido>();
            FechamentoInfo = new List<Fechamento>();
            ValorTotal = 0.0;
            ValorPago = 0.0;
            ValorRestante = 0.0;
        }*/



        public Comanda(string identificador, int? mesaId)
        {
            MesaId = mesaId;
            Identificador = identificador;
            Abertura = DateTime.Now;
            Ativa = true;
        }

        //public ComandaResponse FindByMesaId(int mesaId, AppDBContext context)
        //{
        //    var comanda = context.ComandasTable.FindAsync(MesaId, mesaId).Result;

        //    ComandaResponse response = new ComandaResponse
        //    {
        //        MesaId = comanda.MesaId,
        //        Identificador = comanda.Identificador,
        //        Abertura = comanda.Abertura,
        //        Fechamento = comanda.Fechamento,
        //        Pedido = comanda.Pedido
        //    };

        //    return response;
        //}


        //public ComandaResponse FindByIdentificador(string identificador, AppDBContext context)
        //{
        //    Comanda comanda = context.ComandasTable.FindAsync(Identificador, identificador).Result;

        //    ComandaResponse response = new ComandaResponse
        //    {
        //        MesaId = comanda.MesaId,
        //        Identificador = comanda.Identificador,
        //        Abertura = comanda.Abertura,
        //        Fechamento = comanda.Fechamento,
        //        Pedido = comanda.Pedido
        //    };

        //    return response;
        //}

    }
}
