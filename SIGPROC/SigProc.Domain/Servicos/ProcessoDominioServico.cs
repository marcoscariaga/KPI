using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ServiceSicop;
using SigProc.Domain.Contratos.Servicos;
using SigProc.Domimio.Contratos.Dados;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoDominioServico : BaseDominioServico<Processo>, IProcessoDominioServico
    {
        private readonly IProcessoRepositorio _repositorio;
        private readonly IGerenciaRepositorio _gerencia;
        private readonly IProcessoTramitacaoRepositorio _processoTramitacao;
        private readonly IGerenciaPrazoRepositorio _gerenciaPrazo;
        private readonly IFeriadoRepositorio _feriadoRepositorio;
        public ProcessoDominioServico(IProcessoRepositorio repository, IGerenciaRepositorio gerencia, IProcessoTramitacaoRepositorio processoTramitacao, IGerenciaPrazoRepositorio gerenciaPrazo, IFeriadoRepositorio feriadoRepositorio) : base(repository)
        {
            _repositorio = repository;
            _gerencia = gerencia;
            _processoTramitacao = processoTramitacao;
            _gerenciaPrazo = gerenciaPrazo;
            _feriadoRepositorio = feriadoRepositorio;
        }

        public ICollection<Processo> ListarAtivos()
        {
            return _repositorio.ListarAtivos();
        }
        public Processo Inserir(Processo processo)
        {
            #region Validação parada cadastrar o processo

            var consultaProcesso = _repositorio.BuscarPorNumeroProcesso(processo.NumProcesso);
            if (consultaProcesso != null)
                throw new ArgumentException($"O processo {processo.NumProcesso} já está cadastrado no sistema.");

            string[] siglaDestino = processo.OrgaoDestino.Split(new string[] { " - " }, StringSplitOptions.None);
            string[] siglaOrigem = processo.OrgaoOrigem.Split(new string[] { " - " }, StringSplitOptions.None);

            var orgaoDestino = _gerencia.BuscarPorSiglaGerencia(siglaDestino[1].Trim());
            if (orgaoDestino == null)
                throw new ArgumentException($"A gerência {siglaDestino}, não está cadastrada no sistema.");

            var orgaoOrigem = _gerencia.BuscarPorSiglaGerencia(siglaOrigem[1].Trim());
            if (orgaoOrigem == null)
                throw new ArgumentException($"A gerência {orgaoOrigem}, não está cadastrada no sistema.");

            var cadProcesso = _repositorio.Inserir(processo);

            #endregion

            try
            {
                #region Busca o prazo, e o feriados para fazer o cálculo do prazo da tramitação

                var prazo = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(orgaoDestino.Id)).OrderByDescending(x => x.Prazo).FirstOrDefault();
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

                ProcessoTramitacao processoTramitacao = new ProcessoTramitacao()
                {
                    IdProcesso = cadProcesso.Id,
                    IdOrgaoOrigem = orgaoOrigem.Id,
                    IdOrgaoDestino = orgaoDestino.Id,
                    Prazo = diasAcrescentados,
                    DataTramitacao = DateTime.Today,
                    DataPrazo = dataFutura,
                    Observacao = processo.Observacao,
                    IdUsuarioTramitacao = processo.IdUsuarioCadastro,
                    Status = true,
                    NumeroProcesso = processo.NumProcesso,
                    TempoPrazo = diasAcrescentados,
                    TempoEnvio = null,
                    DataEnvio = null
                };


                _processoTramitacao.Inserir(processoTramitacao);
            }
            catch (Exception)
            {

                _repositorio.Deletar(processo);
                throw new ArgumentException($"Erro ao cadastrar a tramitação, tente novamente.");
            }


            return cadProcesso;
        }
    }
}
