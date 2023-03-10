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
    public class ProcessoServico : BaseServico<Processo>, IProcessoServico
    {
        private readonly IProcessoDominioServico processoDomainService;
        public ProcessoServico(IProcessoDominioServico processoDomainService) : base(processoDomainService)
        {
            this.processoDomainService = processoDomainService;
        }

        public ICollection<Processo> ListarAtivos()
        {
            return processoDomainService.ListarAtivos();
        }
    }

}
