using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using SigProc.Infra.Seguranca.Contexto;
using SigProc.Infra.Seguranca.Servico;
using System.Text;

namespace SigProc.Servico.Configuracao
{
    public static class AutenticacaoConfig
    {
        public static void AddAuthenticationSetup(WebApplicationBuilder builder)
        {

            var settingsSection = builder.Configuration.GetSection("AppSettings");
            builder.Services.Configure<AppConfig>(settingsSection);

            var appSettings = settingsSection.Get<AppConfig>();
            var key = Encoding.ASCII.GetBytes(appSettings.SecurityKey);

            builder.Services.AddAuthentication(
                auth =>
                {
                    auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                    auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                })
                .AddJwtBearer(
                    bearer =>
                    {
                        bearer.RequireHttpsMetadata = false;
                        bearer.SaveToken = true;
                        bearer.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(key),
                            ValidateIssuer = false,
                            ValidateAudience = false
                        };
                    }
                );
            builder.Services.AddTransient(t => new TokenServico(appSettings));
        }
    }
}
