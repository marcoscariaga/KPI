using Microsoft.EntityFrameworkCore;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Entidades;
using SigProc.Dominio.Servicos;
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

                if (tempoPrazo.diasUteisAtraso <= 0)
                {
                    processo.TempoPrazo = tempoPrazo.diasUteisRestantes;
                }
                else
                {
                    processo.TempoPrazo = (tempoPrazo.diasUteisRestantes * -1);
                }

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();

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

                if (tempoPrazo.diasUteisAtraso <= 0)
                {
                    processo.TempoPrazo = tempoPrazo.diasUteisRestantes;
                }
                else
                {
                    processo.TempoPrazo = (tempoPrazo.diasUteisRestantes * -1);
                }

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();

            }
            #endregion

            return contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).Include(a => a.Processo).ToList();
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            //#region Busca a ultima tramitação do processo e atualiza o tempo de prazo

            //var processo = contexto.ProcessoTramitacao
            //       .OrderByDescending(x => x.DataCriacao)
            //       .AsNoTracking()
            //       .FirstOrDefault(x => x.NumeroProcesso.Equals(numeroProcesso) && x.DataEnvio.Equals(null));

            //using var trans = contexto.Database.BeginTransaction();

            //var tempoPrazo = ContarDiasUteis(DateTime.Today, processo.DataPrazo);
            //processo.TempoPrazo = tempoPrazo;

            //if (tempoPrazo == 0)
            //{
            //    TimeSpan diferenca = (TimeSpan)(processo.DataPrazo - DateTime.Today);

            //    processo.TempoPrazo = diferenca.Days;

            //    contexto.Entry(processo).State = EntityState.Modified;
            //    contexto.SaveChanges();
            //    trans.Commit();

            //}
            //else
            //{
            //    processo.TempoPrazo = tempoPrazo;

            //    contexto.Entry(processo).State = EntityState.Modified;
            //    contexto.SaveChanges();
            //    trans.Commit();
            //}
            //#endregion


            return contexto.ProcessoTramitacao
                .OrderByDescending(x => x.DataCriacao)
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
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

                if (tempoPrazo.diasUteisAtraso <= 0)
                {
                    processo.TempoPrazo = tempoPrazo.diasUteisRestantes;
                }
                else
                {
                    processo.TempoPrazo = (tempoPrazo.diasUteisRestantes * -1);
                }

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();
            }
            #endregion

            return contexto.ProcessoTramitacao
                .Where(x => x.NumeroProcesso.Equals(numeroProcesso))
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
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

                if (tempoPrazo.diasUteisAtraso <= 0)
                {
                    processo.TempoPrazo = tempoPrazo.diasUteisRestantes;
                }
                else
                {
                    processo.TempoPrazo = (tempoPrazo.diasUteisRestantes * -1);
                }

                contexto.Entry(processo).State = EntityState.Modified;
                contexto.SaveChanges();
                trans.Commit();
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

                if (tempoPrazo.diasUteisAtraso <= 0)
                {
                    processo.TempoPrazo = tempoPrazo.diasUteisRestantes;
                }
                else
                {
                    processo.TempoPrazo  =(tempoPrazo.diasUteisRestantes * -1);
                }
             
                    contexto.Entry(processo).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();
             
            }
            return ultimasTramitacoes;
        }
        public virtual (int diasUteisRestantes, int diasUteisAtraso) ContarDiasUteis(DateTime dataInicial, DateTime? dataFinal)
        {
            var datasFeriados = ListarFeriados();

            DateTime dataAtual = dataInicial;
            DateTime dataVencimento = (DateTime)dataFinal;

            int diasUteisRestantes = 0;
            int diasUteisAtraso = 0;

            if (dataVencimento < dataAtual)
            {
                for (DateTime data = dataVencimento.Date.AddDays(1); data <= dataAtual; data = data.AddDays(1))
                {
                    if (data.DayOfWeek != DayOfWeek.Saturday && data.DayOfWeek != DayOfWeek.Sunday && !datasFeriados.Contains(data.Date))
                    {
                        diasUteisAtraso++;
                    }
                }
            }
            else
            {
                TimeSpan diff = dataVencimento - dataAtual;
                int diasTotais = diff.Days;

                for (int i = 1; i <= diasTotais; i++)
                {
                    DateTime data = dataAtual.AddDays(i);
                    if (data.DayOfWeek != DayOfWeek.Saturday && data.DayOfWeek != DayOfWeek.Sunday && !datasFeriados.Contains(data.Date))
                    {
                        diasUteisRestantes++;
                    }
                }
            }

            return (diasUteisRestantes, diasUteisAtraso);
        }
        public virtual (TimeSpan diasRestantes, DateTime dataFutura) CalculaPrazo(DateTime dataTramitacao, int prazo)
        {
            var datasFeriados = ListarFeriados();

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
            
            var dias = ContarDiasUteis(DateTime.Today,dataFutura);


            if (dias.diasUteisAtraso <= 0)
            {
                return (TimeSpan.FromDays(dias.diasUteisRestantes),(dataFutura));
            }
            else
            {
                return (TimeSpan.FromDays(dias.diasUteisAtraso * -1), dataFutura);
            }
        }
        public ICollection<DateTime> ListarFeriados()
        {
            // Cria uma lista para armazenar as datas dos feriados
            List<DateTime> datasFeriados = new List<DateTime>();

            // Faz a busca dos feriados e seleciona somente o campo "DataFeriado"
            var feriados = contexto.Feriado.Where(x => x.Status == true).Select(f => f.DataFeriado);

            // Adiciona as datas dos feriados à lista de datasFeriados
            datasFeriados.AddRange(feriados);

            // Imprime as datas dos feriados na lista
            foreach (DateTime dataFeriado in datasFeriados)
            {
                Console.WriteLine(dataFeriado.ToString("dd/MM/yyyy"));
            }

            return datasFeriados;
        }
    }
}

