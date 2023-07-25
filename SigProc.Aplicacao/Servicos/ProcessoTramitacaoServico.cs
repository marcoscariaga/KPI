using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Modelos.ModeloSaida;
using SigProc.Domimio.Entidades;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static SigProc.Dominio.Servicos.ProcessoTramitacaoDominioServico;

namespace SigProc.Aplicacao.Servicos
{
    public class ProcessoTramitacaoServico : BaseServico<ProcessoTramitacao>, IProcessoTramitacaoServico
    {
        private readonly IProcessoTramitacaoDominioServico processoTramitacaoDomainService;
        public ProcessoTramitacaoServico(IProcessoTramitacaoDominioServico processoTramitacaoDomainService) : base(processoTramitacaoDomainService)
        {
            this.processoTramitacaoDomainService = processoTramitacaoDomainService;
        }

        public ICollection<ProcessoTramitacao> BuscarTramitacoesPorNumeroProcesso(string numeroProcesso)
        {
            return processoTramitacaoDomainService.BuscarTramitacoesPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorIdGerenciaAtual(int idGerencia)
        {
            return processoTramitacaoDomainService.BuscarUltimaTramitacaoPorIdGerenciaAtual(idGerencia);
        }

        public ProcessoTramitacao BuscarUltimaTramitacaoPorNumeroProcesso(string numeroProcesso)
        {
            return processoTramitacaoDomainService.BuscarUltimaTramitacaoPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> BuscarUltimaTramitacaoPorUsuarioGerencial(int idUsuario)
        {
            return processoTramitacaoDomainService.BuscarUltimaTramitacaoPorUsuarioGerencial(idUsuario);
        }

        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return processoTramitacaoDomainService.ListarAtivos();
        }

        public ProcessoTramitacao SalvarMensagem(ProcessoTramitacao processoTramitacao)
        {
            return processoTramitacaoDomainService.SalvarMensagem(processoTramitacao);
        }
        public ProcessoTramitacao AtualizaTramitacao(ProcessoTramitacao processoTramitacao)
        {
            return processoTramitacaoDomainService.AtualizaTramitacao(processoTramitacao);
        }
        public ProcessoTramitacao AtualizaTramitacoesEtapaProcesso(ProcessoTramitacao processoTramitacao)
        {
            return processoTramitacaoDomainService.AtualizaTramitacoesEtapaProcesso(processoTramitacao);
        }
    }

}
