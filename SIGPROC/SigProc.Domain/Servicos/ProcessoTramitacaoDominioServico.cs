using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domain.Entidades;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoTramitacaoDominioServico : BaseDominioServico<ProcessoTramitacao>, IProcessoTramitacaoDominioServico
    {
        private readonly IProcessoTramitacaoRepositorio _repositorio;
        private readonly IGerenciaPrazoRepositorio _gerenciaPrazo;
        private readonly IGerenciaUsuarioRepositorio _gerenciaUsuario;
        private readonly IFeriadoRepositorio _feriadoRepositorio;
        public ProcessoTramitacaoDominioServico(IProcessoTramitacaoRepositorio repository, IGerenciaPrazoRepositorio gerenciaPrazo, IGerenciaUsuarioRepositorio gerenciaUsuario, IFeriadoRepositorio feriadoRepositorio) : base(repository)
        {
            _repositorio = repository;
            _gerenciaPrazo = gerenciaPrazo;
            _gerenciaUsuario = gerenciaUsuario;
            _feriadoRepositorio = feriadoRepositorio;
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            return _repositorio.BuscarUltimaTramitacaoPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public ProcessoTramitacao Inserir(ProcessoTramitacao processoTramitacao)
        {
            #region Busca o prazo, e o feriados para fazer o cálculo do prazo da tramitação

            var prazo = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(processoTramitacao.IdOrgaoDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault();
            var feriados = _feriadoRepositorio.ListarDatas();

            DateTime dataAtual = DateTime.Today;
            int diasParaAcrescentar = prazo.Prazo;

            DateTime dataFutura = dataAtual;
            int diasAcrescentados = 0;

            while (diasAcrescentados < diasParaAcrescentar)
            {
                dataFutura = dataFutura.AddDays(1);
                if (dataFutura.DayOfWeek != DayOfWeek.Saturday && dataFutura.DayOfWeek != DayOfWeek.Sunday && !feriados.Contains(dataFutura))
                {
                    diasAcrescentados++;
                }
            }
            var tempoPrazo = dataFutura - DateTime.Today;

            #endregion

            #region Atualiza a tramitação anterior com o tempo e data de envio

            var ultimaTramitacao = _repositorio.ListarTudo().OrderByDescending(x => x.DataCriacao).FirstOrDefault(x => x.NumeroProcesso.Equals(processoTramitacao.NumeroProcesso));
            TimeSpan tempoEnvio = ((TimeSpan)(DateTime.Today - ultimaTramitacao.DataTramitacao));
            ultimaTramitacao.TempoEnvio = tempoEnvio.Days;
            ultimaTramitacao.DataEnvio = dataAtual;
            _repositorio.Atualizar(ultimaTramitacao);
            
            #endregion

            ProcessoTramitacao tramitacao = new ProcessoTramitacao()
            {
                IdProcesso = processoTramitacao.IdProcesso,
                IdOrgaoOrigem = processoTramitacao.IdOrgaoOrigem,
                IdOrgaoDestino = processoTramitacao.IdOrgaoDestino,
                Prazo = tempoPrazo.Days,
                DataTramitacao = dataAtual,
                DataPrazo = dataFutura,
                Observacao = processoTramitacao.Observacao,
                TempoPrazo = tempoPrazo.Days,
                IdUsuarioTramitacao = processoTramitacao.IdUsuarioTramitacao,
                Status = true,
                NumeroProcesso = processoTramitacao.NumeroProcesso,
                TempoEnvio = null,
                DataEnvio = null
            };

            return _repositorio.Inserir(tramitacao);
        }

        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            return _repositorio.BuscarTramitacoesPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia)
        {
            return _repositorio.BuscarUltimaTramitacaoPorIdGerenciaAtual(idGerencia);
        }

        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
            var gerencias = _gerenciaUsuario.ListarAtivos().Where(x => x.IdUsuarioGerencia == idUsuario).ToList();

            return  gerencias.SelectMany(g => _repositorio.BuscarUltimaTramitacaoPorIdGerenciaAtual(g.IdGerencia)).ToList();
        }
    }
}

