using SaborDoSertão.EndPoints;
using SaborDoSertão.EndPoints.Work.Mesas;
using SaborDoSertão.InfraEstrutura.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("Mesas")]
    public class Mesa
    {
        [Key]
        public int Id { get; set; }
        public Status Status { get; set; }
        public List<Comanda>? Comanda = new List<Comanda>();

        protected Mesa() { }

        public Mesa(int id)
        {
            Id = id;
            Status = Status.Disponivel;
        }

        public void AddComanda(ComandaRequest comanda)
        {
            Comanda comanda1 = new Comanda { Identificador = comanda.Identificador, Pedido = comanda.Pedido };
            Comanda.Add(comanda1);
        }

        public void AddComanda(Comanda comanda)
        {
            Comanda.Add(comanda);
        }

        public void AddComandaList(List<Comanda> comandas)
        {
            Comanda.AddRange(comandas);
        }
    }
}
