using SaborDoSertão.Domain;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public Produto Produtos { get; set; }
        public int Quantidade { get; set; }
        public string? Observacao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        protected Pedido() { }

        public Pedido(Produto produtos, int quantidade, string? observacao)
        {
            Produtos = produtos;
            Quantidade = quantidade;
            Observacao = observacao;
            Data = DateTime.Now;
            Valor = produtos.Preco * quantidade;
        }
    }
}
