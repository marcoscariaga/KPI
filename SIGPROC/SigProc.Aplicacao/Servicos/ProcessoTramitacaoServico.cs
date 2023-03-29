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

        public ProcessoTramitacao BuscarPorNumeroProcesso(string numeroProcesso)
        {
            return processoTramitacaoDomainService.BuscarPorNumeroProcesso(numeroProcesso);
        }

        public ICollection<ProcessoTramitacao> ListarAtivos()
        {
            return processoTramitacaoDomainService.ListarAtivos();
        }
    }

}
