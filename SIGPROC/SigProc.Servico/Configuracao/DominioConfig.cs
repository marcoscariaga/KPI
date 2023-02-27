using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Servicos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Servicos;

namespace SigProc.Servico.Configuracao
{
    public static class DominioConfig
    {
        public static void AddDomainConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUsuarioDominioServico, UsuarioDominioServico>();
            builder.Services.AddTransient<IGerenciaDominioServico, GerenciaDominioServico>();
            builder.Services.AddTransient<ITipoContratacaoDominioServico, TipoContratacaoDominioServico>();
            builder.Services.AddTransient<ITipoProcessoDominioServico, TipoProcessoDominioServico>();
        }
    }
}
