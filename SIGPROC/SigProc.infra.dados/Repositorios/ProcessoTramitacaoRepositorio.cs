using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.infra.dados.Contextos;
using SigProc.infra.dados.Repositorios;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            #region Buscar todos as tramitações ativas e atualiza o tempo de prazo

            var processos = contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).ToList();

            foreach (var processo in processos)
            {
                using var trans = contexto.Database.BeginTransaction();

                TimeSpan tempoPrazo = ((TimeSpan)(processo.DataPrazo - DateTime.Today));
                processo.TempoPrazo = tempoPrazo.Days;

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();
            }
            #endregion


            return contexto.ProcessoTramitacao.Where(a => a.Status == true).ToList();
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            #region Busca a ultima tramitação do processo e atualiza o tempo de prazo

            var processo = contexto.ProcessoTramitacao
                   .OrderByDescending(x => x.DataCriacao)
                   .AsNoTracking()
                   .FirstOrDefault(x => x.NumeroProcesso.Equals(numeroProcesso) && x.DataEnvio.Equals(null));

            using var trans = contexto.Database.BeginTransaction();

            TimeSpan tempoPrazo = ((TimeSpan)(processo.DataPrazo - DateTime.Today));
            processo.TempoPrazo = tempoPrazo.Days;

            contexto.Entry(processo).State = EntityState.Modified;
            contexto.SaveChanges();
            trans.Commit();
            #endregion


            return contexto.ProcessoTramitacao
                .OrderByDescending(x => x.DataCriacao)
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
                .Include(a => a.UsuarioTramitacao)
                .AsNoTracking()
                .FirstOrDefault(x => x.NumeroProcesso.Equals(numeroProcesso)); ;
        }
        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            #region Buscar todas as tramitações do processo e atualiza o tempo de prazo

            var processos = contexto.ProcessoTramitacao
                .Where(x => x.NumeroProcesso.Equals(numeroProcesso) && x.DataEnvio.Equals(null))
                .AsNoTracking().ToList();

            foreach (var processo in processos)
            {
                using var trans = contexto.Database.BeginTransaction();

                TimeSpan tempoPrazo = ((TimeSpan)(processo.DataPrazo - DateTime.Today));
                processo.TempoPrazo = tempoPrazo.Days;

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();
            }
            #endregion

            return contexto.ProcessoTramitacao
                .Where(x => x.NumeroProcesso.Equals(numeroProcesso))
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
                .Include(a => a.UsuarioTramitacao)
                .Include(a => a.Processo)
                .AsNoTracking().ToList();
        }
        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia)
        {
            var ultimasTramitacoes = contexto.ProcessoTramitacao
         .Where(pt => pt.IdOrgaoDestino == idGerencia)
         .GroupBy(pt => pt.IdProcesso)
         .Select(g => g.OrderByDescending(pt => pt.DataTramitacao).FirstOrDefault())
         .ToList();

            return ultimasTramitacoes;
        }
        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
           // substitua pelo ID do usuário desejado

            var ultimasTramitacoes = (from pt in contexto.ProcessoTramitacao
                                      join g in contexto.Gerencia on pt.IdOrgaoDestino equals g.Id
                                      where g.IdUsuarioResp == idUsuario
                                      && pt.DataTramitacao == (from pt2 in contexto.ProcessoTramitacao
                                                               where pt2.NumeroProcesso == pt.NumeroProcesso
                                                               group pt2 by pt2.NumeroProcesso into g
                                                               select g.Max(pt2 => pt2.DataTramitacao))
                                                               .FirstOrDefault()
                                      orderby pt.DataTramitacao descending
                                      select pt).Include(a => a.GerenciaOrigem)
                                                 .Include(a => a.GerenciaDestino)
                                                 .Include(a => a.UsuarioTramitacao)
                                                 .Include(a => a.Processo)
                                                 .ToList();

            return ultimasTramitacoes;
        }
    }
}
