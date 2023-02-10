using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("ComandaId")]
        public int ComandaId;
        public Produto Produto { get; set; }
        public int Quantidade { get; set; }
        public string? Observacao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        protected Pedido() { }

        public Pedido(Produto produto, int quantidade, string? observacao)
        {
            Produto = produto;
            Quantidade = quantidade;
            Observacao = observacao;
            Data = DateTime.Now;
            Valor = produto.Preco * quantidade;
        }

        /*public Pedido([FromServices] AppDBContext context, int id, int quantidade, string? observacao)
        {
            Produtos = context.ProdutosTable.FirstOrDefault(x => x.Id == id);

            if (Produtos == null)
                throw new Exception("Produto não encontrado");

            Quantidade = quantidade;
            Observacao = observacao;
            Data = DateTime.Now;
            Valor = Produtos.Preco * quantidade;
        }*/
    }
}
