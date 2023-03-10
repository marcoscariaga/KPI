using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Contratos.Dados;
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
            builder.Services.AddTransient<IProcessoRepositorio, ProcessoRepositorio>();
            builder.Services.AddTransient<ITipoContratacaoRepositorio, TipoContratacaoRepositorio>();
            builder.Services.AddTransient<ITipoProcessoRepositorio, TipoProcessoRepositorio>();

            var connectionString = builder.Configuration.GetConnectionString("SIGPROC");
            builder.Services.AddDbContext<SqlServidorContexto>
                (options => options.UseSqlServer(connectionString));
        }
    }
}
