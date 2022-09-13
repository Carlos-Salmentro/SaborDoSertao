using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints.Work.Comandas;
using SaborDoSertão.InfraNet;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("ComandasTable")]
    public class Comanda
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? MesaId { get; set; }
        public string? Identificador { get; set; }
        public List<Pedido> Pedido { get; set; }
        public DateTime Abertura { get; set; }
        public DateTime Fechamento { get; set; }

        public Comanda() { }

        public Comanda(int mesaId, string? identificador)
        {
            MesaId = mesaId;
            Identificador = identificador;
            Abertura = DateTime.Now;
            Pedido = new List<Pedido>();
        }
        
        public Comanda(string identificador, int? mesaId)
        {
            MesaId = mesaId;
            Identificador = identificador;
            Abertura = DateTime.Now;
            Pedido = new List<Pedido>();
        }

        public ComandaResponse FindByMesaId(int mesaId, AppDBContext context)
        {
            var comanda = context.ComandasTable.FindAsync(MesaId, mesaId).Result;

            ComandaResponse response = new ComandaResponse
            {
                MesaId = comanda.MesaId,
                Identificador = comanda.Identificador,
                Abertura = comanda.Abertura,
                Fechamento = comanda.Fechamento,
                Pedido = comanda.Pedido
            };
            
            return response;
        }


        public ComandaResponse FindByIdentificador(string identificador, AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.FindAsync(Identificador, identificador).Result;

            ComandaResponse response = new ComandaResponse
            {
                MesaId = comanda.MesaId,
                Identificador = comanda.Identificador,
                Abertura = comanda.Abertura,
                Fechamento = comanda.Fechamento,
                Pedido = comanda.Pedido
            };

            return response;
        }


    }
}
