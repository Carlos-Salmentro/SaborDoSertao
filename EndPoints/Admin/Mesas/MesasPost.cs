﻿using Microsoft.AspNetCore.Mvc;
using SaborDoSertão.InfraNet;
using SaborDoSertão.Domain;

namespace SaborDoSertão.EndPoints.Admin.Mesas
{
    public class AdminMesasPost
    {
        public static string Template => "/Admin/Mesas";
        public static string[] Methods => new string[] { HttpMethod.Post.ToString() };
        public static Delegate Handler = Action;

        public static IResult Action(AppDBContext context, [FromBody] MesaRequest request)
        {
            Mesa mesa = new Mesa(request.MesaId);

            var teste = context.Mesas.FirstOrDefault(x => x.Id == request.MesaId);

            if (teste == null)
            {
                context.Mesas.Add(mesa);
                context.SaveChanges();

                //colocar no Template o URL do GetMesas
                return Results.Created(Template, mesa);
            }
            else
            {
                return Results.BadRequest("Já existe uma mesa com esse número.");
            }
        }
    }
}
