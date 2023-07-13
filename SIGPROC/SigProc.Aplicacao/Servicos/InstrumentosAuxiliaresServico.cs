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
    public class InstrumentosAuxiliaresServico : BaseServico<InstrumentosAuxiliares>, IInstrumentosAuxiliaresServico
    {
        private IInstrumentosAuxiliaresDominioServico instrumentosAuxDomainService;

        public InstrumentosAuxiliaresServico(IInstrumentosAuxiliaresDominioServico instrumentosAuxiliaresDomainService) : base(instrumentosAuxiliaresDomainService)
        {
            this.instrumentosAuxDomainService = instrumentosAuxiliaresDomainService;
        }

        public ICollection<InstrumentosAuxiliares> ListarAtivos()
        {
            
        }
    }

}
