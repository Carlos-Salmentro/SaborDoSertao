﻿using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.Domain;
using SaborDoSertão.InfraNet;

namespace SaborDoSertão.EndPoints.Caixa.Comandas
{
    public class CaixaComandaGet
    {
        public static string Template => "Caixa/Comanda/{comandaId}";
        public static string[] Methods = new string[] { HttpMethod.Get.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action([FromRoute] int comandaId, AppDBContext context)
        {
            Comanda comanda = context.ComandasTable.FirstOrDefault(x => x.Id == comandaId);

            if (comanda == null)
                return Results.NotFound(comandaId);

            ComandaResponse comandaResponse = new ComandaResponse(comanda);

            return Results.Ok(comandaResponse);

        }
    }
}
