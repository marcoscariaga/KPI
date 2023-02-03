using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Servicos;

namespace SigProc.Servico.Configuracao
{
    public static class AplicacaoConfig
    {
        public static void AddApplicationConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUsuarioServico, UsuarioServico>();
  

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
