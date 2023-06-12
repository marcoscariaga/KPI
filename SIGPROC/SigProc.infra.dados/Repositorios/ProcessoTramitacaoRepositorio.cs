using Microsoft.EntityFrameworkCore;
using Serilog;
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
            return contexto.ProcessoTramitacao.Where(a => a.Status == true).Include(a => a.Processo).Include(a => a.Processo.StatusProcesso).Include(a => a.EtapaProcesso).ToList();
        }
        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).Include(a => a.Processo).Include(a => a.Processo.StatusProcesso).Include(x => x.GerenciaDestino).Include(a => a.GerenciaOrigem).Include(a => a.EtapaProcesso).ToList();
        }
        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            return contexto.ProcessoTramitacao
                            .OrderByDescending(x => x.DataCriacao)
                            .Include(a => a.GerenciaOrigem)
                            .Include(a => a.GerenciaDestino)
                            .Include(a => a.EtapaProcesso)
                            .Include(a => a.Processo)
                            .Include(a => a.Processo.StatusProcesso)
                            .AsNoTracking()
                            .FirstOrDefault(x => x.NumeroProcesso.Equals(numeroProcesso));
        }
        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            return contexto.ProcessoTramitacao
                .Where(x => x.NumeroProcesso.Equals(numeroProcesso))
                .OrderByDescending(x=> x.Sequencia)
                .Include(a => a.GerenciaOrigem)
                .Include(a => a.GerenciaDestino)
                .Include(a => a.Processo)
                .Include(a => a.Processo.StatusProcesso)
                .Include(a => a.EtapaProcesso)
                .AsNoTracking().ToList();
        }
        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia)
        {
            var ultimasTramitacoes = contexto.ProcessoTramitacao
        .Include(pt => pt.Processo).Include(a => a.Processo.StatusProcesso).Include(a => a.EtapaProcesso)
        .Where(pt => pt.IdOrgaoDestino == idGerencia && pt.DataEnvio.Equals(null))
        .GroupBy(pt => pt.IdProcesso)
        .Select(g => g.OrderByDescending(pt => pt.DataTramitacao).FirstOrDefault())
        .ToList();
            return ultimasTramitacoes;
        }
        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
            var ultimasTramitacoes = contexto.ProcessoTramitacao
        .Include(pt => pt.Processo).Include(a => a.Processo.StatusProcesso).Include(x => x.GerenciaOrigem).Include(x => x.GerenciaDestino).Include(a => a.EtapaProcesso)
        .Where(pt => pt.DataEnvio.Equals(null))
        .ToList();

            return ultimasTramitacoes;
        }
        public void AtualizaPazo()
        {
            #region Buscar todos as tramitações ativas e atualiza o tempo de prazo
            try
            {
                var tramitacoes = contexto.ProcessoTramitacao.Where(a => a.Status == true && a.DataEnvio == null).ToList();

                foreach (var tramitacao in tramitacoes)
                {
                    using var trans = contexto.Database.BeginTransaction();

                    var tempoPrazo = ContarDiasUteis(DateTime.Today, tramitacao.DataPrazo);

                    if (tempoPrazo.diasUteisAtraso <= 0)
                    {
                        tramitacao.TempoPrazo = tempoPrazo.diasUteisRestantes;
                    }
                    else
                    {
                        tramitacao.TempoPrazo = (tempoPrazo.diasUteisAtraso * -1);
                    }

                    contexto.Entry(tramitacao).State = EntityState.Modified;
                    contexto.SaveChanges();
                    trans.Commit();

                }
                Log.ForContext("Acao", $"AtualizaPazo").Information($"Prazos atualizado com sucesso");
            }
            catch (Exception ex)
            {
                Log.ForContext("Acao", $"AtualizaPazo").Warning($"Falha na atualização dos prazos das tramitações.{ex.Message}");
                throw new Exception("Falha na atualização dos prazos das tramitações.");
            }

            
            #endregion
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

            var dias = ContarDiasUteis(DateTime.Today, dataFutura);


            if (dias.diasUteisAtraso <= 0)
            {
                return (TimeSpan.FromDays(dias.diasUteisRestantes), (dataFutura));
            }
            else
            {
                return (TimeSpan.FromDays(dias.diasUteisAtraso * -1), dataFutura);
            }
        }
        public virtual (TimeSpan diasRestantes, DateTime dataFutura) CalculaPrazoCadastro(DateTime dataTramitacao, int prazo)
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

            var dias = ContarDiasUteis(DateTime.Today, dataFutura);


            if (dias.diasUteisAtraso <= 0)
            {
                return (TimeSpan.FromDays(dias.diasUteisRestantes), (dataFutura));
            }
            else
            {
                return (TimeSpan.FromDays(dias.diasUteisAtraso), dataFutura);
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

