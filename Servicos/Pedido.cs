using SaborDoSertão.Domain;
using SaborDoSertão.InfraEstrutura;

namespace SaborDoSertão.Servicos
{
    public class Pedido
    {
        
        public Produtos Produtos;
        public int Quantidade;
        public string? Observacao;
        public double Valor;

        public Pedido(Produtos produtos, int quantidade, string? observacao)
        {
            Produtos = produtos;
            Quantidade = quantidade;
            Observacao = observacao;
            Valor = produtos.Preco * quantidade;
        }
    }
}
