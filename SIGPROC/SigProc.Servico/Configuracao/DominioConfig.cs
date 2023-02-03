using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Servicos;

namespace SigProc.Servico.Configuracao
{
    public static class DominioConfig
    {
        public static void AddDomainConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUsuarioDominioServico, UsuarioDominioServico>();
        }
    }
}
