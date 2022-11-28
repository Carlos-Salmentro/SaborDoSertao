using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.FinanceiroInfo;
using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Mesas
{
    public class MesaComandaPost
    {
        public static string Template => "/Mesas/{id}";
        public static string[] Methods = new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler => Action;
        
        public static IResult Action([FromRoute] int id, [FromBody] Comanda comanda, [FromServices] AppDBContext context)
        {
           Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);

            if(mesa == null)
                return Results.NotFound(id);

            Comanda comanda1 = new Comanda { Identificador = comanda.Identificador, MesaId = id, Abertura = DateTime.Now, 
                Pedido = new List<Pedido>(), ValorPago = 0.0, ValorRestante = 0.0, 
                FechamentoInfo = new List<Fechamento>(), ValorTotal = 0.0 };

            mesa.Comanda.Add(comanda1);

            mesa.Status = InfraEstrutura.Enum.Status.EmUso;
            
            context.ComandasTable.Add(comanda);
            
            context.SaveChangesAsync();
            
            return Results.Created(Template, comanda);

            //voltar para "/Mesas/{id}"
        }

        /*public static IResult TransferirComandasMesaParaMesa([FromRoute] int id, [FromBody] int id2, [FromBody] string? identificador, AppDBContext context)
        {
            Mesa mesa = context.Mesas.FirstOrDefault(x => x.Id == id);

            if (mesa == null)
                return Results.NotFound(id);

            if(mesa.Comanda.Count == 0)
                return Results.BadRequest("Nenhuma comanda para transferir na mesa " + id);

            if(identificador == null)
            {
                List<Comanda> comandaList = new List<Comanda>();
                comandaList.AddRange(mesa.Comanda);
                foreach(Comanda comanda in comandaList)
                {
                    comanda.MesaId = id2;
                }

                Mesa receptora = context.Mesas.FirstOrDefault(x => x.Id == id2);
                
                if (receptora == null)
                    return Results.BadRequest("Nenhuma mesa encontrada com número " + id2);
                
                receptora.AddComandaList(comandaList);
                receptora.Status = InfraEstrutura.Enum.Status.EmUso;
                
                mesa.Comanda.Clear();
                mesa.Status = InfraEstrutura.Enum.Status.Disponivel;

                context.SaveChanges();
                return Results.Redirect(MesasGetAll.Template + "/" + receptora.Id);
            }
            
            else
            {
                Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Identificador == identificador);
                if (comanda == null)
                    return Results.NotFound("Nenhuma comanda com o identificador " + identificador + "encontrada");

                Mesa receptora = context.Mesas.FirstOrDefault(x => x.Id == id2);
                if (receptora == null)
                    return Results.NotFound("Nenhuma mesa como númro " + id2 + "encontrada");

                comanda.MesaId = id2;
                receptora.Comanda.Add(comanda);
                
                if (receptora.Status == InfraEstrutura.Enum.Status.Disponivel)
                    receptora.Status = InfraEstrutura.Enum.Status.EmUso;

                mesa.Comanda.Remove(comanda);
                if (mesa.Comanda.Count == 0)
                    mesa.Status = InfraEstrutura.Enum.Status.Disponivel;

                context.SaveChanges();
                return Results.Redirect(MesasGetAll.Template + "/" + receptora.Id);
            }
        }*/
               
    }
}
