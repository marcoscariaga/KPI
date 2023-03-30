using SigProc.Domain.Contratos.Servicos;
using SigProc.Dominio.Contratos.Dados;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System.Diagnostics;

namespace SigProc.Dominio.Servicos
{

    public class ProcessoTramitacaoDominioServico : BaseDominioServico<ProcessoTramitacao>, IProcessoTramitacaoDominioServico
    {
        private readonly IProcessoTramitacaoRepositorio _repositorio;
        private readonly IGerenciaPrazoRepositorio _gerenciaPrazo;
        public ProcessoTramitacaoDominioServico(IProcessoTramitacaoRepositorio repository, IGerenciaPrazoRepositorio gerenciaPrazo) : base(repository)
        {
            _repositorio = repository;
            _gerenciaPrazo = gerenciaPrazo;
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
            var prazo = _gerenciaPrazo.ListarTudo().Where(x => x.IdGerencia.Equals(processoTramitacao.IdOrgaoDestino)).OrderByDescending(x => x.Prazo).FirstOrDefault();

            DateTime dataAtual = DateTime.Now;
            int diasParaAcrescentar = prazo.Prazo;

            DateTime dataFutura = dataAtual;
            int diasAcrescentados = 0;
            while (diasAcrescentados < diasParaAcrescentar)
            {
                dataFutura = dataFutura.AddDays(1);
                if (dataFutura.DayOfWeek != DayOfWeek.Saturday && dataFutura.DayOfWeek != DayOfWeek.Sunday)
                {
                    diasAcrescentados++;
                }
            }

            ProcessoTramitacao tramitacao = new ProcessoTramitacao()
            {
                IdProcesso = processoTramitacao.IdProcesso,
                IdOrgaoOrigem = processoTramitacao.IdOrgaoOrigem,
                IdOrgaoDestino = processoTramitacao.IdOrgaoDestino,
                Prazo = diasAcrescentados,
                DataTramitacao = DateTime.Now,
                DataPrazo = dataFutura,
                Observacao = processoTramitacao.Observacao,
                IdUsuarioTramitacao = processoTramitacao.IdUsuarioTramitacao,
                Status = true,
                NumeroProcesso = processoTramitacao.NumeroProcesso
            };

            return _repositorio.Inserir(tramitacao);
        }

        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            return _repositorio.BuscarTramitacoesPorNumeroProcesso(numeroProcesso);
        }
    }
}
