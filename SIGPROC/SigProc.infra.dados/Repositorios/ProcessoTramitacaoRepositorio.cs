using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Contratos.Dados;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SigProc.infra.dados.Repositorios
{
    public class ProcessoTramitacaoRepositorio : BaseRepositorio<ProcessoTramitacao>, IProcessoTramitacaoRepositorio
    {
        private readonly SqlServidorContexto contexto;

        public ProcessoTramitacaoRepositorio(SqlServidorContexto sqlServerContext) : base(sqlServerContext)
        {
            contexto = sqlServerContext;
        }
        public ICollection<ProcessoTramitacao> ListarTudo()
        {
            #region Buscar todos as tramitações ativas e atualiza o tempo de prazo

            var processos = contexto.ProcessoTramitacao.ToList();

            foreach (var processo in processos)
            {
                using var trans = contexto.Database.BeginTransaction();

                var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
                if (tempoPrazo == 0)
                {
                    TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

                    processo.TempoPrazo = diferenca.Days;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();

                }
                else
                {
                    processo.TempoPrazo = tempoPrazo;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();
                }

            }
            #endregion

            return contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).Include(a => a.Processo).ToList();
        }
        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            #region Buscar todos as tramitações ativas e atualiza o tempo de prazo

            var processos = contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).ToList();

            foreach (var processo in processos)
            {
                using var trans = contexto.Database.BeginTransaction();

                var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
                if (tempoPrazo == 0)
                {
                    TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

                    processo.TempoPrazo = diferenca.Days;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();

                }
                else
                {
                    processo.TempoPrazo = tempoPrazo;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();
                }
              
            }
            #endregion

            return contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).Include(a => a.Processo).ToList();
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            #region Busca a ultima tramitação do processo e atualiza o tempo de prazo

            var processo = contexto.ProcessoTramitacao
                   .OrderByDescending(x => x.DataCriacao)
                   .AsNoTracking()
                   .FirstOrDefault(x => x.NumeroProcesso.Equals(numeroProcesso) && x.DataEnvio.Equals(null));

            using var trans = contexto.Database.BeginTransaction();

            var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
            processo.TempoPrazo = tempoPrazo;

            if (tempoPrazo == 0)
            {
                TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

                processo.TempoPrazo = diferenca.Days;

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();

            }
            else
            {
                processo.TempoPrazo = tempoPrazo;

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();
            }
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

                var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
                if (tempoPrazo == 0)
                {
                    TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

                    processo.TempoPrazo = diferenca.Days;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();

                }
                else
                {
                    processo.TempoPrazo = tempoPrazo;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();
                }
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
            #region Buscar todas as tramitações do processo e atualiza o tempo de prazo

            var processos = contexto.ProcessoTramitacao
                .Where(x => x.IdOrgaoDestino.Equals(idGerencia) && x.DataEnvio.Equals(null))
                .AsNoTracking().ToList();

            foreach (var processo in processos)
            {
                using var trans = contexto.Database.BeginTransaction();

                var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
                if (tempoPrazo == 0)
                {
                    TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

                    processo.TempoPrazo = diferenca.Days;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();

                }
                else
                {
                    processo.TempoPrazo = tempoPrazo;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();
                }
            }
            #endregion

            var ultimasTramitacoes = contexto.ProcessoTramitacao
          .Include(pt => pt.Processo)
              .Where(pt => pt.IdOrgaoDestino == idGerencia && pt.DataEnvio.Equals(null))
              .GroupBy(pt => pt.IdProcesso)
              .Select(g => g.OrderByDescending(pt => pt.DataTramitacao).FirstOrDefault())
          .ToList();

            return ultimasTramitacoes;
        }
        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
            var ultimasTramitacoes = contexto.ProcessoTramitacao
          .Include(pt => pt.Processo)
              .Where(pt => pt.IdOrgaoDestino == idUsuario && pt.DataEnvio.Equals(null))
              .GroupBy(pt => pt.IdProcesso)
              .Select(g => g.OrderByDescending(pt => pt.DataTramitacao).FirstOrDefault())
          .ToList();


            foreach (var processo in ultimasTramitacoes)
            {
                using var trans = contexto.Database.BeginTransaction();

                var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
                if(tempoPrazo == 0)
                {
                    TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

                    processo.TempoPrazo = diferenca.Days;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();

                }
                else{
                    processo.TempoPrazo = tempoPrazo;

                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();
                }
             
            }
            return ultimasTramitacoes;
        }

        public virtual int ContarDiasUteis(DateTime dataInicial, DateTime? dataFinal)
        {
            var datasFeriados = BucarFeriados();

            int diasUteis = 0;

            while (dataInicial < dataFinal)
            {
                if (dataInicial.DayOfWeek != DayOfWeek.Saturday && dataInicial.DayOfWeek != DayOfWeek.Sunday && !datasFeriados.Contains(dataInicial))
                {
                    diasUteis++;
                }
                dataInicial = dataInicial.AddDays(1);
            }

            return diasUteis;
        }
        public virtual TimeSpan CalculaPrazo(DateTime dataTramitacao, int prazo)
        {
            var datasFeriados = BucarFeriados();

            int diasParaAcrescentar = prazo;

            DateTime dataFutura = dataTramitacao;
            int diasAcrescentados = 0;
            while (diasAcrescentados < diasParaAcrescentar)
            {
                dataFutura = dataFutura.AddDays(1);
                if (dataFutura.DayOfWeek != DayOfWeek.Saturday && dataFutura.DayOfWeek != DayOfWeek.Sunday && !datasFeriados.Contains(dataFutura))
                {
                    diasAcrescentados++;
                }
            }
            var data = dataFutura - dataTramitacao;

            return data;
        }
        public virtual ICollection<DateTime> BucarFeriados()
        {
            List<DateTime> datasFeriados = new List<DateTime>();

            var feriados = contexto.Feriado.Where(x => x.DataFeriado >= DateTime.Today && x.Status == true).Select(f => f.DataFeriado);
            datasFeriados.AddRange(feriados);

            foreach (DateTime dataFeriado in datasFeriados)
            {
                Console.WriteLine(dataFeriado.ToString("dd/MM/yyyy"));
            }

            return datasFeriados;
        }
    }
}

