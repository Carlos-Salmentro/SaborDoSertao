using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.EndPoints.Mesas;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaGet
    {
        public static string Template => "/Mesas/{id}";
        public static string[] Methods => new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler => Action;

        public static IResult Action([FromBody] int? id, [FromRoute] int? id2, AppDBContext context)
        {
            if (id == null && id2 == null)
            {
                return Results.BadRequest("É necessário informar o número da mesa.");
            }

            if (id2 == null)
            {
                var mesa = context.Mesas.FirstOrDefault(x => x.Id == id);
                
                if (mesa == null)
                    return Results.NotFound($"Nenhuma mesa com essa a numeração {id} encontrada");
                
                MesaResponse mesaSelecionada = new MesaResponse { MesaId = mesa.Id, Status = mesa.Status, Comanda = mesa.Comanda };

                return Results.Ok(mesaSelecionada);
            }

            else
            {
                var mesa = context.Mesas.FirstOrDefault(x => x.Id == id2);
                if (mesa == null)
                    return Results.NotFound($"Nenhuma mesa com essa a numeração {id2} encontrada");
                MesaResponse mesaSelecionada = new MesaResponse { MesaId = mesa.Id, Status = mesa.Status, Comanda = mesa.Comanda };

                return Results.Ok(mesaSelecionada);
            }
        }
    }
}
