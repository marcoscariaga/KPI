using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Servicos;


namespace SigProc.Servico.Configuracao
{
    public static class AplicacaoConfig
    {
        public static void AddApplicationConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUsuarioServico, UsuarioServico>();
            builder.Services.AddTransient<IGerenciaServico, GerenciaServico>();
            builder.Services.AddTransient<IProcessoServico, ProcessoServico>();
            builder.Services.AddTransient<ITipoContratacaoServico, TipoContratacaoServico>();
            builder.Services.AddTransient<ITipoProcessoServico, TipoProcessoServico>();
            builder.Services.AddTransient<IDadosDoProcessoSicopServico, DadosDoProcessoSicopServico>();
            builder.Services.AddTransient<IDadosDeTramitacaoSicopServico, DadosDeTramitacaoSicopServico>();

            builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
