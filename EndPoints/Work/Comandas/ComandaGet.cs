using SaborDoSertão.InfraEstrutura;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Work.Comandas
{
    public class ComandaGet
    {
        public static string Template => "/Comandas/{identificador}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, string identificador)
        {
            if(identificador == null)
            {
                return Results.BadRequest("É necessário informar a identificação da comanda para acessa-la");
            }

            Comanda comanda  = context.ComandasTable.FirstOrDefault(x => x.Identificador == identificador);
            
            ComandaResponse comandaResponse = new ComandaResponse { Identificador = comanda.Identificador, Abertura = comanda.Abertura,
                MesaId = comanda.MesaId, Pedido = comanda.Pedido};

            return Results.Ok(comandaResponse);

        }

    }
}
