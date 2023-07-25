﻿namespace SigProc.Servico.Configurar
{
    public static class CorsConfig
    {
        public static void AddCorsSetup(WebApplicationBuilder builder)
        {
            builder.Services.AddCors(
                    s => s.AddPolicy("DefaultPolicy", builder =>
                    {
                        builder.AllowAnyOrigin() //qualquer dominio
                                .AllowAnyMethod() //qualquer método (POST, PUT, DELETE, GET...)
                                .AllowAnyHeader(); //qualquer parametro de cabeçalho
                    }
                    )
                );
        }
        public static void UseCorsSetup(WebApplication app)
        {
            app.UseCors("DefaultPolicy");
        }
    }
}
