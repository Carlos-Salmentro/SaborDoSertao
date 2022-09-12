using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints.Work.Comandas;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class teste
    {
        public static IResult Action([FromRoute] int id, [FromBody] ComandaRequest? comandaRequest, [FromBody] List<PedidoRequest> pedidoRequest, AppDBContext context)
        {
            var mesa = context.Mesas.FirstOrDefault(x => x.Id == id);

            if (mesa == null)
                return Results.BadRequest("Nenhuma mesa encontrada com o número: " + id);

            if (mesa.Comanda == null || mesa.Comanda.Count == 0)
            {
                Comanda comanda1 = new Comanda { MesaId = mesa.Id, Identificador = comandaRequest.Identificador, Abertura = DateTime.Now };
                mesa.Comanda.Add(comanda1);

                foreach (PedidoRequest request in pedidoRequest)
                {
                    Pedido pedido = new Pedido(request.Produtos, request.Quantidade, request.Observacao);

                    comanda1.Pedido.Add(pedido);
                }

                mesa.Status = InfraEstrutura.Enum.Status.EmUso;

                context.SaveChanges();

                return Results.Ok(pedidoRequest);
            }

            else if (mesa.Comanda.Count > 1)
            {
                var comanda1 = mesa.Comanda.Find(x => x.Identificador == comandaRequest.Identificador);

                if (comanda1 == null)
                {
                    return Results.BadRequest($"Nenhuma comanda encontrada na mesa {id} com o identificador {}")
                }

                foreach (PedidoRequest request in pedidoRequest)
                {
                    Pedido pedido = new Pedido(request.Produtos, request.Quantidade, request.Observacao);

                    comanda1.Pedido.Add(pedido);
                }

                context.SaveChanges();
                return Results.Ok(pedidoRequest);
            }

            else
            {
                var comanda1 = mesa.Comanda.First();

                foreach (PedidoRequest request in pedidoRequest)
                {
                    Pedido pedido = new Pedido(request.Produtos, request.Quantidade, request.Observacao);

                    comanda1.Pedido.Add(pedido);
                }

                context.SaveChanges();
                return Results.Ok(pedidoRequest);

            }

        }
    }
}
