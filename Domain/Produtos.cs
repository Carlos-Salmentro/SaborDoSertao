using SaborDoSertão.Domain.Enums;
using SaborDoSertão.EndPoints;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SaborDoSertão.Domain
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Nome { get; set; }
        public double? Custo { get; set; }
        public double Preco { get; set; }
        public Categoria Categoria { get; set; }
        public string? Descricao { get; set; }
        public Tamanho? Tamanho { get; set; }
        public int? QuantServe { get; set; }

        protected Produto() { }

        public Produto(int id, string nome, double preco, Categoria categoria, Tamanho? tamanho, int? quantServe, double? custo, string? descricao)
        {
            Id = id;
            Nome = nome;
            Preco = preco;
            Categoria = categoria;
            Custo = custo;
            Descricao = descricao;
            Tamanho = tamanho;
            QuantServe = quantServe;
        }

        }
}
