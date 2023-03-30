using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.infra.dados.Repositorios
{
    public class ProcessoTramitacaoRepositorio : BaseRepositorio<ProcessoTramitacao>, IProcessoTramitacaoRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public ProcessoTramitacaoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }

        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return contexto.ProcessoTramitacao.Where(a => a.Status == true).ToList();
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
            => contexto.ProcessoTramitacao
                .OrderByDescending(x => x.DataCriacao)
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
                .Include(a => a.UsuarioTramitacao)
                .AsNoTracking()
                .FirstOrDefault(x => x.NumeroProcesso.Equals(numeroProcesso));

        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
           => contexto.ProcessoTramitacao
                .Where(x => x.NumeroProcesso.Equals(numeroProcesso))
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
                .Include(a => a.UsuarioTramitacao)
                .AsNoTracking().ToList();
    }
}
