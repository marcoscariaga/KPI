using SigProc.Aplicacao.Contratos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }

}
