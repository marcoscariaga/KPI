using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Servicos;
using SigProc.Domimio.Contratos.Servicos;
using SigProc.Domimio.Entidades;
using SigProc.Domimio.Servicos;
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
            builder.Services.AddTransient<IGerenciaPrazoDominioServico, GerenciaPrazoDominioServico>();
            builder.Services.AddTransient<IGerenciaUsuarioDominioServico, GerenciaUsuarioDominioServico>();
            builder.Services.AddTransient<IProcessoDominioServico, ProcessoDominioServico>();
            builder.Services.AddTransient<IProcessoTramitacaoDominioServico, ProcessoTramitacaoDominioServico>();
            builder.Services.AddTransient<ITipoContratacaoDominioServico, TipoContratacaoDominioServico>();
<<<<<<< HEAD
            builder.Services.AddTransient<IParaContratacaoDominioServico, ParaContratacaoDominioServico>();
            builder.Services.AddTransient<IInstrumentosAuxiliaresDominioServico, InstrumentosAuxiliaresDominioServico>();
=======
>>>>>>> parent of c480f34 (Alteração conforme documento)
            builder.Services.AddTransient<ITipoProcessoDominioServico, TipoProcessoDominioServico>();
            builder.Services.AddTransient<IEtapaProcessoDominioServico, EtapaProcessoDominioServico>();
            builder.Services.AddTransient<IStatusProcessoDominioServico, StatusProcessoDominioServico>();
            builder.Services.AddTransient<ITipoPrazoDominioServico, TipoPrazoDominioServico>();
            builder.Services.AddTransient<ITipoUsuarioGerenciaDominioServico, TipoUsuarioGerenciaDominioServico>();
            builder.Services.AddTransient<IDadosDoProcessoSicopDominioServico, DadosDoProcessoSicopDominioServico>();
            builder.Services.AddTransient<IDadosDeTramitacaoSicopDominioServico, DadosDeTramitacaoSicopDominioServico>(); 
            builder.Services.AddTransient<IFeriadoDominioServico, FeriadoDominioServico>();
            builder.Services.AddTransient<IDespachoDominioServico, DespachoDominioServico>();
            builder.Services.AddTransient<IMensagemDominioServico, MensagemDominioServico>();
        }
    }
}
