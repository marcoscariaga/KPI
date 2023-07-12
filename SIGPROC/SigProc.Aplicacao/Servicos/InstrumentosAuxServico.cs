using SigProc.Aplicacao.Contratos;
using SigProc.Aplicacao.Servicos;
using SigProc.Dominio.Contratos.Servicos;
using SigProc.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigProc.Aplicacao.Servicos
{
    public class InstrumentosAuxServico : BaseServico<InstrumentosAux>, IInstrumentosAuxServico
    {
        private IInstrumentosAuxDominioServico instrumentosAuxDomainService;

        public InstrumentosAuxServico(IInstrumentosAuxDominioServico instrumentosAuxDomainService) : base(instrumentosAuxDomainService)
        {
            this.instrumentosAuxDomainService = instrumentosAuxDomainService;
        }

        public ICollection<InstrumentosAux> ListarAtivos()
        {
            return instrumentosAuxDomainService.ListarAtivos();
        }
    }

}
