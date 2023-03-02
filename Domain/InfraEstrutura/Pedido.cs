using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace SaborDoSertão.InfraEstrutura
{
    [Table("PedidosTable")]
    public class Pedido
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("ComandaId")]
        public int ComandaId;
        [ForeignKey("NomeProduto")]
        public string NomeProduto { get; set; }
        [ForeignKey("ProdutoId")]
        public Guid ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public string? Observacao { get; set; }
        public double Valor { get; set; }
        public DateTime Data { get; set; }

        protected Pedido() { }

        public Pedido(int comandaId, Produto produto, int quantidade, string? observacao)
        {
            ComandaId = comandaId;
            ProdutoId = produto.Id;
            NomeProduto = produto.Nome;
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
