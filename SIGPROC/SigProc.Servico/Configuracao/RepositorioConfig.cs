using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Contratos.Dados;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;

namespace SigProc.Servico.Configuracao
{
    public static class RepositorioConfig
    {
        public static void AddRepositoryConfig(WebApplicationBuilder builder)
        {
            builder.Services.AddTransient<IUsuarioRepositorio, UsuarioRepositorio>();
            builder.Services.AddTransient<IGerenciaRepositorio, GerenciaRepositorio>();
            builder.Services.AddTransient<IGerenciaPrazoRepositorio, GerenciaPrazoRepositorio>();
            builder.Services.AddTransient<IGerenciaUsuarioRepositorio, GerenciaUsuarioRepositorio>();
            builder.Services.AddTransient<IProcessoRepositorio, ProcessoRepositorio>();
            builder.Services.AddTransient<IProcessoTramitacaoRepositorio, ProcessoTramitacaoRepositorio>();
            builder.Services.AddTransient<ITipoContratacaoRepositorio, TipoContratacaoRepositorio>();
            builder.Services.AddTransient<ITipoProcessoRepositorio, TipoProcessoRepositorio>();
            builder.Services.AddTransient<ITipoPrazoRepositorio, TipoPrazoRepositorio>();
            builder.Services.AddTransient<ITipoUsuarioGerenciaRepositorio, TipoUsuarioGerenciaRepositorio>();
            builder.Services.AddTransient<IDadosDoProcessoSicopRepositorio, DadosDoProcessoSicopRepositorio>();
            builder.Services.AddTransient<IDadosDeTramitacaoSicopRepositorio, DadosDeTramitacaoSicopRepositorio>();


            var connectionString = builder.Configuration.GetConnectionString("SIGPROC");
            builder.Services.AddDbContext<SqlServidorContexto>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
